using System;
using System.Collections.Generic;

#nullable disable

namespace APICoreIsmalia.Models
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Loc { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
