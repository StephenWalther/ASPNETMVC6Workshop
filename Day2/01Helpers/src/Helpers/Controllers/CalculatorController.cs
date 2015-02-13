using Helpers.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Helpers.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Add(Calculator vm)
        {
            vm.Result = vm.FirstNumber + vm.SecondNumber;
            return View(vm);
        }


    }
}
