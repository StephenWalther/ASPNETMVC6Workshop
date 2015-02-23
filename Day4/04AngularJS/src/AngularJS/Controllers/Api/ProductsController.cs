using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using AngularJS.Models;

namespace AngularJS.Controllers.Api.Controllers
{

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // Don't do this in production!
        private static List<Product> _products = new List<Product> {
            new Product { Name="Cheese", Price=2.33m },
            new Product { Name="Milk", Price=1.33m },
            new Product { Name="Eggs", Price=2.33m }
        };


        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            return new ObjectResult(product);
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
