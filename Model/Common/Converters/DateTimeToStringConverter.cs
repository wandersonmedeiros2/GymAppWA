using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Common.Converters
{
    public class DateTimeToStringConverter : IConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(value is DateTime date)
            {
                return date.ToString("dd/MM/yyyy");
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
