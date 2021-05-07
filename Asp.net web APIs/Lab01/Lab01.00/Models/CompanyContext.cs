using System;
using System.Data.Entity;
using System.Linq;

namespace Lab01._00.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
            : base("name=CompanyAPI01")
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}