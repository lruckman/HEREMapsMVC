using System.ComponentModel;

namespace HEREMapsMVC.Enums
{
    public enum DistanceUnit
    {
        [Description("d")] Decimeters,
        [Description("h")] Hectometers,
        [Description("k")] Kilometers,
        [Description("m")] MyriadMeters,
        [Description("l")] LakhMeters,
        [Description("mi")] Miles,
        [Description("ft")] Feet
    }
}