using System;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 3
            Point3D point = new Point3D(10, 5, 15);
            Console.WriteLine(point);

            Point3D[] points = new Point3D[2];
            double _x, _y, _z;
            for (int i = 0; i < points?.Length; i++)
            {
                int flagX;
                int flagY;
                int flagZ;

                points[i] = new Point3D();
               
                do
                {
                    try
                    {
                        flagX = 0;
                        Console.WriteLine($"X position for point {i + 1}");
                        _x = Convert.ToDouble(Console.ReadLine());
                        points[i].X = _x;
                    }
                    catch (Exception ex)
                    {
                        flagX = 1;
                        Console.WriteLine($"Error {ex.Message}, Please Try Again!");
                    }
                } while (flagX == 1);


                do
                {
                    try
                    {
                        flagY = 0;
                        Console.WriteLine($"Y position for point {i + 1}");
                        _y = double.Parse(Console.ReadLine());
                        points[i].Y = _y;
                    }
                    catch (Exception ex)
                    {
                        flagY = 1;
                        Console.WriteLine($"Error {ex.Message}, Please Try Again!");
                    }
                } while (flagY == 1);
                do
                {
                    flagZ = 0;
                    Console.WriteLine($"Z position for point {i + 1}");
                    if (!double.TryParse(Console.ReadLine(), out _z))
                    {
                        flagZ = 1;
                        Console.WriteLine("NAN, Please Try Again!");
                    }
                    points[i].Z = _z;
                } while (flagZ == 1);
                
            }
            Console.Clear();
            Console.WriteLine($"user points:");
            Console.WriteLine($"P1: {points[0]}");
            Console.WriteLine($"P2: {points[1]}");

            //==, != 
            Console.WriteLine("***********************************");
            Point3D p1 = new Point3D(1, 1, 1);
            Point3D p2 = new Point3D(1, 1, 1);
            Point3D p3 = new Point3D(10, 1.5, 1);
            Console.WriteLine($"P1:{p1}");
            Console.WriteLine($"P2:{p2}");
            Console.WriteLine($"P3:{p3}");
            if (p1 == p2) Console.WriteLine("Points P1 and P2 are equal");
            if (p1 != p3) Console.WriteLine("Points P1 and P3 are not equal");

            //sort
            Console.WriteLine("***********************************");
            Point3D[] points01 ={
                new Point3D{X = 12, Y = 9.9, Z = 7.3},
                new Point3D{X = 1.2, Y = 12.5, Z = 19.2},
                new Point3D{X = 3.6, Y = 0, Z = 1.9},
            };
            Console.WriteLine("un Sorted array:");
            foreach (var item in points01)
            {
                Console.WriteLine(item);
            }
            Array.Sort(points01);
            Console.WriteLine("Sorted array:");
            foreach (var item in points01)
            {
                Console.WriteLine(item);
            }

            //cloning
            Console.WriteLine("***********************************");
            Point3D point04 = new Point3D(12, 10, 15);
            Point3D point05 = (Point3D)point04.Clone();
            Console.WriteLine($"Cloning P4:{point04} to Point5: {point05}");

            ///calc
            Console.WriteLine("***********************************");
            Console.WriteLine("My Calculator");
            Console.WriteLine($"Add 12 to 15.5: {Calculator.add(12, 15.5)}");
            Console.WriteLine($"Subtract 12 from 15.5: {Calculator.sub(12, 15.5)}");
            Console.WriteLine($"Multiply 12 by 15.5: {Calculator.multiply(12, 15.5)}");
            Console.WriteLine($"Divide 12 by 15.5: {Calculator.divide(12, 15.5)}");
        }
    }
}
