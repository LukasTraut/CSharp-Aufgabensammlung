using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_30_teielbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30 die durch 5 und/oder 3 ohne Rest teilbar sind:");

            Console.WriteLine(geteilt());
        }

        static string geteilt()
        {
            string result = "";

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += + i + ", ";
                }
            }

            if (result.EndsWith(", "))
            {
                result = result.Remove(result.Length - 2);
            }

            return result;
        }
    }
}
