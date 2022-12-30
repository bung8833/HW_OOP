using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(2022, 12, 25, 09, 00, 00);
            Console.WriteLine(MarketHoursUtility.IsMarketHoursUtility.IsMarketHours(date1));

            Console.ReadKey();
        }
    }
}
