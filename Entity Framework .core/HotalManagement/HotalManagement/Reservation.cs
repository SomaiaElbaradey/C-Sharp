using System;
using System.Collections.Generic;

#nullable disable

namespace HotalManagement
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? NumberGuest { get; set; }
        public string StreetAddress { get; set; }
        public string AptSuite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RoomType { get; set; }
        public string RoomFloor { get; set; }
        public string RoomNumber { get; set; }
        public double? TotalBill { get; set; }
        public string PaymentType { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardExp { get; set; }
        public string CardCvc { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? LeavingTime { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? BreakFast { get; set; }
        public int? Lunch { get; set; }
        public int? Dinner { get; set; }
        public string Cleaning { get; set; }
        public string Towel { get; set; }
        public string SSurprise { get; set; }
        public string SupplyStatus { get; set; }
        public int? FoodBill { get; set; }
    }
}
