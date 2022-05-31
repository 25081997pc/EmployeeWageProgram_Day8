namespace EmployeeWageProgramDay8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program");

            //EmployeeCheck employee = new EmployeeCheck();
            //employee.CheckEmployeePresentOrNot();

            //EmployeeWage employeeWage = new EmployeeWage(20);
            //employeeWage.CalculateEmployeeWage();

            //EmployeeAddPartWage employeeAddPart = new EmployeeAddPartWage(20);
            //employeeAddPart.CalculateAddPartTimeEmpWage();

            //SwitchCase switchCase = new SwitchCase(20);
            //switchCase.UseSwitchCaseStatement();

            //EmpWorkingDay empWorking = new EmpWorkingDay(20, 20);
            //empWorking.CalWagesForMonthWorkingDays();

            //EmployeeMaxHrs employeeMax = new EmployeeMaxHrs(20, 20, 100);
            //employeeMax.CalEmpWageForConditionOfHrsAndMaxdays();

            //EmpWage DELL = new EmpWage(24, 120, 45, "DELL");
            //EmpWage TCS = new EmpWage(20, 140, 40, "TCS");
            //EmpWage WIPRO = new EmpWage(26, 150, 30, "WIPRO");
            //EmpWage BAJAJ = new EmpWage(24, 100, 25, "BAJAJ");
            //EmpWage TATA = new EmpWage(26, 125, 35, "TATA");

            //EmpWageBuildArray empWageBuildArray = new EmpWageBuildArray();
            //empWageBuildArray.addCompanyEmpWage("DMart", 20, 2, 100);
            //empWageBuildArray.addCompanyEmpWage("Reliance", 18, 4, 120);
            //empWageBuildArray.computeEmpWage();

            //EmpWageBuilderobject DMart = new EmpWageBuilderobject("DMart", 20, 2, 10);
            //EmpWageBuilderobject Relaince = new EmpWageBuilderobject("Relaince", 10, 4, 20);
            //DMart.computeEmpWage();
            //Console.WriteLine(DMart.toString());
            //Relaince.computeEmpWage();
            //Console.WriteLine(Relaince.toString());

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("Reliance", 18, 24, 120);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for DMart company : " + empWageBuilder.getTotalWage("DMart"));
            Console.WriteLine("Total Wage for Reliance company : " + empWageBuilder.getTotalWage("Reliance"));

          
        }
    }
}
