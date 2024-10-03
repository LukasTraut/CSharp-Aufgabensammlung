using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("-----------");

            int wert1 = 0;
            int wert2 = 0;

            for (int i = 1; i <= 10; i++)
            {
                wert1++;
                Console.Write("\n");

                for (int b = 1; b <= 10; b++)
                {
                    wert2++;
                    Console.Write(wert1* wert2 +"\t");
                }
                wert2 = 0;
            }
            




        }
    }
}
