using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class Alternatename
    {
        public int? Alternatenameid { get; set; }
        public int? Geonameid { get; set; }
        public string Isolanguage { get; set; }
        public string Alternatename1 { get; set; }
        public bool? Ispreferredname { get; set; }
        public bool? Isshortname { get; set; }
        public bool? Iscolloquial { get; set; }
        public bool? Ishistoric { get; set; }
        public string TheFrom { get; set; }
        public string TheTo { get; set; }
    }
}
