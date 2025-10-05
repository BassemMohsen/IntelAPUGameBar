using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Tooth
{
    public class CpuBoostModeConverter : IValueConverter
{
    // Convert BoostMode int -> text or brush
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is double mode)
        {
            if (targetType == typeof(string))
            {
                return mode switch
                {
                    0 => "Disabled",
                    1 => "Enabled",
                    2 => "Aggressive",
                    _ => "Unknown"
                };
            }
            else if (targetType == typeof(Brush))
            {
                return mode switch
                {
                    0 => new SolidColorBrush(Colors.Red),
                    1 => new SolidColorBrush(Colors.White),
                    2 => new SolidColorBrush(Colors.Green),
                    _ => new SolidColorBrush(Colors.Red)
                };
            }
        }
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
}