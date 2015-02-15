using Microsoft.AspNet.Mvc.Rendering;
using System;

namespace Helpers.MyHelpers  
{
    public static class ImageHelper
    {
        public static HtmlString Image(this IHtmlHelper helper, string src)
        {
            var tb = new TagBuilder("img");
            tb.MergeAttribute("src", src);
            return tb.ToHtmlString(TagRenderMode.SelfClosing);
        }

    }
}