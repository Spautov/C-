using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TaskManager.Converters
{
    public class ProcessToStringConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Process process = (Process)value;
            string strResoult = "";
            if (process != null)
            {
                WorkingSet64ToStringConvertor convert = new WorkingSet64ToStringConvertor();
                strResoult = "Процесс: " + process.ProcessName  + Environment.NewLine;
                strResoult += "Память: " + convert.Convert(process.WorkingSet64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Базовый приоритет: " + process.BasePriority + Environment.NewLine;
                strResoult += "Идентификатор сеанса служб: " + process.SessionId + Environment.NewLine;
                strResoult += "Выгружаемая память: " + convert.Convert(process.PagedMemorySize64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Невыгружаемая память: " + convert.Convert(process.NonpagedSystemMemorySize64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Мах объем памяти в файле подкачки: " + convert.Convert(process.VirtualMemorySize64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Мах объем виртуальной памяти: " + convert.Convert(process.VirtualMemorySize64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Мах объем физической памяти: " + convert.Convert(process.WorkingSet64, strResoult.GetType(), null, null) + Environment.NewLine;
                strResoult += "Закрытая память: " + convert.Convert(process.PrivateMemorySize64, strResoult.GetType(), null, null) + Environment.NewLine;
                try
                {
                    strResoult += "Дата и время запуска: " + process.StartTime.ToString() + Environment.NewLine;
                }
                catch (Exception e)
                {
                    strResoult += "Дата и время запуска: " + e.Message + Environment.NewLine;
                }
                try
                {
                    strResoult += "Полное время процесса: " + process.TotalProcessorTime.ToString(@"hh\:mm\:ss") + Environment.NewLine;
                }
                catch (Exception e)
                {
                    strResoult += "Дата и время запуска: " + e.Message + Environment.NewLine;
                }
                try
                {
                    strResoult += "Пользовательское время процесса: " + process.UserProcessorTime.ToString(@"hh\:mm\:ss") + Environment.NewLine;
                }
                catch (Exception e)
                {
                    strResoult += "Дата и время запуска: " + e.Message + Environment.NewLine;
                }

            }
            return strResoult;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
