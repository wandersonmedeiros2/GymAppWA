using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Common.Converters
{
    public interface IConverter
    {
        object Convert(object value, Type targetType, object parameter, string language);
        object ConvertBack(object value, Type targetType, object parameter, string language);
    }
}
