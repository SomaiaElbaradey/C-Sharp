using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Models
{
    public class Employee
    {
        [Display(Name = "SSN")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Name Is Required.")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Range(15, 90, ErrorMessage = "Age Must Be Between 16 And 90")]
        public int? Age { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You Must Enter Password!")]
        public string Password { get; set; }
        [Display(Name = "Confirmed Password")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and Confirmed Password Don't Match")]
        [NotMapped]
        public string ConfirmedPass { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        [Remote("EmailExists", "Employee", ErrorMessage = "Email Already Exists!")]
        public string Email { get; set; }
        [Display(Name = "Date Of Birth")]
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Hire Date")]
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}