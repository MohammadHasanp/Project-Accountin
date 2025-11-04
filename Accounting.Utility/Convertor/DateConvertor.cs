using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
  public static class DateConvertor
    {
        public static string ToShamsi(this DateTime vaLue)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(vaLue) + "/" + pc.GetMonth(vaLue).ToString("00") + "/" + pc.GetDayOfMonth(vaLue).ToString("00");
        }
        public static DateTime ToMiladi(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new PersianCalendar());
        }
    }
}
