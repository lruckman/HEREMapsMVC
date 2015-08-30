using HEREMapsMVC.Enums;

namespace HEREMapsMVC
{
    internal class Config
    {
        private const string BaseUrl = "image.maps.api.here.com";
        private const string Path = "mia/1.6";
        private static readonly string AppId = System.Configuration.ConfigurationManager.AppSettings["HereMaps.AppId"];
        private static readonly string AppCode = System.Configuration.ConfigurationManager.AppSettings["HereMaps.AppCode"];

        public static string GetEndpoint(Resource resource, bool secure = true)
        {
            return $"{(secure ? "https" : "http")}://{BaseUrl}/{Path}/{resource}?app_code={AppCode}&app_id={AppId}";
        }
    }
}