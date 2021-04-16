using HotelManag.configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManag
{
    public class LoginManager: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LoginManager;Integrated Security=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Kitchen>(EntityBuilder =>
             {
                 EntityBuilder.Property(C => C.Pass_word)
                    .IsRequired()
                    .HasMaxLength(50);

                 EntityBuilder.Property(C => C.User_name)
                    .HasMaxLength(50);
             }
            );
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Kitchen> Kitchen { get; set; }
        public virtual DbSet<Frontend> Frontend { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
    }
}