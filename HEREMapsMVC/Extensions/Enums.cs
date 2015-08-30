using System;
using System.ComponentModel;
using System.Linq;

namespace HEREMapsMVC.Extensions
{
    public static class Enums
    {
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();

            return GetEnumDescription(value.ToString(), type);
        }

        public static string GetDescriptionForEnum(this Type type, object value)
        {
            return GetEnumDescription(value.ToString(), type);
        }

        private static string GetEnumDescription(string value, Type type)
        {
            var memberInfo = type.GetMember(value);

            if (memberInfo.Length <= 0)
            {
                return value;
            }
            
            var info = memberInfo.First()
                .GetCustomAttributes(typeof (DescriptionAttribute), false)
                .FirstOrDefault();

            return info != null 
                ? ((DescriptionAttribute) info).Description 
                : value;
        }
    }
}