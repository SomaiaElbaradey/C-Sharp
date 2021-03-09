using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    enum LayOffCause
    { age, vacationStock, target, resigned }

    class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
