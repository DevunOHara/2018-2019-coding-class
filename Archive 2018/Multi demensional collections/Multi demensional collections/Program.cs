using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_demensional_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //2d Array
            int[,] multiDimensionalArray = new int[10, 5];
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }
            }
            Print2dArray(multiDimensionalArray);
            
            //Jagged 2D Array
            int[][] jaggedarray = new int[10][];
            for (int i = 0; i < jaggedarray.GetLength(0); i++)
            {
                jaggedarray[i] = new int[i + 1];
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    jaggedarray[i][j] = i * j;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            PrintjaggedArray(jaggedarray);
            Console.ReadKey();
        }
        //Print 2D Array
        static void Print2dArray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("| " + x[1, j] + " ");
                }
                Console.WriteLine(" ");
            }


        }
        //Print 2D Jagged Array
        static void PrintjaggedArray(int[][] y)
        {
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    Console.Write("| " + y[i][j] + " |");
                }
                Console.WriteLine(" ");
            }

        }
    }

}