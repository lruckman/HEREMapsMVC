using System.ComponentModel;
using System.Drawing;
using HEREMapsMVC.Enums;
using HEREMapsMVC.Extensions;
using HEREMapsMVC.Models;

namespace HEREMapsMVC.Api.Rest
{
    public interface IMapImageBuilder: IBuilder
    {
        /// <summary>
        /// </summary>
        /// <param name="houseNumber">House number on the street for address based search.</param>
        /// <param name="streetName">Street name for address based search.</param>
        /// <param name="cityName">City name for address based search.</param>
        /// <param name="postalCode">Zip/postal code for address based search.</param>
        /// <param name="countryName">Country name for address based search.</param>
        /// <returns></returns>
        IMapImageBuilder Search(string houseNumber, string streetName, string cityName, string postalCode,
            string countryName);

        /// <summary>
        ///     Map center point.
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        IMapImageBuilder Center(double lat, double lng);

        /// <summary>
        ///     Specifies wether parameters should be encoded to base64
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        //IMapImageBuilder Encode(bool flag);

        /// <summary>
        ///     Image format.
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        IMapImageBuilder ImageFormat(ImageFormat imageFormat);

        /// <summary>
        ///     Result image height in pixels, maximum 2048.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        IMapImageBuilder Height(int height);

        /// <summary>
        ///     Flag for showing address or position information box inside the map image (if address is available or position is
        ///     allowed to be shown).
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IMapImageBuilder ShowInformationBox(bool flag);

        /// <summary>
        ///     Maximum number of search results to return. Applies only when some kind of search is performed which can return
        ///     multiple results. Set to 1 to show directly the first matching result without any results listing.
        /// </summary>
        /// <param name="numberOfSearchResults"></param>
        /// <returns></returns>
        IMapImageBuilder MaxHits(int numberOfSearchResults);

        /// <summary>
        ///     Specifies the language to be used to display descriptions of details inside the map image. If the parameter is not
        ///     provided, the default language depends on the highest prioritized locale of the client's Accept-Language HTTP
        ///     header which is currently supported. If no map language based on HTTP header can be determined, the server
        ///     configured default is used.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        IMapImageBuilder MapLabelLanguage(MapLabelLanguage language);

        /// <summary>
        ///     Specifies the language to be used to display descriptions of details inside the map image. If the parameter is not
        ///     provided, the default language depends on the highest prioritized locale of the client's Accept-Language HTTP
        ///     header which is currently supported. If no map language based on HTTP header can be determined, the server
        ///     configured default is used.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        IMapImageBuilder SecondaryMapLabelLanguage(MapLabelLanguage language);

        /// <summary>
        ///     Flag for hiding the compass on the map.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IMapImageBuilder HideCompass(bool flag);

        /// <summary>
        ///     Flag to avoid having cropped labels on the map. If the parameter is present in the request, the labels that do not
        ///     fit completely on the image requested will not be on the map, if the parameter is not present, the default behavior
        ///     will apply, that is, showing the labels even if they are cropped.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IMapImageBuilder NoCrop(bool flag);

        /// <summary>
        ///     Flag for hiding copyright information on the map
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IMapImageBuilder HideCopyright(bool flag);

        /// <summary>
        ///     Flag for hiding position marker dot on the map. This has an effect only if position is requested.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IMapImageBuilder NoDot(bool flag);

        /// <summary>
        ///     Shows small Picture-in-Picture map from the same location as the actual requested map on bottom right corner of the
        ///     map image, using the given value as zoom level for the PiP-map.
        /// </summary>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        IMapImageBuilder Pip(int zoomLevel);

        /// <summary>
        ///     Resolution to be used.
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        IMapImageBuilder MapResolution(MapResolution resolution);

        /// <summary>
        ///     Image compression quality in percentage between 1-100, default is 85 if not specified. The parameter takes effect
        ///     only if JPEG image format is used.
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        IMapImageBuilder ImageCompressionQuality(int quality);

        /// <summary>
        ///     The rotation angle of the map in degrees between 0-360. If given angle is 0, the image is not rotated at all and
        ///     the compass is not displayed. If angle is greater than 360 or less than 0, the value is normalized (e.g. 380 to 20,
        ///     -10 to 350).
        /// </summary>
        /// <param name="rotationAngle"></param>
        /// <returns></returns>
        IMapImageBuilder Rotation(int rotationAngle);

        /// <summary>
        ///     Radius of an area.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        IMapImageBuilder Radius(int distance, DistanceUnit unit);

        /// <summary>
        ///     Scale bars to show at bottom right corner of the map. The scale bar won't be drawn if it does not properly fit in
        ///     the image.
        /// </summary>
        /// <param name="scaleBarType">Value defines whether to show scale bar in kilometers/meters and/or in miles/feet.</param>
        /// <returns></returns>
        IMapImageBuilder ScaleBarType(ScaleBar scaleBarType);

        /// <summary>
        ///     Shows service specific additional copyright information together with map
        ///     data copyright. The value must be a valid ID/key of a pre-configured service specific copyright i.e. the parameter
        ///     value itself is not shown on map.
        /// </summary>
        /// <param name="id">ID of service owner specific copyright.</param>
        /// <returns></returns>
        IMapImageBuilder SpecificCopyright(string id);

        /// <summary>
        ///     Map style type. All available styles are defined by Map view server of the Map Image API.
        /// </summary>
        /// <param name="mapStyle"></param>
        /// <returns></returns>
        IMapImageBuilder Style(MapStyle mapStyle);

        /// <summary>
        ///     Map scheme type.
        /// </summary>
        /// <param name="mapSchemeType"></param>
        /// <returns></returns>
        IMapImageBuilder MapSchemeType(MapSchemeType mapSchemeType);

        /// <summary>
        ///     Default fill color for POI markers. This can used to define common default fill color for all POI markers. If no
        ///     default fill color is available, system default fill color will be used.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        IMapImageBuilder DefaultMarkerFillColor(Color color);

        /// <summary>
        ///     POI marker labeling type.
        /// </summary>
        /// <param name="labeling"></param>
        /// <returns></returns>
        IMapImageBuilder MakerLabelingType(PoiLabeling labeling);

        /// <summary>
        ///     POI marker theme.
        /// </summary>
        /// <param name="theme"></param>
        /// <returns></returns>
        IMapImageBuilder MarkerTheme(PoiTheme theme);

        /// <summary>
        ///     Default text color for POI markers. This can used to define common default text color for all POI markers. If no
        ///     default text color is available, system default text color will be used.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        IMapImageBuilder DefaultMarkerTextColor(Color color);

        /// <summary>
        ///     Default text font size for POI markers, valid range is between 8-30. This can used to define common default text
        ///     font size for all POI markers. If no default text font size is available, system default text font size will be
        ///     used.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        IMapImageBuilder DefaultMarkerTextFontSize(int size);

        /// <summary>
        ///     Radius of uncertain area around the requested position. Draws color filled circle having given value as radius
        ///     around the position marker dot.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        IMapImageBuilder Uncertainty(int distance, DistanceUnit unit);

        /// <summary>
        ///     Zoom level for the map. Available levels are defined by Map View server of the Map Image API API, value between
        ///     0-20.
        /// </summary>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        IMapImageBuilder Zoom(int zoomLevel);

        /// <summary>
        ///     Result image width in pixels, maximum 2048.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        IMapImageBuilder Width(int width);

        /// <summary>
        ///     Adds a single extended POI marker characteristics as fields.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        IMapImageBuilder AddMarker(PoiField field);

        /// <summary>
        ///     Custom text (to be shown on top of map) and its characteristics as fields. Texts must have geo location based
        ///     positioning. When using geo location, it may affect the map zoom level if other geo coordinate based information is
        ///     shown at the same time.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        IMapImageBuilder AddMarker(GeoTextField field);

        /// <summary>
        ///     Custom text (to be shown on top of map) and its characteristics as fields. Texts must have geo location based
        ///     positioning. When using geo location, it may affect the map zoom level if other geo coordinate based information is
        ///     shown at the same time.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        IMapImageBuilder AddMarker(PixelTextField field);
    }

    public class MapImageBuilder : IMapImageBuilder
    {
        private readonly MapImage _mapImage;
        //private bool _encode;

        public MapImageBuilder()
        {
            _mapImage = new MapImage();
        }

        /// <summary>
        /// </summary>
        /// <param name="houseNumber">House number on the street for address based search.</param>
        /// <param name="streetName">Street name for address based search.</param>
        /// <param name="cityName">City name for address based search.</param>
        /// <param name="postalCode">Zip/postal code for address based search.</param>
        /// <param name="countryName">Country name for address based search.</param>
        /// <returns></returns>
        public IMapImageBuilder Search(string houseNumber, string streetName, string cityName, string postalCode,
            string countryName)
        {
            _mapImage.n = houseNumber;
            _mapImage.s = streetName;
            _mapImage.ci = cityName;
            _mapImage.zi = postalCode;
            _mapImage.co = countryName;

            return this;
        }

        /// <summary>
        ///     Map center point.
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        public IMapImageBuilder Center(double lat, double lng)
        {
            _mapImage.c = new GeoCoordinate(lat, lng).ToString();
            // ctr ignored
            return this;
        }

        /// <summary>
        ///     Specifies wether parameters should be encoded to base64
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        //public IMapImageBuilder Encode(bool flag)
        //{
        //    _encode = flag;
        //    return this;
        //}

        /// <summary>
        ///     Image format.
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        public IMapImageBuilder ImageFormat(ImageFormat imageFormat)
        {
            _mapImage.f = (int) imageFormat;
            return this;
        }

        /// <summary>
        ///     Result image height in pixels, maximum 2048.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public IMapImageBuilder Height(int height)
        {
            _mapImage.h = height > 2048 ? 2048 : height;
            return this;
        }

        /// <summary>
        ///     Flag for showing address or position information box inside the map image (if address is available or position is
        ///     allowed to be shown).
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public IMapImageBuilder ShowInformationBox(bool flag)
        {
            _mapImage.i = flag;
            return this;
        }

        // lat
        // lon

        /// <summary>
        ///     Maximum number of search results to return. Applies only when some kind of search is performed which can return
        ///     multiple results. Set to 1 to show directly the first matching result without any results listing.
        /// </summary>
        /// <param name="numberOfSearchResults"></param>
        /// <returns></returns>
        public IMapImageBuilder MaxHits(int numberOfSearchResults)
        {
            _mapImage.maxhits = numberOfSearchResults;
            return this;
        }

        /// <summary>
        ///     Specifies the language to be used to display descriptions of details inside the map image. If the parameter is not
        ///     provided, the default language depends on the highest prioritized locale of the client's Accept-Language HTTP
        ///     header which is currently supported. If no map language based on HTTP header can be determined, the server
        ///     configured default is used.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public IMapImageBuilder MapLabelLanguage(MapLabelLanguage language)
        {
            _mapImage.ml = language.GetDescription();
            return this;
        }

        /// <summary>
        ///     Specifies the language to be used to display descriptions of details inside the map image. If the parameter is not
        ///     provided, the default language depends on the highest prioritized locale of the client's Accept-Language HTTP
        ///     header which is currently supported. If no map language based on HTTP header can be determined, the server
        ///     configured default is used.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public IMapImageBuilder SecondaryMapLabelLanguage(MapLabelLanguage language)
        {
            _mapImage.ml2 = language.GetDescription();
            return this;
        }

        /// <summary>
        ///     Flag for hiding the compass on the map.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public IMapImageBuilder HideCompass(bool flag)
        {
            _mapImage.nocmp = flag;
            return this;
        }

        /// <summary>
        ///     Flag to avoid having cropped labels on the map. If the parameter is present in the request, the labels that do not
        ///     fit completely on the image requested will not be on the map, if the parameter is not present, the default behavior
        ///     will apply, that is, showing the labels even if they are cropped.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public IMapImageBuilder NoCrop(bool flag)
        {
            _mapImage.nocrop = flag;
            return this;
        }

        /// <summary>
        ///     Flag for hiding copyright information on the map
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public IMapImageBuilder HideCopyright(bool flag)
        {
            _mapImage.nocp = flag;
            return this;
        }

        /// <summary>
        ///     Flag for hiding position marker dot on the map. This has an effect only if position is requested.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public IMapImageBuilder NoDot(bool flag)
        {
            _mapImage.nodot = flag;
            return this;
        }

        //nomrk

        /// <summary>
        ///     Shows small Picture-in-Picture map from the same location as the actual requested map on bottom right corner of the
        ///     map image, using the given value as zoom level for the PiP-map.
        /// </summary>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public IMapImageBuilder Pip(int zoomLevel)
        {
            _mapImage.pip = zoomLevel;
            return this;
        }

        /// <summary>
        ///     Resolution to be used.
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        public IMapImageBuilder MapResolution(MapResolution resolution)
        {
            _mapImage.ppi = (int) resolution;
            return this;
        }

        /// <summary>
        ///     Image compression quality in percentage between 1-100, default is 85 if not specified. The parameter takes effect
        ///     only if JPEG image format is used.
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public IMapImageBuilder ImageCompressionQuality(int quality)
        {
            if (quality < 1 || quality > 100)
            {
                quality = 85;
            }

            _mapImage.q = quality;
            return this;
        }

        /// <summary>
        ///     The rotation angle of the map in degrees between 0-360. If given angle is 0, the image is not rotated at all and
        ///     the compass is not displayed. If angle is greater than 360 or less than 0, the value is normalized (e.g. 380 to 20,
        ///     -10 to 350).
        /// </summary>
        /// <param name="rotationAngle"></param>
        /// <returns></returns>
        public IMapImageBuilder Rotation(int rotationAngle)
        {
            _mapImage.ra = rotationAngle;
            return this;
        }

        /// <summary>
        ///     Radius of an area.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public IMapImageBuilder Radius(int distance, DistanceUnit unit)
        {
            _mapImage.rad = distance + unit.GetDescription();
            return this;
        }

        /// <summary>
        ///     Scale bars to show at bottom right corner of the map. The scale bar won't be drawn if it does not properly fit in
        ///     the image.
        /// </summary>
        /// <param name="scaleBarType">Value defines whether to show scale bar in kilometers/meters and/or in miles/feet.</param>
        /// <returns></returns>
        public IMapImageBuilder ScaleBarType(ScaleBar scaleBarType)
        {
            _mapImage.sb = scaleBarType.GetDescription();
            return this;
        }

        /// <summary>
        ///     Shows service specific additional copyright information together with map
        ///     data copyright. The value must be a valid ID/key of a pre-configured service specific copyright i.e. the parameter
        ///     value itself is not shown on map.
        /// </summary>
        /// <param name="id">ID of service owner specific copyright.</param>
        /// <returns></returns>
        public IMapImageBuilder SpecificCopyright(string id)
        {
            _mapImage.scp = id;
            return this;
        }

        /// <summary>
        ///     Map style type. All available styles are defined by Map view server of the Map Image API.
        /// </summary>
        /// <param name="mapStyle"></param>
        /// <returns></returns>
        public IMapImageBuilder Style(MapStyle mapStyle)
        {
            _mapImage.style = mapStyle.GetDescription();
            return this;
        }

        /// <summary>
        ///     Map scheme type.
        /// </summary>
        /// <param name="mapSchemeType"></param>
        /// <returns></returns>
        public IMapImageBuilder MapSchemeType(MapSchemeType mapSchemeType)
        {
            _mapImage.t = mapSchemeType.GetDescription();
            return this;
        }

        // txc
        // txs
        // txsc

        /// <summary>
        ///     Default fill color for POI markers. This can used to define common default fill color for all POI markers. If no
        ///     default fill color is available, system default fill color will be used.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public IMapImageBuilder DefaultMarkerFillColor(Color color)
        {
            _mapImage.poifc = color.ToAlphaHexString();
            return this;
        }

        /// <summary>
        ///     POI marker labeling type.
        /// </summary>
        /// <param name="labeling"></param>
        /// <returns></returns>
        public IMapImageBuilder MakerLabelingType(PoiLabeling labeling)
        {
            _mapImage.poilbl = (int) labeling;
            return this;
        }

        /// <summary>
        ///     POI marker theme.
        /// </summary>
        /// <param name="theme"></param>
        /// <returns></returns>
        public IMapImageBuilder MarkerTheme(PoiTheme theme)
        {
            _mapImage.poithm = (int) theme;
            return this;
        }

        /// <summary>
        ///     Default text color for POI markers. This can used to define common default text color for all POI markers. If no
        ///     default text color is available, system default text color will be used.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public IMapImageBuilder DefaultMarkerTextColor(Color color)
        {
            _mapImage.poitxc = color.ToAlphaHexString();
            return this;
        }

        /// <summary>
        ///     Default text font size for POI markers, valid range is between 8-30. This can used to define common default text
        ///     font size for all POI markers. If no default text font size is available, system default text font size will be
        ///     used.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IMapImageBuilder DefaultMarkerTextFontSize(int size)
        {
            _mapImage.poitxs = size;
            return this;
        }

        /// <summary>
        ///     Radius of uncertain area around the requested position. Draws color filled circle having given value as radius
        ///     around the position marker dot.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public IMapImageBuilder Uncertainty(int distance, DistanceUnit unit)
        {
            _mapImage.u = distance + unit.GetDescription();
            return this;
        }

        /// <summary>
        ///     Zoom level for the map. Available levels are defined by Map View server of the Map Image API API, value between
        ///     0-20.
        /// </summary>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public IMapImageBuilder Zoom(int zoomLevel)
        {
            _mapImage.z = zoomLevel > 20
                ? 20
                : zoomLevel < 0
                    ? 0
                    : zoomLevel;
            return this;
        }

        /// <summary>
        ///     Result image width in pixels, maximum 2048.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public IMapImageBuilder Width(int width)
        {
            _mapImage.w = width > 2048
                ? 2048
                : width < 0
                    ? 0
                    : width;
            return this;
        }

        #region Marker helpers

        /// <summary>
        ///     Adds a single extended POI marker characteristics as fields.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public IMapImageBuilder AddMarker(PoiField field)
        {
            _mapImage.poix.Add(field.ToString());
            return this;
        }

        /// <summary>
        ///     Custom text (to be shown on top of map) and its characteristics as fields. Texts must have geo location based
        ///     positioning. When using geo location, it may affect the map zoom level if other geo coordinate based information is
        ///     shown at the same time.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public IMapImageBuilder AddMarker(GeoTextField field)
        {
            _mapImage.tx.Add(field.ToString());
            return this;
        }

        /// <summary>
        ///     Custom text (to be shown on top of map) and its characteristics as fields. Texts must have geo location based
        ///     positioning. When using geo location, it may affect the map zoom level if other geo coordinate based information is
        ///     shown at the same time.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public IMapImageBuilder AddMarker(PixelTextField field)
        {
            _mapImage.txxy.Add(field.ToString());
            return this;
        }

        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual string ToHtmlString()
        {
            return ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            // TODO: do something if we can encode...
            return $"{Config.GetEndpoint(Resource.mapview)}&{_mapImage.ToQueryString()}";
        }
    }
}