using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab05.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Display(Name = "Depatment")]
        public string DeptName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        = new HashSet<Employee>();
    }
}