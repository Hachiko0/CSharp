using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace KrasnoSeloShop
{
    public static class ImageActionLinkHelper
    {
        public static IHtmlString  ImageActionLink(this AjaxHelper helper, string imageUrl, string actionName,string controllerName, object routeValues, AjaxOptions ajaxOptions)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", imageUrl);
            var link = helper.ActionLink("[replaceme]", actionName, controllerName, routeValues, ajaxOptions);
            return MvcHtmlString.Create(link.ToHtmlString().Replace("[replaceme]", builder.ToString(TagRenderMode.SelfClosing)));
            //return link.ToHtmlString().Replace("[replaceme]", builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}