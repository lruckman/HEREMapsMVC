using System.Collections.Generic;
using System.Net;
using HEREMapsMVC.Models;

namespace HEREMapsMVC.Extensions
{
    public static class Objects
    {
        public static string ToQueryString(this object obj)
        {
            var properties = obj.GetType().GetProperties();
            var parameters = new List<string>();

            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(obj, null);

                if (propertyValue == null)
                {
                    continue;
                }

                if ((propertyValue as ParameterCollection) != null)
                {
                    parameters.Add((propertyValue as ParameterCollection).ToString());
                    continue;
                }

                propertyValue = WebUtility.UrlEncode(propertyValue.ToString());

                parameters.Add($"{property.Name}={propertyValue}");
            }

            return string.Join("&", parameters);
        }
    }
}