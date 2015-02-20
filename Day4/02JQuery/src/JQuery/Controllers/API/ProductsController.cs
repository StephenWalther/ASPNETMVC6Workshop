using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using JQuery.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace JQuery.Controllers.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product {Name="Milk", Price=3.22m},
                new Product {Name="Cheese", Price=1.22m },
                new Product {Name="Bread", Price=3.11m }
            };
        }
        
    }
}
