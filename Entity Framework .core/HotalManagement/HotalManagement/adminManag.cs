using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotalManagement
{
    public partial class adminManag : Form
    {
        public adminManag()
        {
            InitializeComponent();
        }
        LoginManagerContext Context = new LoginManagerContext();

        private void editBtn_Click(object sender, EventArgs e)
        {
            sumbitBtn.Visible = false;
            updateBtn.Visible = true;
            deleteBtn.Visible = true;
            reservation.Visible = true;

            fillResCombo();
            fieldsCLS();
        }

        //load data for reservation for editing
        private void LoadData(int id)
        {
            if (id != 0)
            {
                try
                {
                    var reserv = Context.Reservations.Find(id);
                    if (reserv.PaymentType == "cash")
                    {
                        hideCredit();
                        cash.Checked = true;
                    }
                    else if (reserv.PaymentType == "credit")
                    {
                        credit.Checked = true;
                        cardNumber.Text = reserv.CardNumber;
                        exp.Text = reserv.CardExp;
                        cvc.Text = reserv.CardCvc;
                        cardType.Text = reserv.CardType;
                        hideCash();
                    }
                    apt.SelectedItem = reserv.AptSuite;
                    firstname.Text = reserv.FirstName;
                    lastname.Text = reserv.LastName;
                    gender.Text = reserv.Gender;
                    phone.Text = reserv.PhoneNumber;
                    address.Text = reserv.StreetAddress;
                    email.Text = reserv.EmailAddress;
                    city.Text = reserv.City;
                    state.SelectedItem = reserv.State;
                    zip.Text = reserv.ZipCode;
                    room.Text = reserv.RoomType;
                    floor.Text = reserv.RoomFloor;
                    floorNo.Text = reserv.RoomNumber;

                    birthday.Text = reserv.BirthDate.ToString();
                    arrivDate.Text = reserv.ArrivalTime.ToString();
                    leaveDate.Text = reserv.LeavingTime.ToString();

                    guest.SelectedItem = reserv.NumberGuest;

                    if (reserv.CheckIn != null) checkin.Checked = true;
                    if (reserv.SupplyStatus != null) food.Checked = true;
                    lunch = (int)reserv.Lunch;
                    dinner = (int)reserv.Dinner;
                    breakfast = (int)reserv.BreakFast;

                    towel = Int32.TryParse(reserv.Towel, out int Theowel) ? Theowel : 0;
                    cleaning = Int32.TryParse(reserv.Cleaning, out int cleaninng) ? cleaninng : 0;
                    surprise = Int32.TryParse(reserv.SSurprise, out int SSurprise) ? SSurprise : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("You've selected empty data! please try again.", "Error!");
        }

        //first load for combos, default state
        private void adminManag_Load(object sender, EventArgs e)
        {
            deleteBtn.Visible = false;
            updateBtn.Visible = false;
            reservation.Visible = false;
            fillCombos();
            fieldsCLS();
        }

        private void reversation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = (int)reservation.SelectedValue;
            LoadData(res);
        }

        //update existing reservation
        private void updateBtn_Click(object sender, EventArgs e)
        {
            getFoodInfo();
            int res = (int)reservation.SelectedValue;
            if (res != 0)
            {
                try
                {
                    var reserv = Context.Reservations.Find(res);

                    reserv.FirstName = firstname.Text;
                    reserv.LastName = lastname.Text;
                    reserv.Gender = gender.Text;
                    reserv.PhoneNumber = phone.Text;
                    reserv.StreetAddress = address.Text;
                    reserv.EmailAddress = email.Text;
                    reserv.RoomType = room.Text;
                    reserv.RoomFloor = floor.Text;
                    reserv.RoomNumber = floorNo.Text;

                    reserv.ArrivalTime = arrivDate.Text != "" ? Convert.ToDateTime(arrivDate.Text) : DateTime.Now;
                    reserv.LeavingTime = leaveDate.Text != "" ? Convert.ToDateTime(leaveDate.Text) : DateTime.Now;
                    reserv.BirthDate = birthday.Text != "" ? Convert.ToDateTime(birthday.Text) : DateTime.Now;
                    reserv.NumberGuest = Int32.TryParse(guest.Text, out int guestNo) ? guestNo : 0;

                    reserv.BreakFast = breakfast;
                    reserv.Dinner = dinner;
                    reserv.Lunch = lunch;
                    reserv.TotalBill = foodBill;

                    reserv.AptSuite = string.IsNullOrEmpty(apt.Text) ? null : apt.Text;
                    reserv.City = string.IsNullOrEmpty(city.Text) ? null : city.Text;
                    reserv.State = string.IsNullOrEmpty(state.Text) ? null : state.Text;
                    reserv.ZipCode = string.IsNullOrEmpty(zip.Text) ? null : zip.Text;

                    reserv.Cleaning = cleaning.ToString();
                    reserv.SSurprise = surprise.ToString();
                    reserv.Towel = towel.ToString();
                    reserv.TotalBill = calculateBill();

                    if (checkin.Checked) reserv.CheckIn = DateTime.Now;
                    if (food.Checked) reserv.SupplyStatus = "1";
                    if (credit.Checked)
                    {
                        reserv.CardCvc = string.IsNullOrEmpty(cvc.Text) ? null : cvc.Text;
                        reserv.CardExp = string.IsNullOrEmpty(exp.Text) ? null : exp.Text;
                        reserv.CardType = string.IsNullOrEmpty(cardType.Text) ? null : cardType.Text;
                        reserv.CardNumber = cardNumber.Text;
                        reserv.PaymentType = "credit";
                    }
                    else
                        reserv.PaymentType = "cash";

                    Context.SaveChanges();
                    fieldsCLS();
                    msg.Text = "Reservation has been edited successfully.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("You've selected empty data! please try again.", "Error!");

            deleteBtn.Visible = false;
            updateBtn.Visible = false;
            reservation.Visible = false;
            sumbitBtn.Visible = true;
        }

        //open food and menu form with default data or reserved in update 
        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private int cleaning = 0; private int towel = 0; private int surprise = 0;
        private int foodBill = 0;
        Food userfood;
        private void foodBtn_Click(object sender, EventArgs e)
        {
            userfood = new Food();

            if (lunch != 0) userfood.lunch.Checked = true;
            if (dinner != 0) userfood.dinner.Checked = true;
            if (breakfast != 0) userfood.breakfast.Checked = true;
            if (towel != 0) userfood.towels.Checked = true;
            if (cleaning != 0) userfood.cleaning.Checked = true;
            if (surprise != 0) userfood.sweats.Checked = true;
            userfood.lunchQuantity.Value = lunch;
            userfood.dinnerQuantity.Value = dinner;
            userfood.breakfastQuantity.Value = breakfast;

            userfood.Show();
        }

        //returns the final bill
        private float calculateBill()
        {
            int guestBill = 0;
            int roomBill = 0;
            if (guest.SelectedItem != null) guestBill = (int)guest?.SelectedItem * 100;
            float serviceBill = cleaning * 9 + towel * 3 + surprise * 5;
            if (room.SelectedItem != null)
            {
                roomBill = (room?.SelectedItem?.ToString() == "Double" ? 300 : 0) +
                (room?.SelectedItem?.ToString() == "Family" ? 900 : 0) +
                (room?.SelectedItem?.ToString() == "Single" ? 150 : 0) +
                (apt?.SelectedItem?.ToString() == "SUI" ? 500 : 300);
            }

            return (foodBill + guestBill + serviceBill + roomBill);
        }

        //clean fields
        private void fieldsCLS()
        {
            firstname.Text = "";
            lastname.Text = "";
            phone.Text = "";
            email.Text = "";
            address.Text = "";
            city.Text = "";
            zip.Text = "";
            food.Checked = false;
            checkin.Checked = false;
            sms.Checked = false;
            apt.Text = "";
            msg.Text = "";
            lunch = 0;
            breakfast = 0;
            dinner = 0;
            surprise = 0;
            towel = 0;
            cleaning = 0;
            foodBill = 0;
            gender.SelectedItem = null;
            state.SelectedItem = null;
            floor.SelectedItem = null;
            room.SelectedItem = null;
            floorNo.SelectedItem = null;
            guest.SelectedItem = null;
            apt.SelectedItem = null;
            cardType.SelectedItem = null;
            cash.Checked = true;
            hideCredit();
        }

        //add new reservation
        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            getFoodInfo();
            dynamic bills = calculateBill();

            DateTime birth_day = birthday.Text != "" ? Convert.ToDateTime(birthday.Text) : DateTime.Now;
            DateTime arrival_Time = arrivDate.Text != "" ? Convert.ToDateTime(arrivDate.Text) : DateTime.Now;
            DateTime Leaving_Time = leaveDate.Text != "" ? Convert.ToDateTime(leaveDate.Text) : DateTime.Now;

            int guest_No = Int32.TryParse(guest.Text, out int guestNo) ? guestNo : 0;
            string SupplyStatus = "";
            if (food.Checked) SupplyStatus = "1";

            string payType = "";
            if (credit.Checked) payType = "credit";
            if (cash.Checked) payType = "cash";

            if (firstname.Text != null)
            {
                try
                {
                    Reservation R01 = new Reservation()
                    {
                        FirstName = firstname.Text,
                        LastName = lastname.Text,
                        PhoneNumber = phone.Text,
                        Gender = gender.Text,
                        StreetAddress = address.Text,
                        EmailAddress = email.Text,
                        RoomType = room.Text,
                        RoomFloor = floor.Text,
                        RoomNumber = floorNo.Text,
                        BreakFast = breakfast,
                        Dinner = dinner,
                        Lunch = lunch,
                        AptSuite = string.IsNullOrEmpty(apt.Text) ? null : apt.Text,
                        City = string.IsNullOrEmpty(city.Text) ? null : city.Text,
                        State = string.IsNullOrEmpty(state.Text) ? null : state.Text,
                        ZipCode = string.IsNullOrEmpty(zip.Text) ? null : zip.Text,
                        CardCvc = string.IsNullOrEmpty(cvc.Text) ? null : cvc.Text,
                        CardExp = string.IsNullOrEmpty(exp.Text) ? null : exp.Text,
                        CardType = string.IsNullOrEmpty(cardType.Text) ? null : cardType.Text,
                        Towel = towel.ToString(),
                        SSurprise = surprise.ToString(),
                        Cleaning = cleaning.ToString(),
                        BirthDate = birth_day,
                        NumberGuest = guest_No,
                        CheckIn = DateTime.Now,
                        SupplyStatus = SupplyStatus,
                        FoodBill = foodBill,
                        TotalBill = calculateBill(),
                        PaymentType = payType,
                        ArrivalTime = arrival_Time,
                        LeavingTime = Leaving_Time
                    };
                    Context.Add(R01);
                    Context.SaveChanges();
                    fieldsCLS();
                    msg.Text = "Reservation added succesfully.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("You've selected empty data! please try again.", "Error!");
        }

        //get food info and calculate the bill
        private void getFoodInfo()
        {
            if (userfood != null)
            {
                breakfast = userfood.Breakfast;
                lunch = userfood.Lunch;
                dinner = userfood.Dinner;

                cleaning = userfood.Clean;
                towel = userfood.Towel;
                surprise = userfood.Surprise;

                if (breakfast > 0 || lunch > 0 || dinner > 0)
                {
                    foodBill = (15 * dinner) + (15 * lunch) + (7 * breakfast);
                }
                userfood.Close();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            fieldsCLS();
        }

        private void fillResCombo()
        {
            //Context.Reservations.Load();
            //reservation.DataSource = Context.Reservations.Local.ToBindingList();
            //reservation.DisplayMember = "FirstName";
            //reservation.ValueMember = "ID";

            var res = (from R01 in Context.Reservations
                       select R01)
                          .Select(R01 =>
                          new
                          {
                              Res_ID = R01.Id,
                              ClientName = $"{R01.FirstName}  {R01.LastName}",
                          }).ToList();

            reservation.DisplayMember = "ClientName";
            reservation.ValueMember = "Res_ID";
            reservation.DataSource = res;
        }

        private void fillCombos()
        {
            var genderList = new List<string>() { "Male", "Female", "Others" };
            var states = new List<string>()
                    {
                        "Alabama",
                        "Alaska",
                        "Arizona",
                        "Arkansas",
                        "California",
                        "Colorado",
                        "Connecticut",
                        "Delaware",
                    };
            var floorList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var roomList = new List<int>() { 100, 101, 102, 103, 104, 105, 106, 107, 108 };
            var roomType = new List<string>() { "Single", "Double", "Family" };
            var guests = new List<int>() { 1, 2, 3, 4, 5 };
            var apts = new List<string>() { "APT", "SUI" };
            var cards = new List<string>() { "credit", "VISA", "Strip", "paypal" };

            gender.DataSource = genderList;
            state.DataSource = states;
            floor.DataSource = floorList;
            room.DataSource = roomType;
            floorNo.DataSource = roomList;
            guest.DataSource = guests;
            apt.DataSource = apts;
            cardType.DataSource = cards;
        }

        //handle cash and credit appearance
        private void cash_CheckedChanged(object sender, EventArgs e)
        {
            hideCredit();
        }
        private void credit_CheckedChanged(object sender, EventArgs e)
        {
            hideCash();
        }
        private void hideCredit()
        {
            cardNumber.Enabled = false;
            exp.Enabled = false;
            cvc.Enabled = false;
            cardType.Enabled = false;
        }
        private void hideCash()
        {
            cardNumber.Enabled = true;
            exp.Enabled = true;
            cvc.Enabled = true;
            cardType.Enabled = true;
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            float bill = calculateBill();
            msg.Text = $"your total bill: {bill}$";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int resId = (int)reservation.SelectedValue;
            var reserv = Context.Reservations.Find(resId);
            Context.Reservations.Remove(reserv);
            Context.SaveChanges();
            fieldsCLS();
            msg.Text = "reservation has been deleted successfully";
        }
    }
}