using System;
using Lab01._01.Context;
using Lab01._01.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab01._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }

        PubsContext Context = new PubsContext();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jobI = comboBox1.SelectedValue.ToString();
            if (Int32.TryParse(jobI, out int selectedJob))
            {
                //var temp = Context.Employees.Where(x => x.JobId == Convert.ToInt16(jobI));

                var Results = (from emp in Context.Employees
                               join job in Context.Jobs
                               on emp.JobId equals job.JobId
                               where emp.JobId == Convert.ToInt16(jobI)
                               select new
                               {
                                   emp.Fname,
                                   emp.Minit,
                                   emp.Lname,
                                   emp.HireDate,
                                   job.JobDesc,
                                   job.MinLvl,
                                   emp.JobLvl
                               }
                                      ).ToList();

                dataGridView1.DataSource = Results;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Jobs.Load();
            comboBox1.DataSource = Context.Jobs.Local.ToBindingList();
            comboBox1.DisplayMember = "JobDesc";
            comboBox1.ValueMember = "JobId";
        }
    }
}