using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Abc.NCrafts.App.Views;

public class AnswerTextToWidthConverter : IValueConverter
{
    public static AnswerTextToWidthConverter Instance { get; } = new();
    
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var stringValue = (string)value;
        return string.IsNullOrEmpty(stringValue) ? new GridLength(0) : new GridLength(1, GridUnitType.Star);

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
