using System.Web.Mvc;
using HEREMapsMVC.Api.Rest;

namespace HEREMapsMVC
{
    public static class HtmlHelperExtensions
    {
        public static IMapImageBuilder MapImage(this HtmlHelper htmlHelper)
        {
            return new MapImageBuilder();
        }
    }
}