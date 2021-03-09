using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    class SalesPerson:Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                //Fire the event
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.target });
                return false;
            }
            return true;
        }
        //override to prevent event from firing in case of any cause except target
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.target || e.Cause == LayOffCause.age)
                base.OnEmployeeLayOff(e);
        }
    }
}
