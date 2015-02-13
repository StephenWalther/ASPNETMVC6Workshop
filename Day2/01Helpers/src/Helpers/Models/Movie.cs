using System;

namespace Helpers.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Category Category { get; set; }
    }
}