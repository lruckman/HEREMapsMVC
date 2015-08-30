using System.ComponentModel;
using System.Drawing;
using HEREMapsMVC.Extensions;

namespace HEREMapsMVC.Models
{
    public interface IBaseTextField
    {
        string ToString();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class BaseTextField : IBaseTextField
    {
        private readonly string _textLocation;
        private readonly string _text;
        private readonly Color? _textColor;
        private readonly Color? _textBorderColor;
        private readonly int? _textFontSize;

        public BaseTextField(double lat, double lng, string text, Color? textColor, Color? textBorderColor,
            int? textFontSize)
            : this(text, textColor, textBorderColor, textFontSize)
        {
            _textLocation = new GeoCoordinate(lat, lng)
                .ToString();
        }

        public BaseTextField(int x, int y, string text, Color? textColor, Color? textBorderColor, int? textFontSize)
            : this(text, textColor, textBorderColor, textFontSize)
        {
            _textLocation = new PixelCoordinate(x, y)
                .ToString();
        }

        private BaseTextField(string text, Color? textColor, Color? textBorderColor, int? textFontSize)
        {
            _text = text;
            _textColor = textColor;
            _textBorderColor = textBorderColor;
            _textFontSize = textFontSize;
        }

        public override string ToString()
        {
            return
                $"{_textLocation};{_text};{_textColor?.ToAlphaHexString()};{_textBorderColor?.ToAlphaHexString()};{_textFontSize}";
        }
    }
}