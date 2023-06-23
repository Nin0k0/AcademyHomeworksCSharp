using Homework_ORM.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ORM.Data
{
    public class PersonContext: DbContext
    {
        
            public PersonContext(DbContextOptions<PersonContext> options)
                  : base(options)
            {

            }
            
        

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
