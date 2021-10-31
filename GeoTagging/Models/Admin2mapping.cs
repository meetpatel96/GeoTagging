using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class Admin2mapping
    {
        public string Country { get; set; }
        public string Admin1 { get; set; }
        public string Admin2 { get; set; }
        public string Admin2name { get; set; }
        public int? Geonameid { get; set; }
    }
}
