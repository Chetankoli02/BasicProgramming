using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Computation
{
    internal class WorkingDayperMonth
    {
        static void Main(string[] args)
        {
            decimal wagePerHour = 20m;
            int fullDayHour = 8;
            int partTimeHour = 8;
            int workingDaysPerMonth = 20;

            decimal totalWage = 0m;
            for (int day = 1; day <= workingDaysPerMonth; day++)
            {
                decimal dailyWage = 0m;
                switch (day % 3)
                {
                    case 0:
                        dailyWage = wagePerHour * fullDayHour;
                        break;
                    case 1:
                        dailyWage = wagePerHour * partTimeHour;
                        break;
                    case 2:
                        dailyWage = 0m;
                        break;

                }
                totalWage += dailyWage;
            }

             Console.WriteLine($"Monthly Wage: ${totalWage}");
        }
    }
}
