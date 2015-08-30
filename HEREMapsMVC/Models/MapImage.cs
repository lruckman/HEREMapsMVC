 // ReSharper disable InconsistentNaming

namespace HEREMapsMVC.Models
{
    public interface IMapImage
    {
        string c { get; set; }
        string ci { get; set; }
        string co { get; set; }
        int? f { get; set; }
        int? h { get; set; }
        bool i { get; set; }
        int? maxhits { get; set; }
        string ml { get; set; }
        string ml2 { get; set; }
        string n { get; set; }
        bool nocmp { get; set; }
        bool nocp { get; set; }
        bool nocrop { get; set; }
        bool nodot { get; set; }
        int? pip { get; set; }
        string poifc { get; set; }
        int? poilbl { get; set; }
        int? poithm { get; set; }
        string poitxc { get; set; }
        int? poitxs { get; set; }
        int? ppi { get; set; }
        int? q { get; set; }
        int? ra { get; set; }
        string rad { get; set; }
        string s { get; set; }
        string sb { get; set; }
        string scp { get; set; }
        string style { get; set; }
        string t { get; set; }
        string u { get; set; }
        int? w { get; set; }
        int? z { get; set; }
        ParameterCollection poix { get; }
        ParameterCollection tx { get; }
        ParameterCollection txxy { get; }
        string zi { get; set; }
    }

    public class MapImage : IMapImage
    {
        public string c { get; set; }
        public string ci { get; set; }
        public string co { get; set; }
        public int? f { get; set; }
        public int? h { get; set; }
        public bool i { get; set; }
        public int? maxhits { get; set; }
        public string ml { get; set; }
        public string ml2 { get; set; }
        public string n { get; set; }
        public bool nocmp { get; set; }
        public bool nocp { get; set; }
        public bool nocrop { get; set; }
        public bool nodot { get; set; }
        public int? pip { get; set; }
        public string poifc { get; set; }
        public int? poilbl { get; set; }
        public int? poithm { get; set; }
        public string poitxc { get; set; }
        public int? poitxs { get; set; }
        public int? ppi { get; set; }
        public int? q { get; set; }
        public int? ra { get; set; }
        public string rad { get; set; }
        public string s { get; set; }
        public string sb { get; set; }
        public string scp { get; set; }
        public string style { get; set; }
        public string t { get; set; }
        public string u { get; set; }
        public int? w { get; set; }
        public int? z { get; set; }

        public ParameterCollection poix { get; } = new ParameterCollection("poix");
        public ParameterCollection tx { get; } = new ParameterCollection("tx");
        public ParameterCollection txxy { get; } = new ParameterCollection("tx.xy");

        public string zi { get; set; }
    }
}