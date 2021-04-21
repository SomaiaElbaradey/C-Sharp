using System;
using System.Collections.Generic;

#nullable disable

namespace HotalManagement
{
    public partial class Reservation
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime? Birth_Date { get; set; }
        public string Gender { get; set; }
        public string Phone_Number { get; set; }
        public string Email_Address { get; set; }
        public int? Number_Guest { get; set; }
        public string Street_Address { get; set; }
        public string Apt_suite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Room_Type { get; set; }
        public string Room_Floor { get; set; }
        public string Room_Number { get; set; }
        public double? Total_Bill { get; set; }
        public string Payment_Type { get; set; }
        public string Card_Type { get; set; }
        public string Card_Number { get; set; }
        public string Card_Exp { get; set; }
        public string Card_Cvc { get; set; }
        public DateTime? Arrival_Time { get; set; }
        public DateTime? Leaving_Time { get; set; }
        public DateTime? Check_In { get; set; }
        public int? Break_Fast { get; set; }
        public int? Lunch { get; set; }
        public int? Dinner { get; set; }
        public string Cleaning { get; set; }
        public string Towel { get; set; }
        public string S_Surprise { get; set; }
        public string Supply_Status { get; set; }
        public int? Food_Bill { get; set; }
    }
}
