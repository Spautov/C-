using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TaskManager.Converters
{
    public class WorkingSet64ToStringConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            string strResoult = "";
            if (value != null)
            {
                Int64 val = (Int64)value;
                val = (Int64)Math.Round((Double)val / 1024);
                strResoult = val + " Кб";
            }
            return strResoult;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
