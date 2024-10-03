using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quersumme_teilbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl 1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Zahl\t| Quersumme\t| Zahl / Quersumme");
            Console.WriteLine("--------------------------------------------");
            for (int i = zahl1; i <= zahl2; i++)
            {
                int ZUQ = (i / BerechneQuersumme(i)) * BerechneQuersumme(i); // gibt quersumme vertielt and zahl
                if (ZUQ == i) // falls keine Reste dann ->
                {
                    
                    Console.WriteLine($"{i}\t | {BerechneQuersumme(i)}\t | {i/BerechneQuersumme(i)}");
                }
            }
            Console.WriteLine();

        }
        static int BerechneQuersumme(int zahl)
        {

            
            int sum = 0;
            while (true)
            {
                if (zahl != 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }
                else
                {
                    return sum;
                }
            }


        }
    }
}
