using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmployeeMaxHrs
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int MAX_HRS_IN_MONTH;
        int NUM_OF_WORKING_DAYS;
        int EMP_RATE_PER_HOUR;
        public EmployeeMaxHrs(int ERPR, int NOWD, int MHIM)
        {
            EMP_RATE_PER_HOUR = ERPR;
            NUM_OF_WORKING_DAYS = NOWD;
            MAX_HRS_IN_MONTH = MHIM;
        }
        public void CalEmpWageForConditionOfHrsAndMaxdays()
        {
            int empDailyHrs = 0;
            int empDailyWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            

            while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalEmpHrs <= MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;

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
                totalEmpHrs += empDailyHrs;
                empDailyWage = empDailyHrs * EMP_RATE_PER_HOUR;
                
                Console.WriteLine("Day :" + totalWorkingDays + " Employee Hrs :" + empDailyHrs + " EmpWage : " +empDailyWage);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }

    }
}
