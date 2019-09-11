using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
         
        
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

            //Generating the random number
            Random rand = new Random();
            rand.Next(1, 100);


           

        }
        public static void NumberGuess(Random rand = new Random())
        {
            bool correct = true;           

            while (rand != correct)
            {


                foreach(int rand   ) 






            }
        }

    }
}
