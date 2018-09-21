using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtHelTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et tal, så vil jeg fortælle om det er et nul, negativt eller positivt tal");
            // Konverterer tallet fra en string til en int
            int tal = Convert.ToInt32(Console.ReadLine());

            helTal(tal);


            Console.ReadKey();

        }

        private static void helTal(int tal)
        {
            if (tal == 0)
            {
                Console.WriteLine("Du har skrevet 0");
            }

            if (tal > 0)
            {
                Console.WriteLine("Du har skrevet et positivt tal");
            }

            if (tal < 0)
            {
                Console.WriteLine("Du har skrevet et negativt tal");
            }
        }
    }
}
