using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Låt användaren mata in en mening.
            //Skriv ut varje unik bokstav på en egen rad, och ange hur ofta den förekommer;

            Console.WriteLine("Please input a sentence.");
            //string phrase = Console.ReadLine();
            string temp = "Hello world";
            string phrase = temp.ToLower();
            char[] letters = new char[phrase.Length];
            int[] counter = new int[26];//26 letters of the english alphabet

            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }


            Console.WriteLine();
            //This loop assigns each letter in "phrase" to the array \/
            for (int i = 0; i < phrase.Length; i++)
            {
                letters[i] = phrase[i];
            }
            //This loop assigns each letter in "phrase" to the array /\

            //This loop only prints out the letters on the screen. (Removeable) \/
            foreach (char s in letters) 
            {
                Console.Write(s);
                if (s == ' ')
                {
                    Console.Write("\t");
                }
            }
            //This loop only prints out the letters on the screen. (Removeable) /\

            Console.WriteLine("\n");
            for (int j = 0; j < letters.Length; j++) {

                for (int i = 0; i < letters.Length; i++) {

                    if (letters[j] == letters[i])
                    {
                        counter[j]++;
                    }
                }
                Console.WriteLine(" {0} ({1})", letters[j], counter[j]);
            }

            Console.ReadKey();
        }
    }
}
