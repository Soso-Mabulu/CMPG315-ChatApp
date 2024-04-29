using System;
using System.Globalization;

namespace UI.UIPresenter.Converters
{
    public class IntToUsersOnlineConverter : BaseValueConverter<IntToUsersOnlineConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value < 0)
                return "No one Online";
            return $"{((int)value).ToString()} Online";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
