using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgramDay8
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHrs, int NumofWorkingDays, int MaxHrsPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);
       
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int NumOfWorkingDays;
        public int MaxHrsPerMonth;
        public int totalEmpWage;
       
        public CompanyEmpWage(string company, int empRatePerHr, int NumofWorkingDays, int MaxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.NumOfWorkingDays = NumofWorkingDays;
            this.MaxHrsPerMonth = MaxHrsPerMonth;
            this.totalEmpWage = 0;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {

            this.totalEmpWage = totalEmpWage;

        }

        public string tostring()
        {
            return "Total Emp Wage for company: " + this.company + " is : " + this.totalEmpWage;
        }

    }
}
