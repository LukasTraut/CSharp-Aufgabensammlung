using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie breit soll der Stamm sein? ");
            int stammbreite = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie hoch soll der Stamm sein? ");
            int stammhöhe = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie hoch soll die Krone sein? ");
            int kronenhöhe = int.Parse(Console.ReadLine());

            zeichneBaum(stammbreite, stammhöhe, kronenhöhe);
            Console.ReadKey();
        }
        static void zeichneBaum(int stammbreite, int stammhöhe, int kronenhöhe)
        {
            ZeichneKrone(kronenhöhe);
            ZeichneStamm(stammbreite, stammhöhe, kronenhöhe);
        }
        static void ZeichneKrone(int kronenhöhe)
        {
            int Kronen_Abstand = kronenhöhe - 1;
            int stern = 1;
            for (int h = 0; h <= kronenhöhe-1; h++)
            {
                for (int a = 0; a < Kronen_Abstand; a++)
                {
                    
                    Console.Write(" ");
                    


                }
                for (int s = 0; s < stern; s++)
                {
                    Console.Write("*");
                }
                stern += 2;
                Console.WriteLine();
                Kronen_Abstand--;
            }

        }
        static void ZeichneStamm(int stammbreite, int stammhöhe, int kronenhöhe)
        {
            
            int sba = kronenhöhe / 2;
            string SH = kronenhöhe.ToString();
            int kronenbreite = (kronenhöhe * 2) - 1;
            int links_space = (kronenbreite / 2) - 1;

            string kronen = new string('*', stammbreite);
            string links_string = new string(' ', links_space);
            for (int ls = 0; ls <= stammhöhe -1; ls++)
            {

                Console.WriteLine(links_string + kronen);

            }
        }
    }
}
