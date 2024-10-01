using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Flussdiagramm_rennen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viel Kilometer möchtest du rennen: ");
            int km = int.Parse(Console.ReadLine());

            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht");
            }
            else {
                int n = (km * 1000 / 400);
                Console.Write("Das sind " + n + " Runden. Bereit für den Lauf? [J/N]");
                char bereit = char.Parse(Console.ReadLine());

                if (bereit == 'J' || bereit == 'j')
                {
                for (int i = 1; i <= n; i++)
                    { 
                        Console.WriteLine("Du läufst Runde " + i);
                    }
                Console.WriteLine("Du hast es geschaft");

                }

            }
           

        }
    }
}
