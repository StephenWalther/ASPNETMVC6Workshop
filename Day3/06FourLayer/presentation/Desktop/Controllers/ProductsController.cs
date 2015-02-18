using Microsoft.AspNet.Mvc;
using Services.Models;
using Services.Services;

namespace Desktop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.List();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(FullProductDTO product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(FullProductDTO product)
        {
            if (ModelState.IsValid)
            {
                _productService.Edit(product);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
