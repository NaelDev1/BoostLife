using System.Globalization;
using System.Windows.Data;

namespace BoostLife.Converters;

internal class DateTimeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value != null && value is DateTime date)
        {
            return date.ToUniversalTime();
        }
        return value ?? DateTime.MinValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value is DateTime date && value != null)
        {
            return date.ToUniversalTime();
        }
        return value ?? DateTime.MinValue;
    }
}
