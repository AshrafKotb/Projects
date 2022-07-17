using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Areas.Customer;
using Microsoft.AspNetCore.Authorization;


namespace OnlineShop.Areas.Customer.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        UserManager<IdentityUser> _usermanager;
        ApplicationDbContext _dp;
        public UserController(UserManager<IdentityUser> usermanager, ApplicationDbContext dp)
        {
            _usermanager = usermanager;
            _dp = dp;
        }
        public IActionResult Index()
        {
            return View(_dp.applicationUsers.Where(c=> c.FirstName != "Admin").ToList());
        }
        [AllowAnonymous]
        
        ///Get Action Create User
        public async Task<IActionResult> Create()
        {

            return View();
        }

        ///Post Action Create User
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                var result = await _usermanager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                    var issaverole = await _usermanager.AddToRoleAsync(user, "User");
                    TempData["save"] = "Account Created Successfully";
                    return Redirect("https://localhost:44358");

                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View();
        }
        //Edit Get Action Method
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }
        //Edit Post Action Method
        [HttpPost]
        
        public async Task<ActionResult> Edit(ApplicationUser user)
        {
            var userinfo = _dp.applicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userinfo == null)
                return NotFound();

            userinfo.FirstName = user.FirstName;
            userinfo.LastName = user.LastName;
            var result = await _usermanager.UpdateAsync(userinfo);

            if (result.Succeeded)
            {
                TempData["save"] = "User Data Updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userinfo);

        }
        //Details Get Action Method
        [HttpGet]
        public async Task<ActionResult> Details(string id)
        {
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }

        //Lockout Get Action Method
        [HttpGet]
        public async Task<ActionResult> Locout(string id)
        {
            if (id == null)
                return NotFound();
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }
        //Lockout Post Action Method
        [HttpPost]
        public async Task<ActionResult> Locout(ApplicationUser user)
        {
            var user_info = _dp.applicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (user_info.LockoutEnd == null || user_info.LockoutEnd < DateTime.Now)
            {
                if (user_info == null)
                    return NotFound();

                user_info.LockoutEnd = DateTime.Now.AddYears(100);
                int rowaffected = _dp.SaveChanges();
                if (rowaffected > 0)
                {
                    TempData["Delete"] = user_info.UserName + " has been Locked out Successfully";
                    return RedirectToAction(nameof(Index));
                }
                return View(user_info);
            }
            else
            {
                TempData["Delete"] = user_info.UserName + " has been locked out before";
                return RedirectToAction(nameof(Index));
            }
        }
        //Get active method
        
        public async Task<ActionResult> Active(string id)
        {
            if (id == null)
                return NotFound();
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }

        // Post Action Method
        [HttpPost]
        public async Task<ActionResult> Active(ApplicationUser user)
        {
            var user_info = _dp.applicationUsers.FirstOrDefault(c => c.Id == user.Id);

            if (user_info == null)
                return NotFound();

            user_info.LockoutEnd = DateTime.Now.AddDays(-1);
            int rowaffected = _dp.SaveChanges();
            if (rowaffected > 0)
            {
                TempData["save"] = user_info.UserName + " has been Active Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(user_info);

        }

        //Get Delete method
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
                return NotFound();
            var user = _dp.applicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
                return NotFound();

            return View(user);
        }

        // Post Delete Method
        [HttpPost]
        public async Task<ActionResult> Delete(ApplicationUser user)
        {
            var user_info = _dp.applicationUsers.FirstOrDefault(c => c.Id == user.Id);

            if (user_info == null)
                return NotFound();

            _dp.applicationUsers.Remove(user_info);
            int rowaffected = _dp.SaveChanges();
            if (rowaffected > 0)
            {
                TempData["Delete"] = user_info.UserName + " has been Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(user_info);

        }

    }
}
