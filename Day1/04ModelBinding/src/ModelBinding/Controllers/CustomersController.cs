using Microsoft.AspNet.Mvc;
using ModelBinding.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelBinding.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            return View();
        }


    }
}
