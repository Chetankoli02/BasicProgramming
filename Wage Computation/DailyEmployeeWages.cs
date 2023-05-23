using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Computation
{
    internal class DailyEmployeeWages
    {
        static void Main(string[] args)
        {
            decimal wagePerHour = 20m;
            int fullDayHour = 8;

            decimal dailyWage = wagePerHour * fullDayHour;

            Console.WriteLine($"Daily Wage: ${dailyWage}");
        }


    }
}
