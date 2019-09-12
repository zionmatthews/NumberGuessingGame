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
        int max = 100;
        int min = 1;

        int[] arr = new int[number];

        


        static void Main(string[] args)
        {
            while(choice != "0")
            {
                string choice = "";

                //Asking the player what to do.
                Console.WriteLine("Please think of a whole number between 1-100");
                Console.WriteLine("");
                Console.WriteLine("When you're done. Please type in : ready");
                Console.WriteLine("If you wish to stop playing, type: 0");
                Console.ReadLine();

                if (choice == "ready")
                {
                    NumberGuess();
                }

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

                    return Main();
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
                max();
            }
            else if (choice == "higher")
            {
                min();
            }
        }

        public int max
        {
            get
            {
                return max;
            }
            set
            {
                if(max < number)
                {
                    max = number;
                }
            }
        }

        public int min
        {
            get
            {
                return min;
            }
            set
            {
                if(min > number)
                {
                    min = number;
                }
            }
        }

    }
}
