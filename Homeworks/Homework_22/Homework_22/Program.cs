using Homework_22.HR;

try
{
    SalaryExample();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}




static void SalaryExample()
{
    var employees = new List<Employee>()
    {
        new() { HourlyRate = 20, WorkedHours = 50, Name = "test1", CommissionRate = 10 },
        new() { HourlyRate = 50, WorkedHours = 20, Name = "test2", CommissionRate = 10 },
        new() { HourlyRate = 20, WorkedHours = 50, Name = "test3", CommissionRate = 10 },
        new() { HourlyRate = 50, WorkedHours = 20, Name = "test4", CommissionRate = 10 }

    };

    var department = new Department()
    {
        Budget = 100,
        Employees = employees,
        // SalaryFormula = "WorkedHours HourlyRate * CommissionRate HourlyRate WorkedHours * * 100 / -"
        SalaryFormula = "100 CommissionRate HourlyRate WorkedHours * * / WorkedHours HourlyRate * -"
    };
    department.CalculateSalary();

}
