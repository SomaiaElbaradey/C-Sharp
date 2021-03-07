using EmployeeNS;
using System;
using static EmployeeNS.Employee;

namespace Emp
{
    class Program
    {
        static void BubbleSort(Employee[] emp)
        {
            int sorted = 0;
            for (int i = 0; i < emp?.Length - 1 && sorted == 0; i++)
            {
                sorted = 1;
                for (int j = 0; j < emp?.Length - i - 1; j++)
                {
                    if (emp[j].HireDate.Year > emp[j + 1].HireDate.Year)
                    {
                        Swap.Swaping(ref emp[j], ref emp[j + 1]);
                        sorted = 0;
                    }
                    if (emp[j].HireDate.Year == emp[j + 1].HireDate.Year)
                    {
                        if (emp[j].HireDate.Month > emp[j + 1].HireDate.Month)
                        {
                            Swap.Swaping(ref emp[j], ref emp[j + 1]);
                            sorted = 0;
                        }
                        if (emp[j].HireDate.Month == emp[j + 1].HireDate.Month)
                        {
                            if (emp[j].HireDate.Day > emp[j + 1].HireDate.Day)
                            {
                                Swap.Swaping(ref emp[j], ref emp[j + 1]);
                                sorted = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("your Employees Sorted to the hiring dat:");
            for (int i = 0; i < emp?.Length; i++)
            {
                Console.WriteLine(emp[i].HireDate.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Employee Number");
            int EmpNo = Convert.ToInt32(Console.ReadLine());
            Employee[] EmpArr = new Employee[EmpNo];
            for (int i = 0; i < EmpArr?.Length; i++)
            {
                Console.WriteLine($"Enter the ID of Employe { i + 1 }");
                EmpArr[i].ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the Security Level of Employe { i + 1 }");
                EmpArr[i].SecurityLevel = Convert.ToString(Console.ReadLine());
                string Str;
                int Day, Month, Year;
                do
                {
                    Console.WriteLine($"Enter the Gender of Employe { i + 1 }");
                    Str = Convert.ToString(Console.ReadLine());
                } while (!Enum.IsDefined(typeof(Gender), Str));
                EmpArr[i].EmpGender = (Gender)Enum.Parse(typeof(Gender), Str);

                Console.WriteLine($"Enter the Salary of Employe { i + 1 }");
                EmpArr[i].Salary = Convert.ToDecimal(Console.ReadLine());
                do
                {
                    Console.WriteLine($"Enter the Day of Hiring Employe { i + 1 }");
                    Day = Convert.ToInt32(Console.ReadLine());
                } while (Day > 30 || Day < 0);
                do
                {
                    Console.WriteLine($"Enter the Month of Hiring Employe { i + 1 }");
                    Month = Convert.ToInt32(Console.ReadLine());
                } while (Month > 12 || Month < 0);
                do
                {
                    Console.WriteLine($"Enter the Year of Hiring Employe { i + 1 }");
                    Year = Convert.ToInt32(Console.ReadLine());
                } while (Year > 2021 || Year < 0);
                EmpArr[i].HireDate = new HiringDate(Day, Month, Year);
            }
            //could use the DateTime, easier but wanted to try it mannually.
            //DateTime d = new DateTime(1999, 1, 30);
            //DateTime d2 = new DateTime(1999, 1, 1);
            //Console.WriteLine(d > d2);
            Console.Clear();
            BubbleSort(EmpArr);
        }
    }
}
