using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductController : Controller
    {
        static List<string> imgtemp = new List<string>();
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;
        public ProductController(ApplicationDbContext dp, IHostingEnvironment he)
        {
            _db = dp;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_db.products.Include(c => c.ProductTypes).Include(f => f.SpecialTag).ToList());
        }

        //index post action method
        [HttpPost]
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if (lowAmount == null || largeAmount == null)
                products = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag).ToList();

            return View(products);
        }

        //Create Get Action Method
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["ProductTypeID"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
            ViewData["SpecialTagID"] = new SelectList(_db.specialTags.ToList(), "id", "name");
            return View();
        }

        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var searchproduct = _db.products.FirstOrDefault(x => x.Name == products.Name);
                if (searchproduct != null)
                {
                    ViewBag.message = "This product is already exist";
                    ViewData["ProductTypeID"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
                    ViewData["SpecialTagID"] = new SelectList(_db.specialTags.ToList(), "id", "name");
                    return View(products);
                }
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/assets/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
               
                    products.Image = "assets/images/" + image.FileName;
                }

                if (image == null)
                {
                    products.Image = "assets/images/noimage.jpg";
                }
                _db.products.Add(products);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product has been saved ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(products);
        }

        //Edit Get Action Method
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            ViewData["ProductTypeID"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
            ViewData["SpecialTagID"] = new SelectList(_db.specialTags.ToList(), "id", "name");
            if (id == null)
                return NotFound();

            var product = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .FirstOrDefault(c => c.Id == id);

            if (product == null)
                return NotFound();
            imgtemp.Add(product.Image);
            return View(product);
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product prod, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/assets/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    prod.Image = "assets/images/" + image.FileName;
                }
                if (image == null)
                    prod.Image = imgtemp.ElementAt(imgtemp.Count - 1);

                _db.products.Update(prod);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product has been saved ";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(prod);
        }


        //Details Get Action Method
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var product = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .FirstOrDefault(c => c.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        //Delete Get Action Method
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var product = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound();

            return View(product);
        }

        //Delete post Action Method
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
                return NotFound();

            var product = _db.products.FirstOrDefault(c => c.Id == id);

            if (product == null)
                return NotFound();
            

            _db.products.Remove(product);
           await _db.SaveChangesAsync();
            if (product.Image != "~/assets/images/noimage.jpg")
            {
                var imgdel = Path.Combine(_he.WebRootPath, product.Image);
                FileInfo fi = new FileInfo(imgdel);
                if (fi != null)
                    System.IO.File.Delete(imgdel);
                fi.Delete();
            }
            TempData["Delete"] = "Product type has been Deleted ";
            return RedirectToAction(actionName: nameof(Index));
}

    }
}
