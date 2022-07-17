using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Utility;
using X.PagedList;

namespace OnlineShop.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private ApplicationDbContext _dp;

        public HomeController(ApplicationDbContext dp)
        {
            _dp = dp;

        }
        public IActionResult Index(int ? page)
        {
            return View(_dp.products.Include(s=> s.ProductTypes).Include(s=> s.SpecialTag).ToList().ToPagedList(page??1 ,6));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Product Details Get Action Method
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var product =_dp.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .FirstOrDefault(c => c.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }


        //Product Details Post Action Method
        [HttpPost]
        [ActionName("Details")]
        public ActionResult ProductDetails(int? id)
        {
            List<Product> products = new List<Product>();
            if (id == null)
                return NotFound();

            var product = _dp.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .FirstOrDefault(c => c.Id == id);
            if (product == null)
                return NotFound();
            products = HttpContext.Session.Get<List<Product>>("products");
            if (products == null)
                products = new List<Product>();
            products.Add(product);
            HttpContext.Session.Set("products",products);
            return RedirectToAction(actionName: nameof(Index));
        }


        ///Get Product remove action method Card
        [ActionName("Remove")]
        public ActionResult RemoveToCart(int? id)
        {
            List<Product> prods = HttpContext.Session.Get<List<Product>>("products");
            if (prods != null)
            {
                var product = prods.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    prods.Remove(product);
                    HttpContext.Session.Set("products", prods);
                }
            }
            return RedirectToAction(actionName: nameof(Index));
        }

        ///Post Product remove action method Card
        [HttpPost]
        public ActionResult Remove(int? id)
        {
            List<Product> prods = HttpContext.Session.Get<List<Product>>("products");
            if (prods != null)
            {
                var product = prods.FirstOrDefault(c => c.Id == id);
                if(product != null)
                {
                    prods.Remove(product);
                    HttpContext.Session.Set("products", prods);
                }
            }
            return RedirectToAction(actionName: nameof(Index));
        }

        //Product Cart Action method //GET
        public ActionResult Cart(int? id)
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            if(products ==null)
            {
               products= new List<Product>();
            }
            return View(products);
        }

    }
}
