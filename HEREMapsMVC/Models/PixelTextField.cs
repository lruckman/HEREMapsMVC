using System.Drawing;

namespace HEREMapsMVC.Models
{
    public interface IPixelTextField : IBaseTextField
    {
    }

    public class PixelTextField : BaseTextField, IPixelTextField
    {
        public PixelTextField(int x, int y, string text, Color textColor, Color textBorderColor,
            int? textFontSize) : base(x, y, text, textColor, textBorderColor, textFontSize)
        {
        }

        public PixelTextField(int x, int y, string text) : base(x, y, text, null, null, null)
        {
        }
    }
}