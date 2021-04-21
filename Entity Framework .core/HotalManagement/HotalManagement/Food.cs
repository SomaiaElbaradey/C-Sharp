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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }
        public int Lunch { get; set; } = 0;
        public int Breakfast { get; set; } = 0;
        public int Dinner { get; set; } = 0;
        public int Clean { get; set; } = 0;
        public int Towel { get; set; } = 0;
        public int Surprise { get; set; } = 0;
        private void Food_Load(object sender, EventArgs e)
        {
            if (lunch.Checked)
                lunchQuantity.Enabled = true;
            else
                lunchQuantity.Enabled = false;
            if (breakfast.Checked)
                breakfastQuantity.Enabled = true;
            else
                breakfastQuantity.Enabled = false;
            if (dinner.Checked)
                dinnerQuantity.Enabled = true;
            else
                dinnerQuantity.Enabled = false;
        }
        private void breakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (breakfast.Checked)
                breakfastQuantity.Enabled = true;
            else
                breakfastQuantity.Enabled = false;
        }
        private void lunch_CheckedChanged(object sender, EventArgs e)
        {
            if (lunch.Checked)
                lunchQuantity.Enabled = true;
            else
                lunchQuantity.Enabled = false;
        }
        private void dinner_CheckedChanged(object sender, EventArgs e)
        {
            if (dinner.Checked)
                dinnerQuantity.Enabled = true;
            else
                dinnerQuantity.Enabled = false;
        }
        private void foodBtn_Click(object sender, EventArgs e)
        {
            if (breakfast.Checked)
                Breakfast = Int32.TryParse(breakfastQuantity.Text, out int breakfastQt) ? breakfastQt : 1;
            if (lunch.Checked)
                Lunch = Int32.TryParse(lunchQuantity.Text, out int lunchQt) ? lunchQt : 1;
            if (dinner.Checked)
                Dinner = Int32.TryParse(dinnerQuantity.Text, out int dinnerQt) ? dinnerQt : 1;
            if (cleaning.Checked) Clean = 1;
            if (sweats.Checked) Surprise = 1;
            if (towels.Checked) Towel = 1;
            this.Hide();
        }
    }
}