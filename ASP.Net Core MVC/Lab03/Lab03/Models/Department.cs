using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab03.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}