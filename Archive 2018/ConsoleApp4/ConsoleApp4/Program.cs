using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            // X
            Console.WriteLine("X");
            Console.WriteLine();

            // 3x3 X
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 5 x 4 X
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Leftward Triangle
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Rightward triangle
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (3 - j >= i)
                        Console.Write(" ");
                    else
                        Console.Write("X");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Pyramid
            //int s = 3;
            int m = 3 / 2 + 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j >= m - i && j <= m + i)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // \ Through Square
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == i)
                        Console.Write(" ");
                    else
                        Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // / Through Square
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (4 - j == i)
                        Console.Write(" ");
                    else
                        Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (4 - j == i || j == i)
                        Console.Write(" ");
                    else
                        Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}