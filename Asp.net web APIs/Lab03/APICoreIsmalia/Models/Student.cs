using System;
using System.Collections.Generic;

#nullable disable

namespace APICoreIsmalia.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public int? Deptid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Img { get; set; }
        public string Cv { get; set; }

        public virtual Department Dept { get; set; }
    }
}
