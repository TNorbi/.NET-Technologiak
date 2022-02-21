using ProductApp.Data;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProductApp.Helper
{
    //itt megmondjuk, hogy egy Int erteket egy Brushes ertekke alakitsa(hogy tudjam kiszinezni a szamokat)
    [ValueConversion(typeof(int),typeof(Brushes))]
    class IntegerToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
     
            int Quantity = (int)value;

            if(Quantity < 10000)
            {
                //itt ki kell szinezzem a Quantity int erteket pirosra
                return Brushes.Red;
            }

            return Brushes.Blue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
