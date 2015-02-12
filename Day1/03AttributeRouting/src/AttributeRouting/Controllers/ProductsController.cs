using AttributeRouting.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AttributeRouting.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public IActionResult Details(System.Int32? id)
        {
            return View();
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            return View(product);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(System.Int32? id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            return View(product);
        }

        // GET: Product/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(System.Int32? id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(System.Int32 id)
        {
            return RedirectToAction("Index");
        }
    }
}

