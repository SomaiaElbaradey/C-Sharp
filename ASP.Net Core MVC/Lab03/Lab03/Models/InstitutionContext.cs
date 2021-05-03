using System;
using System.Data.Entity;
using System.Linq;

namespace Lab03.Models
{
    public class InstitutionContext : DbContext
    {
        // Your context has been configured to use a 'InstitutionContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab03.Models.InstitutionContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InstitutionContext' 
        // connection string in the application configuration file.
        public InstitutionContext()
            : base("name=Institution")
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}