using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class Country
    {
        public int? Geonameid { get; set; }
        public string IsoCode { get; set; }
        public string Name { get; set; }
    }
}
