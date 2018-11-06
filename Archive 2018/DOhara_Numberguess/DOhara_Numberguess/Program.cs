using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)

        {
            //Create a random object
            Random random = new Random();
            //Create an int (integer) to store the random number
            int RandomNumber = random.Next(1, 1000);
            //Create an int to store the users guesses
            int Guess = 0;
            //Creat an int to store how many guesses it took the user
            int NumGuesses = 0;
            //ask the user to input a number bewteen two random numbers
            Console.WriteLine("Guess a number between 1 and 1000");
            //While loop tests your input number until you get it right
            while (Guess != RandomNumber)
            {
                //have the console read the users input
                Guess = int.Parse(Console.ReadLine());
                //input number of guesses
                NumGuesses++;
                //if statement checks if the guess was right or wrong and does the following functions
                if (Guess < RandomNumber)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Guess again?");
                }
                //else if statement tells the user if they are too low
                else if (Guess > RandomNumber)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Guess again?");
                }
            }
            //Tell user they got it right and took them a certain amount of tries
            Console.WriteLine("Good Job! The answer was " + RandomNumber + ". You took " + NumGuesses + " Tries to get that right!. ");
            Console.ReadLine();
        }
    }
}