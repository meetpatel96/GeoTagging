using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class TempCountry
    {
        public string IsoCode { get; set; }
        public string Iso3 { get; set; }
        public int? IsoNumeric { get; set; }
        public string Fips { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public double? Area { get; set; }
        public int? Population { get; set; }
        public string Continent { get; set; }
        public string Tld { get; set; }
        public string Currencycode { get; set; }
        public string Currencyname { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
        public string Postalcoderegex { get; set; }
        public string Languages { get; set; }
        public int? Geonameid { get; set; }
        public string Neighbours { get; set; }
        public string Equivalentfipscode { get; set; }
    }
}
