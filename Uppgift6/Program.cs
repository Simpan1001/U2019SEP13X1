using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren gissa ett tal mellan 1 - 21
            //Skapa ett slumptal mellan 1 - 21(Se Object Browser Random, Random.Next(1, 21) och MSDN
            //Om användaren gissat rätt: skriv ut Grattis!
            //Annars fortsätt be användaren gissa

            Console.WriteLine("====Welcomme to Random Number Guesser====\n---------------------" +
                "");
            Random rnd = new Random();
            int temp = 0;
            string test = "";
            bool check = true;
            int itteration = 1;

            while (check == true)
            {
                Console.WriteLine("<[Itteration {0}]>\nGuess a number between 1 - 21", itteration);
                temp = rnd.Next(1, 21);
                test = Console.ReadLine();

                if (Convert.ToInt32(test) == temp)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("---------------------\nThat is incorrect, the number was ({0}). Try again.", temp);
                    itteration++;
                }
            }

            Console.WriteLine("---------------------\nCongratulations! You guessed the corrcet number ({0})" +
                " after {1} itterations.", temp, itteration);
            Console.ReadKey();
        }
    }
}
