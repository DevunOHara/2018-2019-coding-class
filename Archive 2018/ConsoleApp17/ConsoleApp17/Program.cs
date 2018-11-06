using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            Random rand = new Random();

            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray = new int[10];
                Console.WriteLine(myIntArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            List<int> myIntList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(rand.Next());
                Console.Write(myIntList[i] + ".");
            }
            Console.WriteLine();
        }
    }
}