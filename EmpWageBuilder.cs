using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageMap = new Dictionary<string, CompanyEmpWage>();

        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int NumofWorkingDays, int MaxHrsPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, NumofWorkingDays, MaxHrsPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.tostring());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.MaxHrsPerMonth && totalWorkingDays < companyEmpWage.NumOfWorkingDays)
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
                int dailyEmpWage = empHrs * companyEmpWage.empRatePerHr;
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs: " + empHrs + " dailyEmpwage: " + dailyEmpWage);
                empHrs++;

            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }        
        public int getTotalWage(string company)
        { 
            return this.companyEmpWageMap[company].totalEmpWage;
        }
        
    }
}