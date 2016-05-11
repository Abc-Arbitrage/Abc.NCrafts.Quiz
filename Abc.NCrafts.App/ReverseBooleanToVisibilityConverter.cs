using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Abc.NCrafts.App
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public sealed class ReverseBooleanToVisibilityConverter : IValueConverter
    {
        public static ReverseBooleanToVisibilityConverter Instance { get; } = new ReverseBooleanToVisibilityConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return null;
            return (bool)value ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return null;
            return Convert(!(bool)value, targetType, parameter, culture);
        }
    }
}