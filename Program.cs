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

            EmployeeAddPartWage employeeAddPart = new EmployeeAddPartWage(20);
            employeeAddPart.CalculateAddPartTimeEmpWage();
        }
    }
}
