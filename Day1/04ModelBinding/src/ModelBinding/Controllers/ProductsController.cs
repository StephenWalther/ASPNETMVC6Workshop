using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.WebUtilities.Collections;
using ModelBinding.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelBinding.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View();
        }



    }
}
