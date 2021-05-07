using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Company.DesktopConsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillEmployeeGridView();
            FillEmployeeComboBox();
        }
        private void FillEmployeeGridView()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://localhost:1313/api/employee").Result;
            if (result.IsSuccessStatusCode)
            {
                var msg = result.Content.ReadAsAsync<List<Employee>>().Result;
                dataGridView1.DataSource = msg;
            }
            else
            {
                MessageBox.Show(result.ReasonPhrase);
            }
        }

        private void FillEmployeeComboBox()
        {
            HttpClient client = new HttpClient();
            var res = client.GetAsync("http://localhost:1313/api/employee").Result;
            if (res.IsSuccessStatusCode)
            {
                var msg = res.Content.ReadAsAsync<List<Employee>>().Result;
                comboBox1.DataSource = msg;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show(res.ReasonPhrase + " " + res.StatusCode);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var res = client.GetAsync($"http://localhost:1313/api/employee/{comboBox1.SelectedValue}").Result;
            if (res.IsSuccessStatusCode)
            {
                var emp = res.Content.ReadAsAsync<Employee>().Result;
                txtID.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtAge.Text = emp.Age.ToString();
                txtSalary.Text = emp.Salary.ToString();
                txtDept.Text = emp.DeptId.ToString();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var emp = new Employee
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Salary = decimal.Parse(txtSalary.Text),
                DeptId = int.Parse(txtDept.Text)
            };
            var res = client.PutAsJsonAsync($"http://localhost:1313/api/employee/{txtID.Text}", emp).Result;
            if (res.IsSuccessStatusCode)
            {
                msgTxt.Text = "Employee Updated Successfully";
                FillEmployeeGridView();
                txtID.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtSalary.Text = "";
                txtDept.Text = "";
            }
            else
            {
                MessageBox.Show(res.ReasonPhrase + " " + res.StatusCode);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var res = client.DeleteAsync($"http://localhost:1313/api/employee/{txtID.Text}").Result;
            if (res.IsSuccessStatusCode)
            {
                msgTxt.Text = "Employee Deleted Successfully";
                FillEmployeeGridView();
                FillEmployeeComboBox();
                txtID.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtSalary.Text = "";
                txtDept.Text = "";

            }
            else
            {
                MessageBox.Show(res.ReasonPhrase + " " + res.StatusCode);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1313/");
            var emp = new Employee
            {
                Id = int.Parse(txtID.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Salary = decimal.Parse(txtSalary.Text),
                DeptId = int.Parse(txtDept.Text)
            };
            var result = client.PostAsJsonAsync("api/employee", emp).Result;
            if (result.IsSuccessStatusCode)
            {
                msgTxt.Text = "Employee Added Successfully";
                FillEmployeeGridView();
                txtID.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                txtSalary.Text = "";
                txtDept.Text = "";
            }
            else
            {
                MessageBox.Show(result.ReasonPhrase + " " + result.StatusCode);
            }
        }
    }
}
