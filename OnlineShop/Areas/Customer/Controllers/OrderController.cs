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

namespace OnlineShop.Controllers
{
    [Area("Customer")]

    public class OrderController : Controller
    {
        private ApplicationDbContext _dp;

        public OrderController(ApplicationDbContext dp)
        {
            _dp = dp;

        }
        public IActionResult Index()
        {
            return View();
        }

        //Get Chechout Action Method

        public IActionResult Checkout()
        {
            return View();
        }
        //Post Chechout Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order anOrder)
        {
            List<Product> prods = HttpContext.Session.Get<List<Product>>("products");
            if (prods != null)
            {
                foreach (var product in prods)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }
            anOrder.OrderNo = GetOrderNo();
            _dp.orders.Add(anOrder);
            await _dp.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Product>());
            return View();
        }

        //Get Order number Action Method

        public string GetOrderNo()
        {
            int rowcount = _dp.orders.ToList().Count + 1;

            return rowcount.ToString("000");
        }
    }
}