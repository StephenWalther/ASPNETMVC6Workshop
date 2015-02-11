using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Product
        public IActionResult Index()
        {
            return View(db.Product.ToList());
        }

        // GET: Product/Details/5
        public IActionResult Details(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Product product = db.Product.Single(m => m.Id == id);
            if (product == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(product);
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
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Product product = db.Product.Single(m => m.Id == id);
            if (product == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
               
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Product product = db.Product.Single(m => m.Id == id);
            if (product == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(System.Int32 id)
        {
            Product product = db.Product.Single(m => m.Id == id);
            db.Product.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
