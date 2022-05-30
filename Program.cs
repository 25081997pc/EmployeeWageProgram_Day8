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

            EmpWage DELL = new EmpWage(24, 120, 45, "DELL");
            EmpWage TCS = new EmpWage(20, 140, 40, "TCS");
            EmpWage WIPRO = new EmpWage(26, 150, 30, "WIPRO");
            EmpWage BAJAJ = new EmpWage(24, 100, 25, "BAJAJ");
            EmpWage TATA = new EmpWage(26, 125, 35, "TATA");

        }
    }
}
