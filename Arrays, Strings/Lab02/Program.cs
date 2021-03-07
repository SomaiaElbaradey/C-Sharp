using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size;
            Console.WriteLine("please enter the size of your array");
            Size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[Size];
            for ( int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"please enter cell number {i}");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max, firstCell, secondCell;
            max = firstCell = secondCell = 0;
            for ( int i = 0; i < Arr.Length; i++ )
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    firstCell = i;
                    if (Arr[i] == Arr[j])
                    {
                        secondCell = j;
                        if (secondCell - firstCell > max) max = secondCell - firstCell;
                    }
                }
            }

            Console.WriteLine($"the max number of cells is: {max - 1} btween two {Arr[secondCell-1]}s");
        }
    }
}
