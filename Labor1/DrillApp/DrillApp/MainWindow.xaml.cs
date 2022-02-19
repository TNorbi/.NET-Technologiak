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

namespace DrillApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Drill kimo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            kimo = new Drill
            {
                Manufacturer = "KIMO.",
                PackageDimensions = "13.7 x 10.6 x 3 inches",
                ItemWeigth = "2.84 pounds",
                PartNumber = "K13811",
                Size = "Medium",
                PowerSource = "Battery Powered",
                Torque = "350 Inch Pounds",
                InstallationMethod = "Screw-In",
                Note = "Average Battery Life 1000 Hours"
            };

            kimo.Usage.Concrete = true;
            kimo.Usage.Wood = true;
            kimo.Usage.Metal = true;
            kimo.Usage.HardBrick = true;
            kimo.Usage.HardMaterial = false;
            kimo.Usage.Screwdriver = true;
            kimo.IncludeComponents.Add("1xKIMO Cordless K13811 Drill Driver");
            kimo.IncludeComponents.Add("1x2.0Ah 20V Lithium-Ion Battery");
            kimo.IncludeComponents.Add("1xFast Charger");
            kimo.loadMaterials();
            kimo.loadSpeeds();

            //kod szinten igy nezne ki(ennek alternativaja az XAML-ben a <Window.DataContext-nel> van,ahol megadtam egy instancet/hivatkozast a Drill osztalynak)
            this.DataContext = kimo;
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            kimo.Manufacturer = "";
            kimo.PackageDimensions = "";
            kimo.ItemWeigth = "";
            kimo.PartNumber = "";
            kimo.Size = "";
            kimo.PowerSource = "";
            kimo.Torque = "";
            kimo.InstallationMethod = "";
            kimo.Note = "";
            kimo.Usage.Concrete = false;
            kimo.Usage.Wood = false;
            kimo.Usage.Metal = false;
            kimo.Usage.HardBrick = false;
            kimo.Usage.HardMaterial = false;
            kimo.Usage.Screwdriver = false;
            kimo.IncludeComponents.Clear();
            kimo.Materials.Clear();
            kimo.Speeds.Clear();

            if(DataContext != null)
            {
                DataContext = null;
            }

            DataContext = kimo;
        }
    }
}
