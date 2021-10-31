using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class Capital
    {
        public string State { get; set; }
        public string City { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
