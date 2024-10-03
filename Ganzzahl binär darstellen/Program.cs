using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzzahl_binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rest = 0;
            int wert = 0;

            string bin = "";

            Console.Write("Ganzzahlige Dezimalzahl:");
            int n = int.Parse(Console.ReadLine());
            do 
            { 
                rest = n % 2;
                bin = rest + bin;  
                wert = n / 2;
                n = wert;
            }
            while (n !=0 );

  
            Console.WriteLine(bin);

            Console.ReadKey();
        }
    }
}
