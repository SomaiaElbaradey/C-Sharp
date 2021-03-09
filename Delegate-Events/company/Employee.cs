using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    class Employee
    {
        public DateTime birthDate;
        public int vacationStock;
        public int EmployeeID { get; set; }

        //1- decalre the event(delegation > pointer to list of arrays)
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        //4- notify the sub by invokation
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public DateTime BirthDate
        {
            //calculate the age and if > 60 fire the event
            get => birthDate;
            //don't allow to set if age > 60
            set
            {
                if ((DateTime.Now.Year - value.Year) > 60)
                    //Now notify
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.age });
                else birthDate = value;
            }
        }
        public int VacationStock
        {
            get => vacationStock;
            set
            {
                if (vacationStock - value < 0)
                    //Now notify
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.vacationStock });
                else
                    vacationStock = vacationStock - value;
            }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int duration = (To.Subtract(From)).Days;
            if (VacationStock - duration >= 0)
            {
                VacationStock -= duration;
                return true;
            }
            else
            {
                //Now notify
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.vacationStock });
                return false;
            }
        }
        public void EndOfYearOperation()
        {
            if (DateTime.Now.Year - birthDate.Year <= 60)
                //fire the event
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.age });
        }
    }
}
