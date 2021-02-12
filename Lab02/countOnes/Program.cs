//•	How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) and total up how many 1s were there.
//string tryM = "Somaya".Substring(1, 2);
//8 sec 

using System;
using System.Diagnostics;

namespace countOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch newTimer = new Stopwatch();
            newTimer.Start();

            int count = 0;
            for (int i = 0; i < 99_999_999; i++)
            {
                string number = i.ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] == '1') count++;
                }
            }

            newTimer.Stop();
            Console.WriteLine($"the time the opertion took to count {newTimer.Elapsed}");
            Console.WriteLine($"the number of one's {count}");
        }
    }
}
