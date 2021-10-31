using System;
using System.Collections.Generic;

namespace GeoTagging.Models
{
    public partial class MyCounty
    {
        public int Gid { get; set; }
        public string Statefp { get; set; }
        public string Countyfp { get; set; }
        public string Countyns { get; set; }
        public string Affgeoid { get; set; }
        public string Geoid { get; set; }
        public string Name { get; set; }
        public string Lsad { get; set; }
        public double? Aland { get; set; }
        public double? Awater { get; set; }
    }
}
