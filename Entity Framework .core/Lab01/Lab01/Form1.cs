using System;
using Lab01.Context;
using Lab01.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab01
{
    public partial class Form1 : Form
    {
        PubsContext Context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }
        public void FillData() 
        {
            Context.Employees.Load();
            Context.Jobs.Load();
            dataGridView1.DataSource = Context.Employees.Local.ToBindingList();
            selectedComboBox.DataSource = Context.Employees.Local.ToBindingList();
            selectedComboBox.DisplayMember = "Fname";
            selectedComboBox.ValueMember = "EmpId";
            newJob.DataSource = Context.Jobs.Local.ToBindingList();
            newJob.DisplayMember = "JobDesc";
            newJob.ValueMember = "JobId";
        }
        private void selectedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var empId = selectedComboBox.SelectedValue.ToString();
            if (empId != null)
            {
                try
                {
                    var employee = (from emp in Context.Employees
                                    where emp.EmpId == empId
                                    select emp).FirstOrDefault();
                    if (employee != null)
                    {
                        editFname.Text = employee.Fname;
                        editMid.Text = employee.Minit;
                        editJob.Text = employee.JobId.ToString();
                        editJobLevel.Text = employee.JobLvl.ToString();
                        editHire.Text = employee.HireDate.ToString();
                        editPublisher.Text = employee.PubId;
                        editLname.Text = employee.Lname;
                    }
                }
                catch
                {
                    MessageBox.Show("Unknown Error!", "Err");
                }
            }
            else MessageBox.Show("You've selected empty data! please try again.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee();
                employee.EmpId = newSSN.Text;
                employee.Fname = newFname.Text;
                employee.Minit = newMid.Text;
                employee.Lname = newLname.Text;
                employee.PubId = newPublisher.Text;

                bool isJob = Byte.TryParse(newJob.SelectedValue.ToString(), out byte job);
                employee.JobId = job;

                bool isJobLevl = Byte.TryParse(newJobLevel.Text, out byte jobLevel);
                employee.JobLvl = jobLevel;

                employee.HireDate = newHire.Text != "" ? Convert.ToDateTime(newHire.Text) : DateTime.Now;
                Context.Employees.Add(employee);
                Context.SaveChanges();

                FillData();
            }
            catch (Exception err)
            {
                MessageBox.Show("Unknown Error.", "Err");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var empId = selectedComboBox.SelectedValue.ToString();
            if (empId != null)
            {
                try
                {
                    var employee = Context.Employees.Find(empId);
                    employee.Fname = editFname.Text;
                    employee.Lname = editLname.Text;
                    employee.Minit = editMid.Text;
                    employee.PubId = editPublisher.Text;

                    bool isJob = Byte.TryParse(editJob.Text, out byte job);
                    employee.JobId = job;

                    bool isJobLevl = Byte.TryParse(editJobLevel.Text, out byte jobLevel);
                    employee.JobLvl = jobLevel;

                    employee.HireDate = editHire.Text != "" ? Convert.ToDateTime(editHire.Text) : DateTime.Now;

                    Context.SaveChanges();
                    FillData();

                    //this.InitializeComponent();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Unknown Error!", "Err");
                }
            }
            else MessageBox.Show("You've selected empty data! please try again.", "Error!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var empId = selectedComboBox.SelectedValue.ToString();

                    if (empId != "")
                    {
                        var employee = Context.Employees.Find(empId);
                        Context.Employees.Remove(employee);
                        Context.SaveChanges();
                        FillData();

                        //this.InitializeComponent();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Unknown Error!", "Error");
                }
            }
        }
    }
}
