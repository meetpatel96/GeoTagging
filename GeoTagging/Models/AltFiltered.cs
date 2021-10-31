using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class AltFiltered
    {
        public int Alternatenameid { get; set; }
        public int? Geonameid { get; set; }
        public string Isolanguage { get; set; }
        public string Alternatename { get; set; }
    }
}
