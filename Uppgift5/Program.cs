using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList MyList = new System.Collections.ArrayList();
            Console.WriteLine("Hello there! Please add strings of lines into the List. Type " + "AVSLUTA" + " whenever you wish to stop.\n");

            int i = 1;
            string temp = "";
            bool checker = true;
            while (checker == true)
            {
                Console.WriteLine("Please add string {0} to the List.", i);
                temp = Console.ReadLine();

                if (temp.ToLower() != "avsluta")
                {
                    MyList.Add(temp);
                    i++;
                }
                else
                {
                    checker = false;
                }
            }
            Console.WriteLine();
            for (int e = 0; e < MyList.Count; e++)
            {
                Console.Write("{0} ", MyList[e]);
            }

            Console.WriteLine("\nExiting program. . .");
            //Console.ReadKey();
        }
    }
}
