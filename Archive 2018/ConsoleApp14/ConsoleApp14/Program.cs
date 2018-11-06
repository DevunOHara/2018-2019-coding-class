using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Panlidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] title = new string[] { "Palindrome Checker Version 1.0 " };

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

            string exit = "Type 'exit' to close program";

            for (int i = 0; i < exit.Length; i++)
            {
                Console.Write(exit[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();

            string star = "******************************";

            for (int i = 0; i < star.Length; i++)
            {
                Console.Write(star[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Thread.Sleep(1000);

            string prompt = "Enter a word or sentance: ";

            for (int i = 0; i < prompt.Length; i++)
            {
                Console.Write(prompt[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine();

            string palindrome = "";
            while (palindrome != "exit")
            {
                palindrome = Console.ReadLine();
                Console.WriteLine();

                palindrome = palindrome.Replace(" ", "").Replace(".", "").Replace("'", "").Replace(",", "").Replace(";", "").Replace("!", "").Replace("?", "").Replace("\"", "").Replace(":", "").Replace("(", "").Replace(")", "").Replace("%", "").Replace("-", "").Replace("/", "").Replace("$", "").Replace("#", "").Replace("@", "");
                //for (int i = palindrome.Length - 1; i > 0;  i--)
                //{
                //    //if (!char.IsLetter(palindrome[i]))
                //    if (char.IsLetter(palindrome[i]) == false)
                //    {
                //        palindrome.Remove(i, 1);
                //    }
                //}
                //    palindrome = palindrome.ToLower();

                //Console.WriteLine(palindrome);

                for (int i = 0; i < palindrome.Length; i++)
                {
                    if (palindrome == "exit")
                    {
                        string bye = "Bye!";

                        for (int j = 0; j < bye.Length; j++)
                        {
                            Console.Write(bye[j]);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine();
                        break;
                    }

                    else if (palindrome[i] != palindrome[palindrome.Length - 1 - i])
                    {
                        i = palindrome.Length - 1;
                        string n = "This is not a palindrome";

                        for (int j = 0; j < n.Length; j++)
                        {
                            Console.Write(n[j]);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine();
                    }

                    else if (palindrome[i] == palindrome[palindrome.Length - 1 - i])
                    {
                        if (i == palindrome.Length - 1)
                        {
                            string y = "This is a palindrome";

                            for (int j = 0; j < y.Length; j++)
                            {
                                Console.Write(y[j]);
                                Thread.Sleep(50);
                            }
                            Console.WriteLine();
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}