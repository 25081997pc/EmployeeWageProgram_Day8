using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR;

        public EmployeeWage(int ERPH)
        {
            EMP_RATE_PER_HOUR = ERPH;
        }
        public void CalculateEmployeeWage()
        {
            int empDailyHrs = 0;
            int empDailyWage = 0;

            Random random = new Random();
            int empChk = random.Next(2);

            if (empChk == IS_FULL_TIME)
            {
                empDailyHrs = 8;
            }
            else
            {
                empDailyHrs = 0;
            }
            empDailyWage = empDailyHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee Wage :" + empDailyWage);
        }
    }
}
