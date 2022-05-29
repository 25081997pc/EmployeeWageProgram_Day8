namespace EmployeeWageProgramDay8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program");

            EmployeeCheck employee = new EmployeeCheck();
            employee.CheckEmployeePresentOrNot();

        }
    }
}
