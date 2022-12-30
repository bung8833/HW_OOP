using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MarketHoursUtility
{
    public class IsMarketHoursUtility
    {
        public static bool IsMarketHours(DateTime dt)
        {
            if (dt.DayOfWeek >= DayOfWeek.Monday
             && dt.DayOfWeek <= DayOfWeek.Friday)
            {
                if (dt.TimeOfDay >= new TimeSpan( 9,  0, 0)
                 && dt.TimeOfDay <= new TimeSpan(13, 30, 0)) // 包含13:30:00整
                {
                    return true;
                }
            }

            return false;


            //TimeSpan morningSpan = new TimeSpan(9, 0, 0);
            //TimeSpan noonSpan = new TimeSpan(13, 30, 0);

            //if (dt.TimeOfDay >= morningSpan
            // && dt.TimeOfDay <  noonSpan)
            //{
            //    return true;
            //}
        }
    }
}
