using System;

namespace duration
{
    class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine($"D1: {D1.ToString()}");

            Duration D2 = new Duration(3600);
            Console.WriteLine($"D2: {D2.ToString()}");

            Duration D3 = new Duration(7800);
            Console.WriteLine($"D3: {D3.ToString()}");

            Console.WriteLine($"D3++: {D3++}");
            Console.WriteLine($"D3: {D3}");

            Console.WriteLine($"++D3: {++D3}");
            Console.WriteLine($"--D3: {--D3}");

            Console.WriteLine($"D3--: {D3--}");
            Console.WriteLine($"D3: {D3}");

            Duration D4 = new Duration(666);
            Console.WriteLine($"D4: {D4.ToString()}");

            Duration D5 = D1 + D2;
            Console.WriteLine($"D1 + D2: {D5}");

            Duration D6 = D1 + 7800;
            Console.WriteLine($"D1 + 7800: {D6}");

            Duration D7 = 666 + D3;
            Console.WriteLine($"D3 + 666: {D7}");

            Duration D8 = new Duration(0, -12, -10000);
            Console.WriteLine($"D8: {D8.ToString()}");

            Duration D9 = new Duration(0, 12, 10000);
            Console.WriteLine($"D9: {D9.ToString()}");

            Duration D10 = --D9;
            Console.WriteLine($"D10 = --D9: {D10}");

            Console.WriteLine($"D1 > D2: {D1 > D2}");
            Console.WriteLine($"D1 < D2: {D1 < D2}");
            Console.WriteLine($"D1 >= D2: {D1 >= D2}");
            Console.WriteLine($"D1 <= D2: {D1 <= D2}");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine($"date time D1 to obj: {Obj}");

            Duration D11 = new Duration(600);
            Duration D12 = new Duration(0, 10, 0);
            Console.WriteLine($"D11.Equals(D12): {D11.Equals(D12)}");

            ////if(D1);
            //Duration D11 = -D10;
        }
    }
}