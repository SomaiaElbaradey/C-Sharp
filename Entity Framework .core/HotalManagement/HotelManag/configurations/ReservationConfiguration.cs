using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManag.configurations
{
    class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> EntityBuilder)
        {
            EntityBuilder.Property(C => C.First_Name)
                   .HasMaxLength(50);

            EntityBuilder.Property(C => C.Last_Name)
                   .HasMaxLength(50);

            EntityBuilder.Property(C => C.Apt_suite)
                   .HasMaxLength(50);

            EntityBuilder.Property(C => C.State)
                   .HasMaxLength(50);

            EntityBuilder.Property(C => C.Phone_Number)
                   .HasMaxLength(50);

            EntityBuilder.Property(C => C.Zip_Code)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Room_Floor)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Room_Type)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Room_Number)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Payment_Type)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Card_Type)
                   .HasMaxLength(10);

            EntityBuilder.Property(C => C.Card_Cvc)
                   .HasMaxLength(10);
        }
    }
}
