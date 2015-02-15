using Microsoft.AspNet.Mvc;
using System;

namespace Partials.Components
{
    public class BannerAd : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var adText = "Buy more coffee!";

            if (DateTime.Now.Hour > 18)
            {
                adText = "Buy more warm milk!";
            }
            return View("_Advertisement", adText);
        }
    }
}