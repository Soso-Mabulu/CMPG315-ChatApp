using System;
using System.Globalization;
using System.Windows;

namespace UI.UIPresenter.Converters
{
    public class UsersOnlineToColorConverter : BaseValueConverter<UsersOnlineToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if ((int)value < 0)
                return Application.Current.FindResource("MiddleGrayBgBrush");
            return Application.Current.FindResource("LightBlueBrush"); ;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
