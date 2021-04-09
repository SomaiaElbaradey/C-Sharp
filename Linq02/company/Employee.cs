using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        //lazy loading 
        public virtual Department Department { get; set; }
    }
}
