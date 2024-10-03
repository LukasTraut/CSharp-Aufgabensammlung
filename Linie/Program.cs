using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            int länge = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= länge; i++)
            {
                for (int b = 0; b <= länge; b++)
                {

                    if (i == b)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
