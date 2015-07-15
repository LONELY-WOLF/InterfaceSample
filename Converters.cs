using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
namespace InterfaceSample
{
    class BoolToVisibilityConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, System.Type targetType, object parameter, string language)
        {
            if(value is bool?)
            {
                return ((bool?)value == true) ? Visibility.Visible : Visibility.Collapsed;
            }
            if (value is bool)
            {
                return ((bool)value) ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, string language)
        {
            if (value is Visibility)
            {
                if ((Visibility)value == Visibility.Visible)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}