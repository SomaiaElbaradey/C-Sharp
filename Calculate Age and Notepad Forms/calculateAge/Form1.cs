using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculateAge
{
    public partial class Form1 : Form
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Result { get; set; }
        public Form1()
        {
            InitializeComponent();
            fillYear();
        }
        private void fillYear()
        {
            IEnumerable<int> year = Enumerable.Range(1891, 131);
            foreach (var item in year)
            {
                ddlYear.Items.Add(item);
            }
        }
        private void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Month = int.Parse(ddlMonth.Text);
            if(Year != 0) fillDays();
        }
        private void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = int.Parse(ddlYear.Text);
            ddlMonth.Items.Clear();
            IEnumerable<int> months;
            if (Year == 2021) months = Enumerable.Range(1, DateTime.Today.Month);
            else months = Enumerable.Range(1, 12);
            foreach (var item in months)
            {
                ddlMonth.Items.Add(item);
            }
        }
        private void dllDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Day = int.Parse(dllDay.Text);
        }
        private void fillDays()
        {
            dllDay.Items.Clear();
            IEnumerable<int> days;
            if (Year == 2021 && Month == DateTime.Today.Month) days = Enumerable.Range(1, DateTime.Today.Day);
            else
            {
                int y;
                if (Month == 2)
                {
                    if ((Year % 400) == 0) y = 29;
                    else if ((Year % 100) == 0) y = 28;
                    else if ((Year % 4) == 0) y = 29;
                    else y = 28;
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11) y = 30;
                else y = 31;
                days = Enumerable.Range(1, y);
            }
            foreach (var item in days)
            {
                dllDay.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDate = new DateTime(Year, Month, Day);
            DateTime today = DateTime.Today;
            int totalDays = today.Subtract(birthDate).Days;
            int totalYears = totalDays / 365;
            int totalMonths = (totalDays % 365) / 30;
            int remainingDays = (totalDays % 365) % 30;
            Result = $"you have {totalYears} years, {totalMonths} months, and {remainingDays} days old";
            labelResult.Text = Result;
        }
    }
}