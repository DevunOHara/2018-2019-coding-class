using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != 5)
            {
                Console.Clear();
                Console.WriteLine("           Menu");
                Console.WriteLine("Enter one of the following");
                Console.WriteLine("  by entering the number.");
                Console.WriteLine();
                Console.WriteLine("1 - Conditionals");
                Console.WriteLine("2 - For Loops");
                Console.WriteLine("3 - While Loops");
                Console.WriteLine("4 - Arrays");
                Console.WriteLine("5 - Lists");
                Console.WriteLine("6 - Exit Program");
                answer = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (answer)
                {
                    case 1:
                        {
                            int gl = 0;
                            int rgl = 0;
                            string result = Console.ReadLine();

                            Console.WriteLine("Enter your grade level from 1-12.");
                            gl = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Enter your reading grade level from 1-12.");
                            rgl = int.Parse(Console.ReadLine());

                            if (gl == 12 && rgl == 12)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in High school and proficiant in reading!");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 11 && rgl >= 11)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in High school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 11 && rgl < 11)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 10 && rgl >= 10)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in High school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 10 && rgl < 10)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 9 && rgl >= 9)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in High school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 9 && rgl < 9)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 8 && rgl >= 8)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Middle school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 8 && rgl < 8)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 7 && rgl >= 7)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Middle school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 7 && rgl < 7)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 6 && rgl >= 6)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Middle school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 6 && rgl < 6)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 5 && rgl >= 5)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Elementary school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 5 && rgl < 5)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 4 && rgl >= 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Elementary school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 4 && rgl < 4)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 3 && rgl >= 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Elementary school and proficiant in reading!");
                            }
                            else if (gl == 3 && rgl < 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 2 && rgl >= 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Elementary school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 2 && rgl < 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }

                            if (gl == 1 && rgl >= 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are in Elementary school and proficiant in reading!");
                            }
                            else if (result.ToLower()[0] == 1 && rgl < 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You are not proficiant in reading.");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to choose another option from the menu");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("O O O O");

                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to choose another option from the menu");
                        Console.ReadKey();
                        break;

                    case 3:
                        string[] title = new string[] { "ghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseaghhfgshfghuoghghsduigfsgisgguihuighsuhguhguihuigwruihguieafgegfyaegffgeqyuigluigeuigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuiseauigfuiafguheauighuieahghauidfhuiahfuiheafguighuieghuisehguihauighuieahguiehguisahguihsuighuisea" };
                        for (int i = 0; i < title.Length; i++)
                        {
                            for (int j = 0; j < title[i].Length; j++)
                            {
                                Console.Write(title[i][j]);
                                Thread.Sleep(50);
                            }
                            Console.WriteLine();
                        }
                        Thread.Sleep(50);

                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to choose another option from the menu");
                        Console.ReadKey();
                        break;

                    case 4:
                        {
                            int[] myIntArray = new int[10];
                            //Random rand = new Random();

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
                                //myIntList.Add(rand.Next());
                                Console.Write(myIntList[i] + ".");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to choose another option from the menu");
                        Console.ReadKey();
                        break;

                    case 5:

                        int Answer = 1;
                        int SelectedSeat = 0;
                        Random rand = new Random();
                        int[] seats = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

                        bool foundseat = false;

                        while (foundseat == false)
                        {
                            SelectedSeat = rand.Next(0, 10);
                            if (seats[SelectedSeat] == -1)
                            {
                                seats[SelectedSeat] = 1;
                                foundseat = true;
                                Console.WriteLine("Seat found, rider placed in seat. ");
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to choose another option from the menu");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Bye");
        }
    }
}
