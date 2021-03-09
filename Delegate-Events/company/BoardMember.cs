using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.resigned });
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.resigned)
                base.OnEmployeeLayOff(e);
        }
    }
}
