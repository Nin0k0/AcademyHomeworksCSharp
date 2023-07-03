using Loan_API.Domain;
using Microsoft.EntityFrameworkCore;

namespace Loan_API.Data
{
    public class LoanDBContext : DbContext
    {
        public LoanDBContext(DbContextOptions<LoanDBContext> options)
              : base(options)
        {

        }



        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
       
        //public DbSet<LoanStatus> LoanStatuses { get; set; }

    }
}
