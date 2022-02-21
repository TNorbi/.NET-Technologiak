using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data
{
    public enum MaterialType
    {
        Granules,
        Leaf,
        Liquid,
        Paste,
        Powder,
        Other
    }

    public class DrinkProduct
    {
        public int AnnualSales { get; set; }
        public MaterialType Material { get; set; } = new MaterialType();
        public string PackageType { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
