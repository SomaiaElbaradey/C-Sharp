using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManag.Migrations
{
    public partial class reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Guest = table.Column<int>(type: "int", nullable: true),
                    Street_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apt_suite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip_Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Room_Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Room_Floor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Room_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Total_Bill = table.Column<double>(type: "float", nullable: false),
                    Payment_Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Card_Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Card_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Card_Exp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Card_Cvc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Arrival_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Leaving_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Check_In = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Break_Fast = table.Column<int>(type: "int", nullable: true),
                    Lunch = table.Column<int>(type: "int", nullable: true),
                    Dinner = table.Column<int>(type: "int", nullable: true),
                    Cleaning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Towel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S_Surprise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supply_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Food_Bill = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
