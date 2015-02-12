using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using TypedViews.Models;
using TypedViews.Views.Products;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TypedViews.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Weak()
        {
            var products = new List<Product>
            {
                new Product { Name="Milk", Price=2.33m},
                new Product { Name="Cheese", Price=1.33m},
                new Product { Name="Steak", Price=4.33m}
            };

            // add to view data
            ViewData["products"] = products;

            // return view
            return View();
        }

        public IActionResult Dynamic()
        {
            var products = new List<Product>
            {
                new Product { Name="Milk", Price=2.33m},
                new Product { Name="Cheese", Price=1.33m},
                new Product { Name="Steak", Price=4.33m}
            };

            // add to view bag
            ViewBag.Products = products;

            return View();
        }

        public IActionResult Strong()
        {
            var products = new List<Product>
            {
                new Product { Name="Milk", Price=2.33m},
                new Product { Name="Cheese", Price=1.33m},
                new Product { Name="Steak", Price=4.33m}
            };

            // create strongly typed view model
            var vm = new StrongViewModel
            {
                Products = products
            };

            return View(vm);
        }


    }
}
