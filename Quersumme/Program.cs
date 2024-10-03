using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quersumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int quersumme = BerechneQuersumme(zahl);
            Console.WriteLine("Die Quersumme von " +zahl + " ist " +quersumme);
            
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
                    break;
                }
            }


        }
    }
}
