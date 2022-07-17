using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SpecialTagController : Controller
    {
        private ApplicationDbContext _db;
        public SpecialTagController(ApplicationDbContext dp)
        {
            _db = dp;
        }
        public IActionResult Index()
        {
            return View(_db.specialTags.ToList());
        }
        //Create Get Action Method
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _db.specialTags.Add(specialTag);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product type has been saved ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(specialTag);
        }

        //Edit Get Action Method
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var specialTag = _db.specialTags.Find(id);

            if (specialTag == null)
                return NotFound();

            return View(specialTag);
        }

        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _db.specialTags.Update(specialTag);
                await _db.SaveChangesAsync();
                TempData["Update"] = "Product type has been Updated ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(specialTag);
        }

        //Details Get Action Method
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var specialtag = _db.specialTags.Find(id);

            if (specialtag == null)
                return NotFound();

            return View(specialtag);
        }

        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(SpecialTag specialTag)
        {
            return RedirectToAction(actionName: nameof(Index));

        }

        //Delete Get Action Method
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var specialTag = _db.specialTags.Find(id);

            if (specialTag == null)
                return NotFound();

            return View(specialTag);
        }

        //Delete Post Action Method
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBrand(int? id)
        {
            //    if (id == null || id != productTypes.Id)
            //        return NotFound();


            if (id == null)
                return NotFound();
            

            var specialTag = _db.specialTags.Find(id);

            if (specialTag == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                _db.Remove(specialTag);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "SpecialTag has been Deleted ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(specialTag);
        }

    }

}