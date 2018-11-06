using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            int answer = 0;
            Console.WriteLine("*****************");
            Console.WriteLine("1. Add 5 + 6 ");
            Console.WriteLine("2. Add 11 + 13 ");
            Console.WriteLine("3. Add 3 + 9 ");
            Console.WriteLine("4. Exit Menu ");
            Console.WriteLine("*****************");
            Console.Write("Enter Number: ");
            Console.WriteLine();
            answer = int.Parse (Console.ReadLine());

            while (answer !=4)
            {
                switch (answer)
                {
                    case 1:
                        AddFiveSix();
                        break;

                    case 2:
                        AddElevenThirteen();
                        break;

                    case 3:
                        AddThreeNine();
                        break;

                }
            }
        }
    }
}