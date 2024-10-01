using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden Anzahl berechnen wollen?");
            Console.Write("");
            try
            {
                int days = int.Parse(Console.ReadLine());
                if (days >= 28 && days <= 31)
                {
                    int sekunden = days * 24 * 60 * 60;
                    Console.WriteLine("Ein Monat mit " + days + " Tagen hat " + sekunden + " Sekunden");
                }

                else
                {
                    Console.WriteLine("Eingabefehler, einen Monat mit " + (days) + " gibt es nicht");
                }
            }
            catch
            {
                    Console.WriteLine("Eingabefehler, Ganzzahl erwartet");
            }
        }
    }
}
            
            
        
