using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyModel Database = new CompanyModel();
            #region insert
            ////insert department
            //Department D01
            //    = new Department { DeptName = "System Development" };
            //Department D02
            //    = new Department { DeptName = "Graphics" };
            //Department D03
            //    = new Department { DeptName = "Gaming" };
            //Department D04
            //    = new Department { DeptName = "Math" };

            //Database.Departments.AddRange(new Department[] { D01, D02, D03, D04 });

            ////Save changes to database
            //Database.SaveChanges();

            ////insert employees
            //var userDept = Database.Departments.FirstOrDefault(dept => dept.DeptName.ToLower() == "graphics");

            //Employee E01 = new Employee { Name = "Somaya", Age = 22, Salary = 15_999, DepartmentId = 1, Address = "Rome" };
            //Employee E02 = new Employee { Name = "Anas", Age = 25, Salary = 9777, Department = userDept, Address = "Tallin" };
            //Employee E03 = new Employee { Name = "Asem", Age = 26, Salary = 19_000, DepartmentId = 4, Address = "Triesta" };
            //Employee E04 = new Employee { Name = "Sarah", Age = 23, Salary = 29_752, Department = userDept, Address = "Paris" };
            //Employee E05 = new Employee { Name = "Moftah", Age = 24, Salary = 20_000, DepartmentId = 3, Address = "Canada" };
            //Employee E06 = new Employee { Name = "Zaher", Age = 21, Salary = 23_000, DepartmentId = 1, Address = "LA" };

            //Database.Employees.AddRange(new Employee[] { E01, E02, E03, E04, E05, E06 });

            ////Save changes to database
            //Database.SaveChanges(); 
            #endregion

            #region update
            ////update department
            //var D01 = Database.Departments.FirstOrDefault(dept => dept.DepartmentId == 4);
            //D01.DeptName = "Number Theory";

            ////update employee
            //var E01 = Database.Employees.SingleOrDefault(Emp => Emp.Id == 2);
            //E01.Salary = 29_000.80M;
            //Database.SaveChanges();
            #endregion

            #region delete
            //delete employee
            //Database.Employees.Remove(Database.Employees.SingleOrDefault(Emp => Emp.Id == 6));
            //Database.SaveChanges();

            //delete depatement
            //Database.Departments.Remove(Database.Departments.SingleOrDefault(Dept => Dept.DepartmentId == 2));
            //Database.SaveChanges();
            #endregion

            #region Select
            var Q01 = Database.Employees.ToList();
            var Q02 = from item in Database.Employees
                      where item.Age > 22
                      orderby item.Name
                      select item;
            foreach (var item in Q02)
            {
                Console.WriteLine(item.Name);
            }
            var Q03 = Database.Employees.Where(Emp => Emp.Age > 22).Select(ww => new { ww.Id, ww.Name });
            #endregion
        }
    }
}
