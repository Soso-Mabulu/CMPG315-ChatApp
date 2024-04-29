using CommonLibs.Data;
using System;
using System.Globalization;

namespace UI.UIPresenter.Converters
{
    public class MessageStatusToIconConverter : BaseValueConverter<MessageStatusToIconConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (MessageStatus)value;

            switch (status)
            {
                case MessageStatus.Null:
                    return "";
                case MessageStatus.IsRead:
                    return "";
                case MessageStatus.Sended:
                    return "";
                case MessageStatus.SendingInProgress:
                    return "";
            }

            return "error";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
