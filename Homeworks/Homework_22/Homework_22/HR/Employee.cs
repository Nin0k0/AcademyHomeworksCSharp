using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22.HR
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double WorkedHours { get; set; }
        public double HourlyRate { get; set; }

        public double CommissionRate { get; set; }

    }
}
