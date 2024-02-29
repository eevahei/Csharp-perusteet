using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kerätään tiedot
            // Etunimi 
            Console.WriteLine("Annathan tarvittavat tiedot jatkaaksesi!");
            Console.Write("Syötä etunimesi: ");
            String Etunimi = Console.ReadLine();

            // Sukunimi
            Console.Write("Syötä sukunimesi: ");
            String Sukunimi = Console.ReadLine();

            // Ikä
            Console.Write("Syötä ikäsi numeroina: ");
            String ikä = Console.ReadLine();

            // Tehdään tietojen avulla tervehdys.
            Console.WriteLine("Tervehdys " + Etunimi + " " + Sukunimi + ". Olet " + ikä + "-vuotias!");

        }
    }
}