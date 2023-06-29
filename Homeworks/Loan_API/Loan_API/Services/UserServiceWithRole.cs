using Loan_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Loan_API.Services
{
    public interface IUserServiceWithRole
    {
        User Login(User model);
        User GetById(int id);
        IEnumerable<User> GetAll();
    }
    public class UserServiceWithRole : IUserServiceWithRole
    {
        private readonly List<User> _users = new()
        {
            new User {
                Id = 1,
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin123",
                Password = "admin123",
                Role = Role.Accountant  },
            new User {
                Id = 2,
                FirstName = "user",
                LastName = "user",
                UserName = "user123",
                Password = "user123",
                Role = Role.User }
        };
        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.Find(x => x.Id == id);
        }

        public User Login( User loginModel)
        {
            if (string.IsNullOrEmpty(loginModel.UserName) || string.IsNullOrEmpty(loginModel.Password))
                return null;

            var user = _users.SingleOrDefault(x => x.UserName == loginModel.UserName);

            if (user == null)
                return null;

            if (loginModel.Password != user.Password)
                return null;

            return user;
        }
    }
}
