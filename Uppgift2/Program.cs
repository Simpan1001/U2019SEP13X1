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
                    //Console.WriteLine(list[a]);
                    a++;
                }
                else if (i == e - 1) {
                    list[a] += mening[i];
                    //Console.WriteLine(list[a]);
                }
                else {
                    list[a] += mening[i];
                }
            }

            String temp;
            Boolean sorted = false;

            while (!sorted) {
                sorted = true;
                for (int i = 0; i <= a- 1; i++) {
                    if (list[i].Length > list[i+1].Length) {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        sorted = false;
                    }
                }
            }

            for (int i = 0; i <= a; i++) {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
            for (int i = a; i >= 0; i--) {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();

        }
    }
}
