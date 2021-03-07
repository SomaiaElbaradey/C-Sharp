using System;
using System.Collections.Generic;
using System.Text;

namespace point
{
    class Calculator
    {
        public static double add(double num1, double num2)
        {
            return Math.Round(num1 + num2, 2);
        }
        public static double sub(double num1, double num2)
        {
            return Math.Round(num1 - num2, 2);
        }
        public static double multiply(double num1, double num2)
        {
            return Math.Round(num1 * num2, 2);
        }
        public static double divide(double num1, double num2)
        {
            return Math.Round(num1 / num2, 2);
        }
    }
}
