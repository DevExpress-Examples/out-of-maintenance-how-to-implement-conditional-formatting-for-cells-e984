using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace ConditionalCellFormatting {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public class SimpleData {
        public string Column1 { get; set; }
        public int Column2 { get; set; }

        public SimpleData() { }

        public SimpleData(string str1, int int2) {
            Column1 = str1;
            Column2 = int2;
        }
    }

    public class ColorValueConverter : MarkupExtension, IValueConverter {
        public int MaxValue { get; set; }

        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, 
        CultureInfo culture) {
            int count = MaxValue - (int)value;
            Color color = Color.FromRgb(0xff, 0xad, 0x5d);

            double r = color.R + (0xff - color.R) * count / MaxValue;
            double g = color.G + (0xff - color.G) * count / MaxValue;
            double b = color.B + (0xff - color.B) * count / MaxValue;

            return new SolidColorBrush(Color.FromArgb(255, (byte)r, (byte)g, (byte)b));
        }

        public object ConvertBack(object value, Type targetType, object parameter, 
        CultureInfo culture) {
            return null;
        }
        #endregion

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
