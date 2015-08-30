using System.Drawing;

namespace HEREMapsMVC.Models
{
    public interface IGeoTextField : IBaseTextField
    {
    }

    public class GeoTextField : BaseTextField, IGeoTextField
    {
        public GeoTextField(double lat, double lng, string text, Color? textColor, Color? textBorderColor,
            int? textFontSize)
            : base(lat, lng, text, textColor, textBorderColor, textFontSize)
        {
        }

        public GeoTextField(double lat, double lng, string text) : base(lat, lng, text, null, null, null)
        {
        }

        public GeoTextField(double lat, double lng) : base(lat, lng, null, null, null, null)
        {
        }
    }
}