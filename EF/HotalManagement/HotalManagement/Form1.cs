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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Context = new LoginManagerContext();
            this.FormClosed += (sender, e) => Context.Dispose();
        }
        LoginManagerContext Context;
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KitchenVerifier(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    kitchenManag kitchenManag = new kitchenManag();
                    kitchenManag.Show();
                }
                else if(adminVerifier(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    adminManag adminManag = new adminManag();
                    adminManag.Show();
                }
                else
                {
                    MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        public bool KitchenVerifier(string username, string password)
        {
            bool success = false;
            try
            {
                var user = Context.Kitchens.FirstOrDefault(user => user.UserName == username && user.PassWord == password);
                if (user?.Id != null)
                    success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }
        public bool adminVerifier(string username, string password)
        {
            bool success = false;
            try
            {
                var user = Context.Frontends.FirstOrDefault(user => user.UserName == username && user.PassWord == password);
                if (user?.Id != null)
                    success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }

    }
}