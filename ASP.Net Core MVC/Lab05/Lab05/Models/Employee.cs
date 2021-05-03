using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab05.Models
{
    public class Employee
    {
        [Display(Name = "SSN")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Name Is Required.")]
        public string FName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        [Remote("EmailExists", "Employee", ErrorMessage = "Email Already Exists!")]
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}