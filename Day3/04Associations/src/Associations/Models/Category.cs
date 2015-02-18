using System;
using System.Collections.Generic;

namespace Associations.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}