using System;
using System.Data.Entity;
using System.Linq;

namespace Lab05.Models
{
    public class MVC05_CompanyContext : DbContext
    {
        // Your context has been configured to use a 'MVC05_CompanyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab05.Models.MVC05_CompanyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MVC05_CompanyContext' 
        // connection string in the application configuration file.
        public MVC05_CompanyContext()
            : base("name=MVC05_Company")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}