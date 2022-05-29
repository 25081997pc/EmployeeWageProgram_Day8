using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmpWorkingDay
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR;
        int NUM_OF_WORKING_DAYS;

        public EmpWorkingDay(int NOWD, int ERPH)
        {
            NUM_OF_WORKING_DAYS = NOWD;
            EMP_RATE_PER_HOUR = ERPH;
           
        }
        public void CalWagesForMonthWorkingDays()
        {
            int empDailyHrs = 0;
            int empDailyWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                
                int empChk = random.Next(3);

                switch (empChk)
                {
                    case IS_FULL_TIME:
                        empDailyHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empDailyHrs = 4;
                        break;
                    default:
                        empDailyHrs = 0;
                        break;
                }
                empDailyWage = empDailyHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Day: " + day + " Emp Wage :" + empDailyWage);
                totalEmpWage += empDailyWage;
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }
}
