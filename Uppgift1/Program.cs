using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftsProjekt1309
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a sentence.");
            String phrase = Console.ReadLine();
            Console.WriteLine();

            int e = phrase.Length;
            int letterCount = 0;
            int wordCount = 1;


            for (int i = 0; i < e; i++) {

                if (phrase[i] == ' ')
                {
                    wordCount++;
                    Console.Write("(" + letterCount + ")\n");
                    letterCount = 0;
                }
                else {
                    Console.Write(phrase[i]);
                    letterCount++;

                }
                
            }

            Console.WriteLine("\n\n" + wordCount);
            Console.ReadLine();

        }
    }
}
