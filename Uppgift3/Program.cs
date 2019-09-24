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
            //Låt användaren mata in en mening.
            //Skriv ut varje unikt ord på en egen rad, och ange hur ofta ordet förekommer(ex "och (2)")
            //Skriv ut varje unikt ord på en egen rad, sorterat efter hur ofta ordet förekommer
            Console.WriteLine("Please input a sentence, young one.");
            string temp = Console.ReadLine();
            string tempo = temp.ToLower();
            string[] words = tempo.Split();
            int[] counter = new int[words.Length];
            Console.WriteLine();

            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }

            //This method counts every word and how much it occurs. Multiples still occur \/
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == words[i])
                    {
                        counter[j]++;
                    }
                }
            }
            //This method counts every word and how much it occurs. Multiples still occur /\

            int f = 0;
            int e = 1;
            //This method makes every word only print out once \/
            for (int i = 0; i < words.Length; i++)
            {
                if (counter[i] > 1)
                {
                    f = counter[i];
                    while (e < f)
                    {
                        for (int k = words.Length - 1; k >= 0; k--)
                        {
                            if (words[k] == words[i] && k != i)
                            {
                                if (e != f + 1)
                                {
                                    words[k] = " ";
                                    counter[k] = 0;
                                    e++;
                                }
                            }
                        }
                    }
                    e = 1;
                }
                if (words[i] != " " && words[i] != " " && words[i] != " ")
                {
                    Console.WriteLine(" {0} ({1})", words[i], counter[i]);
                }
            }
            //This method makes every word only print out once /\
        }
    }
}
