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
            int Answer = 0;
            while (Answer != 10)
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine(" 1 - Small Square");
                Console.WriteLine(" 2 - 3x3 Square");
                Console.WriteLine(" 3 - 5x4 Square");
                Console.WriteLine(" 4 - Leftward Triangle");
                Console.WriteLine(" 5 - Rightward Triangle");
                Console.WriteLine(" 6 - Pyramid Shape");
                Console.WriteLine(" 7 - / Through Square");
                Console.WriteLine(" 8 - \\ Through Square");
                Console.WriteLine(" 9 - X Through Square");
                Console.WriteLine(" 10 - Exit Menu");
                Console.WriteLine("**************************");
                Console.Write("Enter Number: ");
                Answer = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (Answer)
                {
                    case 1:
                        //Small Square
                        Console.WriteLine("X");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 2:
                        //3x3 Square
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 3:
                        //5 x 4 Square
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 4:
                        //Leftward Triangle
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 5:
                        //Rightward Triangle
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
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 6:
                        //Pyramid
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
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 7:
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
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 8:
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
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;

                    case 9:
                        // X Through Square

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
                        Console.WriteLine("Press Enter To Clear Shape.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Bye!");
            Console.WriteLine();
        }
    }
}