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
            var tal = getNumber();
            helTal(tal);


            Console.ReadKey();

        }

        private static int getNumber()
        {
            Console.WriteLine("Skriv et tal, så vil jeg fortælle om det er et nul, negativt eller positivt tal");
            int tal = Convert.ToInt32(Console.ReadLine());
            return tal;
        }

        private static string helTal(int tal)
        {
            if (tal == 0)
            {
                return "Du har skrevet 0";
            }

            else if (tal > 0)
            {
                return "Du har skrevet et positivt tal";
            }

            else
            {
                return "Du har skrevet et negativt tal";
            }
        }
    }
}
