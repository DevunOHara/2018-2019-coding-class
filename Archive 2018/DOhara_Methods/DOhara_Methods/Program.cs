using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        //3x3 Square
        static void xy(int X, int Y)
        {
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("input x value");
            x = int.Parse(Console.ReadLine());
            int y;
            Console.WriteLine("input y value");
            y = int.Parse(Console.ReadLine());
            xy(x, y);
        }
    }
}
