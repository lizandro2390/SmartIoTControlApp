using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace SmartIoTControlApp.Converters
{
    public class OnlineColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool isOnline ? (isOnline ? Colors.Green : Colors.Red) : Colors.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
