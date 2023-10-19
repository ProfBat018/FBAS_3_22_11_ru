using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPages.Services
{
    internal class DateService
    {
        public static DateTime GetDateByUnixSeconds(int seconds, int timezone)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(seconds).AddSeconds(timezone);
            return date;
        }
    }
}
