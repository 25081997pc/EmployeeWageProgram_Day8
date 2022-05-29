using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class SwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR;

        public SwitchCase(int ERPH)
        {
            EMP_RATE_PER_HOUR = ERPH;
        }
        public void UseSwitchCaseStatement()
        {
            int empDailyHrs = 0;
            int empDailyWage = 0;

            Random random = new Random();
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
            Console.WriteLine("Employee Wage :" + empDailyWage);
        }
    }
}
