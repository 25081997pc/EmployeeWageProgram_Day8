using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmpWageBuildArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int NumOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuildArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];

        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int NumofWorkingDays, int MaxHrsPerMonth)
        {
            companyEmpWageArray[this.NumOfCompany] = new CompanyEmpWage(company, empRatePerHr, NumofWorkingDays, MaxHrsPerMonth);
            NumOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < NumOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
                
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= companyEmpWage.MaxHrsPerMonth && totalWorkingDays < companyEmpWage.NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs: " + empHrs);
                empHrs++;
              
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }
    } 
}
