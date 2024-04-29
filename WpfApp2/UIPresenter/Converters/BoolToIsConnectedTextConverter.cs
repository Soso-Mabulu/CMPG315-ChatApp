using System;
using System.Globalization;

namespace UI.UIPresenter.Converters
{
    public class BoolToIsConnectedTextConverter : BaseValueConverter<BoolToIsConnectedTextConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "Connected";
            return "Disconnected";

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
