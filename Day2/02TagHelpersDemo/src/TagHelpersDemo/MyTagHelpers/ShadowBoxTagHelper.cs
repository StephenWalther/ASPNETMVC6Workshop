using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;

namespace TagHelperDemo.MyTagHelpers
{
    [TagName("shadowbox")]
    public class ShadowBoxTagHelper : TagHelper
    {
        [HtmlAttributeName("bordercolor")]
        public string BorderColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes["style"] = String.Format(
                "padding:10px;background-color:lightgray;border:4px solid {0}", 
                this.BorderColor ?? "black" 
            );
        }
    }
}