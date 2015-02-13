using Helpers.Models;
using Microsoft.AspNet.Mvc.Rendering;
using System;

namespace Helpers.Views.DropDownList
{
    public class CreateViewModel
    {
        public SelectList Categories { get; set; }

        public Movie Movie { get; set; }
    }
}