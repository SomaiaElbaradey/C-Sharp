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
    public partial class kitchenManag : Form
    {
        public kitchenManag()
        {
            InitializeComponent();
        }
        LoginManagerContext Context = new LoginManagerContext();
        private void kitchenManag_Load(object sender, EventArgs e)
        {
            allReserv();
        }

        //search reservstions by name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var results = Context.Reservations.Where(R => R.FirstName.Contains(serchTxt.Text)).ToList();
            count.Text = $"Result: {results.Count()}";
            dataGridView1.DataSource = results;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            allReserv();
        }

        //get all reservations
        private void allReserv()
        {
            count.Text = $"All Reservations: {Context.Reservations.Count()}";
            var results = Context.Reservations.Select(R => R).ToList();
            dataGridView1.DataSource = results;
        }
    }
}