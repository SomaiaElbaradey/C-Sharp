using System;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                vacationStock = 10,
                birthDate = new DateTime(1994, 2, 2), //to not to fire the event
                EmployeeID = 1
            };
            Employee e2 = new Employee()
            {
                vacationStock = 14,
                birthDate = new DateTime(1990, 3, 8),
                EmployeeID = 2
            };
            SalesPerson s1 = new SalesPerson()
            {
                vacationStock = 10,
                birthDate = new DateTime(1991, 7, 4),
                EmployeeID = 3,
                AchievedTarget = 500
            };
            SalesPerson s2 = new SalesPerson()
            {
                vacationStock = 10,
                EmployeeID = 4,
                AchievedTarget = 700
            };
            BoardMember b1 = new BoardMember()
            {
                vacationStock = 10,
                birthDate = new DateTime(1994, 2, 2), //to not to fire the event
                EmployeeID = 5
            };
            BoardMember b2 = new BoardMember()
            {
                vacationStock = 14,
                birthDate = new DateTime(1990, 3, 8),
                EmployeeID = 7
            };
            Department salesDept = new Department()
            {
                DeptID = 1,
                DeptName = "Marketing"
            };
            Club c = new Club()
            {
                ClubID = 1,
                ClubName = "Aljazira"
            };

            /*salesDept.AddStaff(e1);
            salesDept.AddStaff(e2);
            Console.WriteLine($"IDs of Employees in Dept: {salesDept}");
            e1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(15)); //vacation
            e2.BirthDate = new DateTime(1000, 2, 3); //age
            Console.WriteLine($"IDs of Employees in Dept: {salesDept}");
            */
            /*c.AddMember(e2);
            c.AddMember(e1);
            Console.WriteLine($"IDs of Employees in Club: {c}");
            e1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(15)); //vacation
            e2.BirthDate = new DateTime(1000, 2, 3); //age
            
            Console.WriteLine($"IDs of Employees in Club: {c}");*/

            /*salesDept.AddStaff(s1);
            salesDept.AddStaff(s2);
            Console.WriteLine($"IDs of Salesmen in Dept: {salesDept}");
            s1.CheckTarget(900);
            s2.VacationStock = 20;
            Console.WriteLine($"IDs of Salesmen in Dept: {salesDept}");*/

            /*salesDept.AddStaff(b1);
            salesDept.AddStaff(b2);
            b1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(15)); //vacation
            b2.BirthDate = new DateTime(1960, 2, 3); //age
            b1.Resign();
            Console.WriteLine($"IDs of Employees in Dept: {salesDept}");*/

        }
    }
}