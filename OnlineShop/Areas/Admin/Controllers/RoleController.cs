using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Areas.Admin.Model;
using OnlineShop.Data;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _rolemanager;
        ApplicationDbContext _dp;
        UserManager<IdentityUser> _userManager;
        public RoleController(RoleManager<IdentityRole> rolemanager, ApplicationDbContext dp, UserManager<IdentityUser> userManager)
        {
            _rolemanager = rolemanager;
            _dp = dp;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var roles = _rolemanager.Roles.ToList();
            ViewBag.Roles = roles;
            return View();
        }
        //Get create method
        public async Task<IActionResult> Create()
        {
            return View();

        }
        //post create method
        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            IdentityRole identityRole = new IdentityRole();
            identityRole.Name = name;
            var isExist = await _rolemanager.RoleExistsAsync(identityRole.Name);
            if (isExist)
            {

                ViewBag.msg = name + " Role is Already exists";
                ViewBag.Name = name;
                return View();
            }
            var result = await _rolemanager.CreateAsync(identityRole);
            if (result.Succeeded)
            {
                TempData["save"] = name + " Role has been Created Successfully";
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        //Get Edit method
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _rolemanager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();

        }
        //post Edit method
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name)
        {
            var role = await _rolemanager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            if (role.Name != "Admin" && role.Name != "User")
            {


                role.Name = name;
                var isExist = await _rolemanager.RoleExistsAsync(role.Name);
                if (isExist)
                {

                    ViewBag.msg = name + " Role is Already exists";
                    ViewBag.Name = name;
                    return View();
                }

                var result = await _rolemanager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    TempData["save"] = "Role has been Updated Successfully";
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                TempData["Delete"] = " Update This Role is not allow";
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        //Get Delete method
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _rolemanager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();

        }
        //post Delete method
        [HttpPost]
        public async Task<IActionResult> Delete(string id, string name)
        {
            var role = await _rolemanager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            if (role.Name != "Admin" && role.Name != "User")
            {
                var result = await _rolemanager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    TempData["Delete"] = "Role has been Deleted Successfully";
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                TempData["Delete"] = " Delete This Role is not allow";
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        //Assign Get method

        public async Task<IActionResult> Assign()
        {
            ViewData["userid"] = new SelectList(_dp.applicationUsers.Where(f => f.LockoutEnd > DateTime.Now || f.LockoutEnd == null).ToList(), "Id", "UserName");
            ViewData["roleid"] = new SelectList(_rolemanager.Roles.ToList(), "Name", "Name");
            return View();

        }

        //Assign post method
        [HttpPost]
        public async Task<IActionResult> Assign(RoleUservm roleuser)
        {
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == roleuser.userid);
            var ischeck = await _userManager.IsInRoleAsync(user, roleuser.roleid);
            if (ischeck)
            {
                ViewBag.msg = "This user already assign this role";
                ViewData["userid"] = new SelectList(_dp.applicationUsers.Where(f => f.LockoutEnd > DateTime.Now || f.LockoutEnd == null).ToList(), "Id", "UserName");
                ViewData["roleid"] = new SelectList(_rolemanager.Roles.ToList(), "Name", "Name");
                return View();
            }
            var role = await _userManager.AddToRoleAsync(user, roleuser.roleid);
            if (role.Succeeded)
            {
                TempData["save"] = "User Role Assigned";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> AssignUserRole()
        {
            var result = from ur in _dp.UserRoles
                         join r in _dp.Roles on ur.RoleId equals r.Id
                         join a in _dp.applicationUsers on ur.UserId equals a.Id
                         select new UserRoleMaping
                         {
                             Userid = ur.RoleId,
                             Roleid = r.Id,
                             UserName = a.UserName,
                             RoleNAme = r.Name
                         };
            ViewBag.Roles = result;
            return View();
        }
    }
}