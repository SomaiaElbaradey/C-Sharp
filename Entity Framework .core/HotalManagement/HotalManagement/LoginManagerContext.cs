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

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Pass_word");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_name");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.ToTable("kitchen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Pass_word");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_name");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AptSuite)
                    .HasMaxLength(50)
                    .HasColumnName("Apt_suite");

                entity.Property(e => e.ArrivalTime).HasColumnName("Arrival_Time");

                entity.Property(e => e.BirthDate).HasColumnName("Birth_Date");

                entity.Property(e => e.BreakFast).HasColumnName("Break_Fast");

                entity.Property(e => e.CardCvc)
                    .HasMaxLength(10)
                    .HasColumnName("Card_Cvc");

                entity.Property(e => e.CardExp).HasColumnName("Card_Exp");

                entity.Property(e => e.CardNumber).HasColumnName("Card_Number");

                entity.Property(e => e.CardType)
                    .HasMaxLength(10)
                    .HasColumnName("Card_Type");

                entity.Property(e => e.CheckIn).HasColumnName("Check_In");

                entity.Property(e => e.EmailAddress).HasColumnName("Email_Address");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.FoodBill).HasColumnName("Food_Bill");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.LeavingTime).HasColumnName("Leaving_Time");

                entity.Property(e => e.NumberGuest).HasColumnName("Number_Guest");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("Payment_Type");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.RoomFloor)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Floor");

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Number");

                entity.Property(e => e.RoomType)
                    .HasMaxLength(10)
                    .HasColumnName("Room_Type");

                entity.Property(e => e.SSurprise).HasColumnName("S_Surprise");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasColumnName("Street_Address");

                entity.Property(e => e.SupplyStatus).HasColumnName("Supply_Status");

                entity.Property(e => e.TotalBill).HasColumnName("Total_Bill");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .HasColumnName("Zip_Code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
