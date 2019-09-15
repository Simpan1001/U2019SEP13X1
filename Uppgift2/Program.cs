using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            String mening = Console.ReadLine();
            Console.WriteLine();

            string[] list = new string[50];
            int e = mening.Length;
            int a = 0;

            for (int i = 0; i < e; i++) {

                if (mening[i] == ' ')
                {
                    a++;
                }
                else {
                    list[a] += mening[i];
                }

                

            }

        }
    }
}
