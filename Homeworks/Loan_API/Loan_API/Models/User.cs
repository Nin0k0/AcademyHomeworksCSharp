using System.Collections.Generic;

namespace Loan_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdentificationNumber { get; set; }
        public Role Role { get; set; }
        public List<Loan> Loans { get; set; }

        public bool IsRestricted { get; set; }
    }



    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class UserRegister
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Role Role { get; } = Role.User;

        
    }

    public enum Role
    {
        User,
        Accountant
    }
}