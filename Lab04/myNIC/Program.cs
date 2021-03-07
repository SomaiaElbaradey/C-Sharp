using System;

namespace myNIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //NIC card = new NIC(); //not allowed
            NIC card01 = NIC.oneInstance;
            NIC card02 = NIC.oneInstance;
            Console.WriteLine($"Hash Code of card01: {card01.GetHashCode()}");
            Console.WriteLine($"Hash Code of card02: {card02.GetHashCode()}");
            Console.WriteLine($"Card01: {card01}");
            Console.WriteLine($"Card02: {card02}");
        }
    }
}
