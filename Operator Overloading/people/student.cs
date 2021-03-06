using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    class Student
    {
        public string FullName { set; get; }
        public double NetSalary { set; get; }
        public Student () { }
        public Student(string _FullName, double _NetSalary)
        {
            FullName = _FullName;
            NetSalary = _NetSalary;
        }
        public override string ToString()
        {
            return $"Full Name: {FullName}, Net Salary: {NetSalary}";
        }
        public static explicit operator Person(Student student)
        {
            string[] nameArray = student.FullName.Split(' ');
            return new Person(_Fname: nameArray[0], _Lname: nameArray[1], _Salary: 0.8 * student?.NetSalary ?? 0);
        }
    }
}
