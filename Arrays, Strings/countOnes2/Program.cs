//Using Only Mathematical Functions and Numeric values find number of ones
using System;
using System.Diagnostics;
using System.Linq;

namespace countOnes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the time in ms the opertion1 took to count: {TimeMethod(count1)}");
            Console.WriteLine($"the time in ms the opertion2 took to count: {TimeMethod(count2)}");

            static long TimeMethod(Action methodToTime)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                methodToTime();
                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds;
            }

            static void count1()
            {
                int count = 0;
                for (int i = 0; i < 99_999_999; i++)
                {
                    int number = i;
                    for (int j = 0; j < Math.Ceiling(Math.Log10(i) + 1); j++)
                    {
                        if (number % 10 == 1) count++;
                        number /= 10;
                    }
                }
                Console.WriteLine($"the number of one's using mathmatical loops: {count}");
            }


            //other way 
            //suppose the 1 digit has only one, two digits has 20 ones, three digits has 300 ones, four digit has 40000 ones so on..
            //so count can be calculated as: digits * 10 ^ (digits - 1)
            static void count2()
            {
                int count2 = 8 * Convert.ToInt32(Math.Pow(10, 7));
                Console.WriteLine($"the number of one's depending on digits number: {count2}");
            }
        }
    }
}
