using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class Geoname
    {
        public int Geonameid { get; set; }
        public string Name { get; set; }
        public string Asciiname { get; set; }
        public string Alternatenames { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public char? Fclass { get; set; }
        public string Fcode { get; set; }
        public string Country { get; set; }
        public string Admin1 { get; set; }
        public string Admin2 { get; set; }
        public string Admin3 { get; set; }
        public string Admin4 { get; set; }
        public long? Population { get; set; }
        public int? Admin1Geonameid { get; set; }
        public int? Admin2Geonameid { get; set; }
        public int? CountryGeonameid { get; set; }
    }
}
