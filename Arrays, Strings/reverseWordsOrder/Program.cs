using System;

namespace reverseWordsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your string");
            string input = Console.ReadLine();
            string[] splitedInput = input.Split(" ");
            Array.Reverse(splitedInput);
            string theOutput = String.Join(" ", splitedInput);
            Console.WriteLine($"the output: {String.Concat(theOutput)}");

        }
    }
}
