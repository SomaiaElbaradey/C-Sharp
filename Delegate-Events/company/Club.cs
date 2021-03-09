using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += RemoveMember;
            Members.Add(E);
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
            if (sender is Employee E && (e.Cause == LayOffCause.vacationStock || e.Cause == LayOffCause.target))
            {
                //remove from list
                Members.Remove(E);
                E.EmployeeLayOff -= RemoveMember;
            }
        }
        public override string ToString()
        {
            StringBuilder emps = new StringBuilder();
            foreach (Employee e in Members)
            {
                emps.Append(e?.EmployeeID).Append("  ");
            }
            return emps.ToString();
        }
    }
}
