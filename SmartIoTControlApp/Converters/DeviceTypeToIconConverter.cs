using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace SmartIoTControlApp.Converters
{
    public class DeviceTypeToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value?.ToString()?.ToLower();

            return type switch
            {
                "bombillo" => "💡",
                "ventilador" => "🌀",
                "sensor" => "🌡️",
                _ => "🔧"
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
