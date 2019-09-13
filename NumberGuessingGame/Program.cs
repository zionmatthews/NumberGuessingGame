using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
       


      public static  bool correct = false;
      public static int guess;
        public static int max;
        public static int min;
      public static int number = 0;
      public static  Random rand = new Random();

       





        static void Main(string[] args)
        {

            string choice = "";

            while (choice != "0")
            {
                

                //Asking the player what to do.
                Console.WriteLine("Please think of a whole number between 1-100");
                Console.WriteLine("");
                Console.WriteLine("When you're done. Please type in : ready");
                Console.WriteLine("If you wish to stop playing, type: 0");
                

                choice = Console.ReadLine();
                Console.WriteLine("");

                if (choice == "ready")
                {
                    NumberGuess();
                }

            }

            



        }
        public static void NumberGuess()
        {
            number = rand.Next(1, 100);




            string choice = "";


            Console.WriteLine("Is this your number? (yes/no) :" + number);
            choice = Console.ReadLine();
            if(choice == "yes")
            {
                Console.Write("Oh sweet, I got it. GG");
                Console.ReadLine();

                return;
            }
            else if(choice == "no")
            {
                HighOrLow();
            }








        }
        public static void HighOrLow()
        {
            string choice = "";


            Console.WriteLine("Is  the number lower or higher? (lower/higher)");
            choice = Console.ReadLine();
            if (choice == "lower")
            {
                
            }
            else if (choice == "higher")
            {
                
            }
        }

      
    }
}
