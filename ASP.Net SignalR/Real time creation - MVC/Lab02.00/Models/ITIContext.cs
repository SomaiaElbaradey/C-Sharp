using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab02._00.Models
{
    public partial class ITIContext : DbContext
    {
        public ITIContext()
            : base("name=ITIContext")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
