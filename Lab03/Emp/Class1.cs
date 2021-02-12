using System;
using EmployeeNS;
using static EmployeeNS.Employee;

namespace Emp
{
    class Swap
    {
        public static void Swaping(ref Employee emp1, ref Employee emp2)
        {
            Employee temp;
            temp = emp1;
            emp1 = emp2;
            emp2 = temp;
        }
    }
}
