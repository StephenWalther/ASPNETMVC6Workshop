using Microsoft.AspNet.Mvc;
using TagHelpersDemo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelpersDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Create()
        {
            var product = new Product
            {
                Name = "Milk",
                Price = 2.33m
            };
            return View(product);
        }
    }
}
