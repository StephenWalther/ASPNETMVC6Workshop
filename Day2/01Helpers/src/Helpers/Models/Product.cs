using System;
using System.ComponentModel.DataAnnotations;

namespace Helpers.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}