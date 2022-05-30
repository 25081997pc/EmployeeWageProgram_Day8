using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmpWage
    {
        int NO_OF_WORKING_DAYS, MAX_HRS_IN_MONTH, EMP_RATE_PER_HR;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        string companyName;

        public EmpWage(int MWD, int MWH, int ERPH, string CompanyName)
        {
            companyName = CompanyName;
            NO_OF_WORKING_DAYS = MWD;
            MAX_HRS_IN_MONTH = MWH;
            EMP_RATE_PER_HR = ERPH;
            employeecheck();

        }
        public void employeecheck()
        {

            Console.WriteLine("calculating emp wage for company : " + companyName);

            int total_EmpWage = 0;
            int empDailyHR = 0;
            int empDailyWage = 0;
            int days = 0; 
            int total_hours = 0;
            Random random = new Random();

            while(days < NO_OF_WORKING_DAYS && total_hours <= MAX_HRS_IN_MONTH)
            {
                days++;
                int check = random.Next(3);

                switch (check)
                {
                    case IS_FULL_TIME:
                        empDailyHR = 8;
                        break;
                    case IS_PART_TIME:
                        empDailyHR = 4;
                        break;
                    default:
                        empDailyHR = 0;
                        break;
                }
                total_hours += empDailyHR;
                empDailyWage = EMP_RATE_PER_HR * empDailyHR;
                Console.WriteLine("Day {0}: {1}" ,days, empDailyWage);
                total_EmpWage += empDailyWage;
            }
            Console.WriteLine("\nTotal Wage :{0} for {1} company", total_EmpWage, companyName);

            Console.WriteLine("Total Days : " + days + " Total Hours: " + total_hours);
        }
    }
}
