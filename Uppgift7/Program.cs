using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leet speak kolla här
            //Be användaren mata in en mening.
            //Översätt den enligt Leet Speak(när det finns flera alternativ i tabellen, välj själv så det bara är 1 - 1)
            //Skriv ut den översatta meningen.
            //Exempel: Elit > 1337

            Console.WriteLine("Pleas input a sentence, and I'll translate it to Leet Speak.");
            string input = Console.ReadLine();
            string leet = "";


            string mening = input.ToUpper();
            for (int i = 0; i < mening.Length; i++)
            {

                    if (mening[i] == 'A') { leet += "@";}
                    else if (mening[i] == 'B') { leet += "8"; }
                    else if (mening[i] == 'C') { leet += "("; }
                    else if (mening[i] == 'D') { leet += "|)"; }
                    else if (mening[i] == 'E') { leet += "3"; }
                    else if (mening[i] == 'F') { leet += "|"; }
                    else if (mening[i] == 'G') { leet += "6"; }
                    else if (mening[i] == 'H') { leet += ")-("; }
                    else if (mening[i] == 'I') { leet += "1"; }
                    else if (mening[i] == 'J') { leet += "_|"; }
                    else if (mening[i] == 'K') { leet += "|<"; }
                    else if (mening[i] == 'L') { leet += "|_"; }
                    else if (mening[i] == 'M') { leet += "|'|'|"; }
                    else if (mening[i] == 'N') { leet += "/|/"; }
                    else if (mening[i] == 'O') { leet += "0"; }
                    else if (mening[i] == 'P') { leet += "|2"; }
                    else if (mening[i] == 'Q') { leet += "(,)"; }
                    else if (mening[i] == 'R') { leet += "|Z"; }
                    else if (mening[i] == 'S') { leet += "5"; }
                    else if (mening[i] == 'T') { leet += "7"; }
                    else if (mening[i] == 'U') { leet += "|_|"; }
                    else if (mening[i] == 'V') { leet += "|/"; }
                    else if (mening[i] == 'W') { leet += "|/|/"; }
                    else if (mening[i] == 'X') { leet += "}{"; }
                    else if (mening[i] == 'Y') { leet += "'/"; }
                    else if (mening[i] == 'Z') { leet += "2"; }
                    else { leet += ' '; }
            }
            Console.WriteLine("\n"+leet);
            Console.ReadKey();
        }
    }
}
