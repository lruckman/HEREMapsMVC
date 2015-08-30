namespace HEREMapsMVC.Models
{
    public interface IGeoCoordinate : IEncodeable
    {
        string ToString();
    }

    public class GeoCoordinate : IGeoCoordinate
    {
        private readonly double _latitude;
        private readonly double _longitude;

        public GeoCoordinate(double lat, double lng)
        {
            _latitude = lat;
            _longitude = lng;
        }

        public override string ToString()
        {
            return $"{_latitude},{_longitude}";
        }
    }
}