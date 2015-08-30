using System.Drawing;
using HEREMapsMVC.Extensions;

namespace HEREMapsMVC.Models
{
    public interface IPoiField
    {
        string ToString();
    }

    public class PoiField : IPoiField
    {
        private readonly GeoCoordinate _geoCoordinate;
        private readonly Color? _fillColor;
        private readonly Color? _textColor;
        private readonly int? _textFontSize;
        private readonly string _customText;

        public PoiField(double lat, double lng, string customText, Color? fillColor,
            Color? textColor, int? textFontSize)
        {
            _geoCoordinate = new GeoCoordinate(lat, lng);
            _fillColor = fillColor;
            _textColor = textColor;
            _textFontSize = textFontSize;
            _customText = customText;
        }

        public PoiField(double lat, double lng, string customText)
        {
            _geoCoordinate = new GeoCoordinate(lat, lng);
            _customText = customText;
        }

        public PoiField(double lat, double lng)
        {
            _geoCoordinate = new GeoCoordinate(lat, lng);
        }

        public override string ToString()
        {
            return
                $"{_geoCoordinate};{_fillColor?.ToAlphaHexString()};{_textColor?.ToAlphaHexString()};{_textFontSize};{_customText}";
        }
    }
}