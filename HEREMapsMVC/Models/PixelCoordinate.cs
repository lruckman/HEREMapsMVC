namespace HEREMapsMVC.Models
{
    public interface IPixelCoordinate : IEncodeable
    {
        string ToString();
    }

    public class PixelCoordinate : IPixelCoordinate
    {
        private readonly double _x;
        private readonly double _y;

        public PixelCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"{_x},{_y}";
        }
    }
}