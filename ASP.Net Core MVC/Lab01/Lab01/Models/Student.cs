using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Student() { }
        public override string ToString()
        {
            return $"{Fname} {Lname}. Age: {Age}, lives in: {Address}";
        }
    }
}