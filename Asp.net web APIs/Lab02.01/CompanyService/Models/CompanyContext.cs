using System;
using System.Data.Entity;
using System.Linq;

namespace CompanyService.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
                : base("name=CompanyContext")
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}