using Helpers.Models;
using Helpers.Views.DropDownList;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Helpers.Controllers
{
    public class DropDownListController : Controller
    {
        // GET: /<controller>/
        public IActionResult Create()
        {
            var vm = new CreateViewModel();
            this.PopulateCategories(vm);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel vm)
        {
            this.PopulateCategories(vm);
            return View(vm);
        }

        private void PopulateCategories(CreateViewModel vm)
        {
            var categories = new List<Category>
            {
                new Category { Id=1, Name="Action"},
                new Category { Id=2, Name="Romance"}
            };

            vm.Categories = new SelectList(categories, "Id", "Name");
        }
    }
}
