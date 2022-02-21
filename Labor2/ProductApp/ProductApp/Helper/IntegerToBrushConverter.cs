using ProductApp.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            DrinkProduct product = (DrinkProduct)value;

            if(product.Quantity < 10000)
            {
                //itt ki kell szinezzem a Quantity int erteket pirosra
                return new SolidBrush(Color.Red);
            }

            return new SolidBrush(Color.Blue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
