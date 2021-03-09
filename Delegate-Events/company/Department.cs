using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += RemoveStaff;
            Staff?.Add(E);
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,
        EmployeeLayOffEventArgs e)
        {
            if (sender is Employee E)
            {
                //remove from list
                Staff.Remove(E);
                E.EmployeeLayOff -= RemoveStaff;
            }
        }
        public override string ToString()
        {
            StringBuilder emps = new StringBuilder();
            foreach (Employee e in Staff)
            {
                emps.Append(e?.EmployeeID).Append("  ");
            }
            return emps.ToString();
        }
    }
}