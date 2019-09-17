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

            System.Collections.ArrayList MyList = new System.Collections.ArrayList();
            int[] frequency = new int[MyList.Count];

            Console.WriteLine("Please input a sentence.");
            string mening = Console.ReadLine();
            string[] temp = mening.Split(' ');
            Console.WriteLine();

            for (int i = 0; i < temp.Length; i++)
            {
                MyList.Add(temp[i]);
            }
           
            string[] wordCounter = new string[MyList.Count];

            for (int i = 0; i < wordCounter.Length; i++)
            {
                wordCounter[i] = "1";
            }

            if (String.Equals(MyList[0], MyList[1]))
            {
                wordCounter[0]+=1;
            }

            for (int j = 0; j < MyList.Count; j++)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    if (String.Equals(MyList[j], MyList[i]) && i != j && MyList[j] != "" && MyList[i] != "")
                    {
                        MyList[i] = "";
                        wordCounter[i] = "";
                        wordCounter[j] += 1;
                    }
                }
            }

            int c = 0;
            int b = 0;
            for (int i = 0; i < MyList.Count; i++)
            {
                foreach (char a in wordCounter[i])
                {
                    b++;
                }
                if (b != 0)
                {
                    c++;
                    Console.WriteLine(MyList[i] + " (" + b + ")");
                }
                b = 0;
            }

            int[] order = new int[c];
            int d = 0;
            for (int i = 0; i < order.Length; i++)
            {
                if (wordCounter[i].Count() == 0)
                {
                    d++;
                }
                order[i] = wordCounter[d].Count();
                d++;
            }

            System.Collections.ArrayList tempy = new System.Collections.ArrayList();

            for (int i = 0; i < MyList.Count; i++)
            {
                tempy.Add(" ");
            }

            int temporary = 0;
            for (int i = 0; i <= order.Length - 2; i++)
            {
                if (order[i] > order[i+1])
                {
                    temporary = order[i + 1];
                    order[i + 1] = order[i];
                    order[i] = temporary;

                    tempy[0] = MyList[i + 1];
                    MyList[i + 1] = MyList[i];
                    MyList[i] = tempy[0];
                }
            }
            Console.WriteLine();
            for (int i = 0; i <= MyList.Count-1; i++)
            {
                    Console.WriteLine(MyList[i]);
            }

            Console.ReadKey();
        }
    }
}
