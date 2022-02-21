using ProductApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<DrinkProduct> stockCheck = new List<DrinkProduct>();
        public MainWindow()
        {
            InitializeComponent();
            loadDummyDrinks();
        }

        public void loadDummyDrinks()
        {
            stockCheck.Add(new DrinkProduct { ProductID = "CFk1kg", ProductName = "Cofee Powder", PackageType = "1 kg", Quantity = 15684 ,Material=MaterialType.Liquid,AnnualSales=1234564});
            stockCheck.Add(new DrinkProduct { ProductID = "CFB500", ProductName = "Ground Cofee", PackageType = "500 g", Quantity = 22785,Material=MaterialType.Liquid ,AnnualSales=123458754 });
            stockCheck.Add(new DrinkProduct { ProductID = "CFG500", ProductName = "Cofee Granules", PackageType = "500 g", Quantity = 19233,Material=MaterialType.Liquid ,AnnualSales=2469785});
            stockCheck.Add(new DrinkProduct { ProductID = "Te500", ProductName = "Tea", PackageType = "500 g", Quantity = 8544, Material=MaterialType.Liquid,AnnualSales=231456 });
            stockCheck.Add(new DrinkProduct { ProductID = "TeInst500", ProductName = "Instant Tea", PackageType = "500 g", Quantity = 1009,Material=MaterialType.Powder,AnnualSales=1364565 });
            stockCheck.Add(new DrinkProduct { ProductID = "SMlk1lt", ProductName = "Skimmed Milk", PackageType = "1 litre", Quantity = 28012 ,Material=MaterialType.Leaf,AnnualSales=12459});
            stockCheck.Add(new DrinkProduct { ProductID = "HiJ300", ProductName = "HiJiuce Drink Mix", PackageType = "300 g", Quantity = 17523,Material=MaterialType.Granules,AnnualSales=1234897 });
            stockCheck.Add(new DrinkProduct { ProductID = "Sm400", ProductName = "Smoothie", PackageType = "400 ml", Quantity = 9346 ,Material=MaterialType.Other,AnnualSales=12457784});
            stockCheck.Add(new DrinkProduct { ProductID = "Beef300", ProductName = "Beef Drink", PackageType = "300 g", Quantity = 8316 ,Material=MaterialType.Paste,AnnualSales=123457});
            stockCheck.Add(new DrinkProduct { ProductID = "Beef750", ProductName = "Beef Drink", PackageType = "750 g", Quantity = 7612 ,Material=MaterialType.Other,AnnualSales=1254877});
            ProductListView.DataContext = stockCheck;
        }
    }
}
