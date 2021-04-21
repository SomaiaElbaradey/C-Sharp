using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HotalManagement
{
    public partial class LoginManagerContext : DbContext
    {
        public LoginManagerContext()
        {
        }

        public LoginManagerContext(DbContextOptions<LoginManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Frontend> Frontends { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=.; Initial catalog=LoginManager; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Frontend>(entity =>
            {
                entity.ToTable("frontend");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Pass_Word)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Pass_word");

                entity.Property(e => e.User_Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_name");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.ToTable("kitchen");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Pass_Word)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Pass_word");

                entity.Property(e => e.User_Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_name");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Apt_suite)
                    .HasMaxLength(50)
                    .HasColumnName("Apt_suite");

                entity.Property(e => e.Arrival_Time).HasColumnName("Arrival_Time");

                entity.Property(e => e.Birth_Date).HasColumnName("Birth_Date");

                entity.Property(e => e.Break_Fast).HasColumnName("Break_Fast");

                entity.Property(e => e.Card_Cvc)
                    .HasMaxLength(10)
                    .HasColumnName("Card_Cvc");

                entity.Property(e => e.Card_Exp).HasColumnName("Card_Exp");

                entity.Property(e => e.Card_Number).HasColumnName("Card_Number");

                entity.Property(e => e.Card_Type)
                    .HasMaxLength(10)
                    .HasColumnName("Card_Type");

                entity.Property(e => e.Check_In).HasColumnName("Check_In");

                entity.Property(e => e.Email_Address).HasColumnName("Email_Address");

                entity.Property(e => e.First_Name)
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.Food_Bill).HasColumnName("Food_Bill");

                entity.Property(e => e.Last_Name)
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Leaving_Time).HasColumnName("Leaving_Time");

                entity.Property(e => e.Number_Guest).HasColumnName("Number_Guest");

                entity.Property(e => e.Payment_Type)
                    .HasMaxLength(10)
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.Phone_Number)
                    .HasMaxLength(50)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.Room_Floor)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Floor");

                entity.Property(e => e.Room_Number)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Number");

                entity.Property(e => e.Room_Type)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Type");

                entity.Property(e => e.S_Surprise).HasColumnName("S_Surprise");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Street_Address).HasColumnName("Street_Address");

                entity.Property(e => e.Supply_Status).HasColumnName("Supply_Status");

                entity.Property(e => e.Total_Bill).HasColumnName("Total_Bill");

                entity.Property(e => e.Zip_Code)
                    .HasMaxLength(10)
                    .HasColumnName("Zip_Code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
