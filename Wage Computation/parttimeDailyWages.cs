using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Computation
{
    internal class parttimeDailyWages
    {
        static void Main(string[] args)
        {
            decimal wagePerHour = 20m;
            int fullDayHour = 8;
            int partTimeHour = 8;
            decimal fullTimeWage = wagePerHour * fullDayHour;
            decimal partTimeWage = wagePerHour * partTimeHour;

            Console.WriteLine($"Full-Time Daily Wage: ${fullTimeWage}");
            Console.WriteLine($"Part-Time Daily Wage: ${partTimeWage}");
        }
    }
}
