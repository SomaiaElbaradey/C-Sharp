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
            //this.Text = Context.Frontends.Count().ToString();
            var results = Context.Reservations.Select(R => new Reservation());
            dataGridView1.DataSource = results.ToList();
        }
    }
}