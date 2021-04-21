using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HotalManagement
{
    class HotelManager : IManager<Reservation>
    {
        SqlConnection Connection;

        public HotelManager() =>
                    Connection = new SqlConnection("data source=.; Initial catalog=LoginManager; Trusted_Connection=True;");

        public bool Add(Reservation item)
        {
            try
            {
                String query = $"INSERT INTO Reservation" +
                  $"(First_Name, Last_Name, Birth_Date, Gender, Phone_Number, Email_Address, Number_Guest, Street_Address, Apt_suite, City, State, Zip_Code, Room_Type, Room_Floor, Room_Number, Total_Bill, Payment_Type, Card_Type," +
                  $"Card_Number, Card_Exp, Card_Cvc, Arrival_Time, Leaving_Time, Check_In, Break_Fast, Lunch, Dinner, Cleaning, Towel, S_Surprise, Supply_Status, Food_Bill)" +
                  $"VALUES(@First_Name, @Last_Name, @Birth_Date, @Gender, @Phone_Number, @Email_Address, @Number_Guest, @Street_Address, @Apt_suite, @City, @State, @Zip_Code, @Room_Type, @Room_Floor, @Room_Number, @Total_Bill, @Payment_Type," +
                  $" @Card_Type, @Card_Number, @Card_Exp, @Card_Cvc, @Arrival_Time, @Leaving_Time, @Check_In, @Break_Fast, @Lunch, @Dinner, @Cleaning, @Towel, @S_Surprise, @Supply_Status, @Food_Bill)";

                return Connection.Execute(query, item, commandType: CommandType.Text) > 0;
            }
            catch { return false; }
        }
        public SqlConnection getDbConnection() => Connection;
        public bool AdminLogin(string username, string password)
        {
            try
            {
                var admin = Connection.Query<Frontend>($"SELECT *" +
                                           $"FROM frontend WHERE User_name = '{username}' AND Pass_word = '{password}'").FirstOrDefault();
                if (admin != null) return true;
                return false;
            }
            catch { return false; }
        }
        public bool Delete(long id)
            => Connection.Execute($"DELETE FROM Reservation WHERE(ID = {id})") > 0;
        public List<Reservation> GetAll()
        {
            var AllReservations = Connection
                .Query<Reservation>("SELECT * FROM Reservation").ToList();

            return AllReservations;
        }
        public Reservation GetOne(long id)
            => Connection.Query<Reservation>($"SELECT * FROM Reservation WHERE ID='{id}'").FirstOrDefault();
        public bool KitchenLogin(string username, string password)
        {
            try
            {
                var kitchen = Connection.Query<Kitchen>($"SELECT *" +
                                           $"FROM kitchen WHERE User_name = '{username}' AND Pass_word = '{password}'").FirstOrDefault();
                if (kitchen != null) return true;
                return false;
            }
            catch { return false; }
        }
        public bool update(Reservation item)
        {
            try
            {
                String query = "UPDATE Reservation SET " +
                    "First_Name = @First_Name, Last_Name = @Last_Name, Birth_Date = @Birth_Date, Gender = @Gender, Phone_Number = @Phone_Number, Email_Address = @Email_Address," +
                    " Number_Guest = @Number_Guest, Street_Address = @Street_Address, Apt_suite = @Apt_suite, City = @City, State = @State, Zip_Code = @Zip_Code," +
                    " Room_Type = @Room_Type, Room_Floor = @Room_Floor, Room_Number = @Room_Number, Total_Bill = @Total_Bill, Payment_Type = @Payment_Type," +
                    " Card_Type = @Card_Type, Card_Number = @Card_Number, Card_Exp = @Card_Exp, Card_Cvc = @Card_Cvc, Arrival_Time = @Arrival_Time, Leaving_Time = @Leaving_Time," +
                    " Check_In = @Check_In, Break_Fast = @Break_Fast, Lunch = @Lunch, Dinner = @Dinner, Cleaning = @Cleaning, Towel = @Towel, S_Surprise = @S_Surprise," +
                    $" Supply_Status = @Supply_Status, Food_Bill = Food_Bill WHERE ID = {item.ID}";
                return Connection.Execute(query, item, commandType: CommandType.Text) > 0;
            }
            catch { return false; }
        }
        List<Reservation> IManager<Reservation>.GetOccupied()
        {
            var query = "SELECT Room_Type, Room_Floor, Room_Number, First_Name, Last_Name " +
                "FROM Reservation " +
                "WHERE(Check_In is NULL)";
            return Connection.Query<Reservation>(query, commandType: CommandType.Text).ToList();
        }
        List<Reservation> IManager<Reservation>.GetReserved()
        {
            var query = "SELECT Room_Type, Room_Floor, Room_Number, First_Name, Last_Name " +
                            "FROM Reservation " +
                            "WHERE(Check_In is not NULL)";
            return Connection.Query<Reservation>(query, commandType: CommandType.Text).ToList();
        }
        List<Reservation> IManager<Reservation>.ReservFilter(string name)
        {
            var query = "SELECT First_Name " +
                "FROM Reservation " +
                $"WHERE First_Name LIKE %'{name}'%";
            return Connection.Query<Reservation>(query, commandType: CommandType.Text).ToList();
        }
    }
}
