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
            //Skriv ut varje unik bokstav på en egen rad, och ange hur ofta den förekommer

            Console.WriteLine("Please input a sentence.");
            string temp = Console.ReadLine();
            //string temp = "Hello world";
            string phrase = temp.ToLower();
            char[] letters = new char[phrase.Length];
            int[] counter = new int[phrase.Length];

            //This loop assigns every value in counter the startingvalue of 0 \/
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }
            //This loop assigns every value in counter the startingvalue of 0 /\


            //This loop assigns each letter in "phrase" to the array \/
            for (int i = 0; i < phrase.Length; i++)
            {
                letters[i] = phrase[i];
            }
            //This loop assigns each letter in "phrase" to the array /\


            Console.WriteLine("\n");
            //This loop counts the occurence of every character \/
            for (int j = 0; j < letters.Length; j++) {

                for (int i = 0; i < letters.Length; i++) {

                    if (letters[j] == letters[i])
                    {
                        counter[j]++;
                    }
                }   
            }
            //This loop counts the occurence of every character /\

            

            int f = 0;
            int e = 1;
            for (int i = 0; i < letters.Length; i++)
            {
                if (counter[i] > 1)//This if-algorithm is wrong somewhere... (its FIXED acctually!)
                {
                    f = counter[i];
                    while (e < f)
                    {
                        for (int k = letters.Length - 1; k >= 0; k--)
                        {
                            if (letters[k] == letters[i] && k != i)
                            {
                                if (e != f + 1)
                                {
                                    letters[k] = ' ';
                                    counter[k] = 0;
                                    e++;
                                }
                            }
                        }
                    }
                    e = 1;
                }//End of if-algorithm
                if (letters[i] != ' ' && letters[i] != '.' && letters[i] != ',')
                {
                    Console.WriteLine(" {0} ({1})", letters[i], counter[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
