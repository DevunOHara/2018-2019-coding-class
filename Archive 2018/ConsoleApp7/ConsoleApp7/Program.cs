using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Answer = 1;
            int SelectedSeat = 0;
            Random rand = new Random();
            int[] seats = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1};

            while (Answer != 0) ;
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Answer = int.Parse(Console.ReadLine());
                Console.WriteLine();
             
                switch (Answer)
                {
                    case 1:
                        bool foundseat = false;

                        while (foundseat == false)
                        {
                            SelectedSeat = rand.Next(0,10); 
                            if (seats[SelectedSeat] == -1)
                            {
                                seats[SelectedSeat] = 1;
                                foundseat = true;
                            }
                        }

                    break;
                }
            }
        }
    }
}