using System;

namespace Pr2
{
    class Program
    {
        const int N = 10 + 1;

        static void Main(string[] args)
        {
            Task1();
            //Task2();
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


    }
}

