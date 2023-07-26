namespace Homework_22.HR
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = null!;
        public string SalaryFormula { get; set; }
        public int Budget { get; set; }

        public void CalculateSalary()
        {
            var del = ExpressionHelper.BuildLambda(SalaryFormula, new[] { "WorkedHours", "HourlyRate" , "CommissionRate"});

            var totalSalaries = 0.0;
            foreach (var employee in Employees)
            {
                var salary = (double)del.DynamicInvoke(employee.WorkedHours, employee.HourlyRate,employee.CommissionRate)!;
                totalSalaries += salary;
            }

            if (Budget < totalSalaries)
            {
                Budget += 1000;
            }

            Console.WriteLine(totalSalaries);
        }

    }
}
