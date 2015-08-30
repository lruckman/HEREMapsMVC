using System.ComponentModel;

namespace HEREMapsMVC.Enums
{
    public enum MapSchemeType
    {
        /// <summary>
        ///     Normal map view in day light mode.
        /// </summary>
        [Description("normal.day")] NormalDay = 0,

        /// <summary>
        ///     Satellite map view in day light mode.
        /// </summary>
        [Description("satellite.day")] SatelliteDay = 1,

        /// <summary>
        ///     Terrain map view in day light mode.
        /// </summary>
        [Description("terrain.day")] TerrainDay = 2,

        /// <summary>
        ///     Satellite map view with streets in day light mode.
        /// </summary>
        [Description("hybrid.day")] HybridDay = 3,

        /// <summary>
        ///     Normal grey map view with public transit in day light mode.
        /// </summary>
        [Description("normal.day.transit")] NormalDayTransit = 4,

        /// <summary>
        ///     Normal grey map view in day light mode(used for background maps).
        /// </summary>
        [Description("normal.day.grey")] NormalDayGrey = 5,

        /// <summary>
        ///     Normal map view for small screen devices in day light mode.
        /// </summary>
        [Description("normal.day.mobile")] NormalDayMobile = 6,

        /// <summary>
        ///     Normal map view for small screen devices in night mode.
        /// </summary>
        [Description("normal.night.mobile")] NormalNightMobile = 7,

        /// <summary>
        ///     Terrain map view for small screen devices in day light mode.
        /// </summary>
        [Description("terrain.day.mobile")] TerrainDayMobile = 8,

        /// <summary>
        ///     Satellite map view with streets for small screen devices in day light mode.
        /// </summary>
        [Description("hybrid.day.mobile")] HybridDayMobile = 9,

        /// <summary>
        ///     Normal grey map view with public transit for small screen devices in day light mode.
        /// </summary>
        [Description("normal.day.transit.mobile")] NormalDayTransitMobile = 10,
        [Description("normal.day.grey.mobile")] NormalDayGreyMobile = 11,

        /// <summary>
        ///     Map view designed for navigation devices.
        /// </summary>
        [Description("carnav.day.grey")] CarnavDayGrey = 12,

        /// <summary>
        ///     Map view designed for pedestrians walking by day.
        /// </summary>
        [Description("pedestrian.day")] PedestrianDay = 13,

        /// <summary>
        ///     Map view designed for pedestrians walking by night.
        /// </summary>
        [Description("pedestrian.night")] PedestrianNight = 14
    }
}