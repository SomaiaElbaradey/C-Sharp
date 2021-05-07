using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab01._00.Model
{
    public partial class chatContext : DbContext
    {
        public chatContext()
            : base("name=chatContext")
        {
        }

        public virtual DbSet<message> messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<message>()
                .Property(e => e.name)
                .IsFixedLength();
        }
    }
}
