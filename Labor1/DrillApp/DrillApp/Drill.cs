using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillApp
{
    public enum Speed 
    { 
        Slow = 500,
        Medium = 1350,
        Fast = 1850
    }

    public enum Material
    {
        Metal,Plastic,Titanium
    }

    public class Drill
    {
        public List<string> IncludeComponents { get; set; }
        public string InstallationMethod { get; set; }
        public string ItemWeigth { get; set; }
        public string Manufacturer { get; set; }
        public Material Material { get; }
        public IList<Material> Materials { get; set; }
        public string Note { get; set; }
        public string PackageDimensions { get; set; }
        public string PartNumber { get; set; }
        public string PowerSource { get; set; }
        public string Size { get; set; }
        public Speed Speed { get;}
        public IList<Speed> Speeds { get; set; }
        public string Torque { get; set; }
        public Usage Usage { get;}
    }
}
