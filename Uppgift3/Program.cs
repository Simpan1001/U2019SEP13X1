using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Var snäll och mata in en mening.");
            string fras = Console.ReadLine();

            string[] word = fras.Split(' ');

            int wordCount = 1;
            foreach (char a in fras)
            {
                if (a == ' ')
                {
                    wordCount++;
                }
            }

            int[] wordAmount = new int[wordCount];
            for (int i = 0; i < word.Length; i++)
            {
                wordAmount[i] = 0;
            }

            int[] usage = new int[wordCount];
            //Hmm, räkna varje gång ett ord förekommer... Hmmm....
            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[j] == word[i])
                    {
                        usage[j]++;
                    }
                }

                if (wordAmount[j] < 0)
                {
                    Console.WriteLine("{0} ({1})", word[j], usage[j]);
                    wordAmount[j]++;
                }
            }
            
            Console.ReadKey();
        }
    }
}
