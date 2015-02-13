using Microsoft.AspNet.Mvc.Rendering;
using System;

// Must be this namespace!
namespace Microsoft.AspNet.Mvc.Rendering
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