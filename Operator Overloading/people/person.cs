using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    class Person
    {
        public string Fname { set; get; }
        public string Lname { set; get; }
        public double Salary { set; get; }
        public double Commossion { set; get; } 
        public Person() { }
        public Person(string _Fname, string _Lname, double _Salary)
        {
            Fname = _Fname;
            Lname = _Lname;
            Salary = _Salary;
            Commossion = 0.25 * Salary;
        }
        public override string ToString()
        {
            return $"first name: {Fname}, last name: {Lname}, Salary: {Salary}, Commosion: {Commossion}";
        }
        public static explicit operator Student(Person person)
        {
            return new Student
            {
                FullName = $"{person.Fname} {person.Lname}",
                NetSalary = person.Salary + person.Commossion
            };
        }
    }
}
