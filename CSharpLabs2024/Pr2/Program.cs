using System;

namespace Pr2
{
    class Program
    {
        const int N = 10 + 1;

        static void Main(string[] args)
        {
            //Task1();
            Task2();
            //Task3();
            //Task4();
        }

        static void Task1()
        {
            int[] numbers = { 4, 6, 12 };

            Console.Write("Numbers: [ ");
            foreach (int elem in numbers)
            {
                Console.Write($"{elem} ");
            }

            Console.WriteLine("]");

            Console.Write($"Numbers that are in range of [1;{N}]: [ ");
            foreach (int elem in numbers)
            {
                if (elem >= 1 && elem <= N)
                {
                    Console.Write($"{elem} ");
                }
            }

            Console.WriteLine("]");
        }

        static void Task2()
        {
            int side1 = 7;
            int side2 = 7;
            int side3 = 12;

            if (IsTriangle(side1, side2, side3))
            {
                double area = Area(side1, side2, side3);
                int perimetr = Perimetr(side1, side2, side3);
                string triangleType = TriangleType(side1, side2, side3);

                Console.WriteLine($"Perimetr of triangle: {perimetr}");
                Console.WriteLine($"Area of triangle: {area}");
                Console.WriteLine($"Type of triangle: {triangleType}");
            }
            else
            {
                Console.WriteLine("Triangle doesn't exist.");
            }

           

            static bool IsTriangle(int side1, int side2, int side3)
            {
                return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
            }

            static int Perimetr(int side1, int side2, int side3)
            {
                return side1 + side2 + side3;
            }

            static double Area(int side1, int side2, int side3)
            {
                double s = (side1 + side2 + side3) / 2.0;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            }

            static string TriangleType(int side1, int side2, int side3)
            {
                if (side1 == side2 && side2 == side3)
                {
                    return "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            
        }

    }
}

