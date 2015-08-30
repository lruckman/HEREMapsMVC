using System.Web;

namespace HEREMapsMVC.Api.Rest
{
    public interface IBuilder : IHtmlString
    {
        string ToString();
    }
}