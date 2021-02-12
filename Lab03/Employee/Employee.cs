using System;

namespace EmployeeNS
{
    public struct Employee
    {
        public enum Gender { M = 0, Male = 0, F = 1, Female = 1 }

        //Short Hand for set and get
        public int ID { get; set; }
        public string SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public Gender EmpGender { get; set; }
        public HiringDate HireDate { set; get; }
        public Employee (int _ID, string _SercurityLevel, decimal _Salary, Gender _EmpGender, HiringDate _HireDate)
        {
            ID = _ID;
            Salary = _Salary;
            EmpGender = _EmpGender;
            SecurityLevel = _SercurityLevel;
            HireDate = _HireDate;
        }

        public override string ToString()
        {
            return string.Format("{0:C}", Salary);
        }

    }
}
