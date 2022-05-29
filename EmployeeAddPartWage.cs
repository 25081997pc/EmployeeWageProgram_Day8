using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmployeeAddPartWage
    {
        int EMP_RATE_PER_HOUR;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public EmployeeAddPartWage(int ERPH)
        {
            EMP_RATE_PER_HOUR = ERPH;
        }
        public void CalculateAddPartTimeEmpWage()
        {
            
            int empDailyHrs = 0;
            int empDailyWage = 0;

            Random random = new Random();

            int empChk = random.Next(3);

            if (empChk == IS_FULL_TIME)
            {
                empDailyHrs = 8;
            }
            else if (empChk == IS_PART_TIME)
            {
                empDailyHrs = 4;
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
