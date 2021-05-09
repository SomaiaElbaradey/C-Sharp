using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }


        //wrong this is used for console and desktop apps but not web for web go to StartUp.cs
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=APIsDay01;Trusted_connection=true");
        //}
    }
}
