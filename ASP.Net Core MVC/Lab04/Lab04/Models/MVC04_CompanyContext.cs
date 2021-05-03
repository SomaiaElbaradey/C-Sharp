using System;
using System.Data.Entity;
using System.Linq;

namespace Lab04.Models
{
    public class MVC04_CompanyContext : DbContext
    {
        public MVC04_CompanyContext()
            : base("name=MVC04_Company")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}