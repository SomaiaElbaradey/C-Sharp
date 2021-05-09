using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

    }
}
