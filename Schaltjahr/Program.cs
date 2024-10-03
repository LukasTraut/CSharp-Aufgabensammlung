using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eingabe Jahr: ");
            int jahr = int.Parse(Console.ReadLine());
            {
                if (jahr % 4 == 0)
                {
                    Console.WriteLine("Das Jahr" + jahr + "ist ein Schaltjahr");
                }
                else
                {
                    Console.WriteLine("Das Jahr" + jahr + "ist KEIN Schaltjahr");
                }
            }
        }
    }
}
