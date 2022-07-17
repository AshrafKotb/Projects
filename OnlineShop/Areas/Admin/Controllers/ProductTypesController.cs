using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;
        public ProductTypesController(ApplicationDbContext dp)
        {
            _db = dp;
        }
        public IActionResult Index()
        {
            return View(_db.productTypes.ToList());
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
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.productTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product type has been saved ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }

        //Edit Get Action Method
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var productType = _db.productTypes.Find(id);

            if (productType == null)
                return NotFound();

            return View(productType);
        }

        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.productTypes.Update(productTypes);
                await _db.SaveChangesAsync();
                TempData["Update"] = "Product type has been Updated ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }

        //Details Get Action Method
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var productType = _db.productTypes.Find(id);

            if (productType == null)
                return NotFound();

            return View(productType);
        }

        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes productTypes)
        {
            return RedirectToAction(actionName: nameof(Index));

        }


        //Delete Get Action Method
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var productType = _db.productTypes.Find(id);

            if (productType == null)
                return NotFound();

            return View(productType);
        }

        //Delete Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductTypes productTypes)
        {
            //    if (id == null || id != productTypes.Id)
            //        return NotFound();


            if (id == null)
                return NotFound();

            if (id != productTypes.Id)
                return NotFound();

            var productType = _db.productTypes.Find(id);

            if (productType == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Product type has been Deleted ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);
        }

    }
}