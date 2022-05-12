using Model.Common.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace GymAppWA.UI.Common.ConverterAdapters
{
    public class DateTimeToStringConverterAdapter : IValueConverter
    {
        private IConverter dateTimeToStringConverter = new DateTimeToStringConverter();
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return dateTimeToStringConverter.Convert(value, targetType, parameter, language);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return dateTimeToStringConverter.ConvertBack(value, targetType, parameter, language);
        }
    }
}
