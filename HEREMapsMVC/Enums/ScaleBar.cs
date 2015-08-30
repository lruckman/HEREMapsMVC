using System.ComponentModel;

namespace HEREMapsMVC.Enums
{
    public enum ScaleBar
    {
        /// <summary>
        ///     Shows scale bar in kilometers/meters.
        /// </summary>
        [Description("k")]
        KilometersAndMeters,

        /// <summary>
        ///     Shows scale bar in miles/feet.
        /// </summary>
        [Description("m")]
        MilesAndFeet,

        /// <summary>
        ///     Shows two scale bars, one in kilometers/meters and one in miles/feet.
        /// </summary>
        [Description("km")]
        KilometersAndMiles
    }
}