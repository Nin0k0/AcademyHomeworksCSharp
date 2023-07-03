using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_API.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public bool IsBlocked { get; set; } = false;
        public double WorkExperince { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        public List<Loan> Loan { get; set; } = new List<Loan>();
        
    }

    public class UserLoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserCreateModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public double WorkExperince { get; set; }
        public string Password { get; set; }
        
    }


    public enum Role
    {
        User, 
        Accountant
    }
}
