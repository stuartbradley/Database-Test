using Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public Context(DbContextOptions<Context> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Stuart Bradley",
                    DateOfBirth = new DateTime(1991, 6, 28),
                    EmployeedBy = "Juno",
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 2,
                    Name = "Amy Jones",
                    DateOfBirth = new DateTime(1992, 6, 3),
                    EmployeedBy = "Blackpool Sixth Form",
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 3,
                    Name = "Marianne Bradley",
                    DateOfBirth = new DateTime(1972, 5, 9),
                    EmployeedBy = "National Savings",
                }
            );
        }
    }
}
