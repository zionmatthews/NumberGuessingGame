using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        Random rand = new Random();
        int number = rand.Next(1, 100);


        bool correct = false;
        int guess;
        int max;
        int min;


        static void Main(string[] args)
        {
            

            string choice = "";

            //Asking the player what to do.
            Console.WriteLine("Please think of a whole number between 1-100");
            Console.WriteLine("");
            Console.WriteLine("When you're done. Please press enter");
            Console.ReadLine();

            if(choice == "enter")
            {
                NumberGuess();
            }

            
           

        }
        public static void NumberGuess()
        {
            

            while (!correct)
            {
                Console.WriteLine("Is this your number? (yes/no) :", number);
                if(choice == "yes")
                {
                    Console.WriteLine("Oh, I got it. GG");

                    return;
                }
                else if(choice == "no")
                {
                    HighOrLow();
                }

                






            }
        }
        public static void HighOrLow()
        {
            Console.WriteLine("Is  the number lower or higher? (lower/higher)");
            if (choice == "lower")
            {

            }
            else if (choice == "higher")
            {
                
            }
        }

    }
}
