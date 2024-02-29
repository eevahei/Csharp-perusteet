using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valinta = "";
            do
            {
                Console.Clear();
                // Rakennetaan valikko
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("         PINTA-ALOJEN LASKEMINEN");
                Console.WriteLine();
                Console.WriteLine("         1. Ympyrän pinta-ala");
                Console.WriteLine("         2. Nelikulmion pinta-ala");
                Console.WriteLine("         3. Kolmion pinta-ala");
                Console.WriteLine();
                Console.WriteLine("         L Lopetus");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Minkä pinta-alan haluat laskea? Anna valintasi: ");
                valinta = Console.ReadLine();

                try
                {
                    // Kysytään vaihtoehto ja lasketaan 
                    if (valinta.Equals("1")) // ympyrä
                    {
                        Console.WriteLine("Anna ympyrän säde:");
                        double summa = Double.Parse(Console.ReadLine());
                        double tulos = 3.14159 * (summa * summa);
                        Console.WriteLine("Kun säde on " + summa + ", ympyrän pinta-ala on: " + tulos.ToString("0.00"));
                    } // if
                    else if (valinta.Equals("2")) // nelikulmio
                    {
                        Console.Write("Anna nelikulmion leveys: ");
                        double leveys = Double.Parse(Console.ReadLine());
                        Console.Write("Anna nelikulmion korkeus: ");
                        double korkeus = Double.Parse(Console.ReadLine());
                        double tulos = leveys * korkeus;
                        Console.WriteLine("Kun korkeus on " + korkeus + " ja leveys on " + leveys + ", nelikulmion pinta-ala on " + tulos.ToString("0.00"));

                    } // else if
                    else if (valinta.Equals("3")) // kolmio
                    {
                        Console.Write("Anna kolmion kannan pituus: ");
                        double kanta = Double.Parse(Console.ReadLine());
                        Console.Write("Anna kolmion korkeus: ");
                        double korkeus = Double.Parse(Console.ReadLine());
                        double tulos = (kanta * korkeus) / 2;
                        Console.WriteLine("Kun kannan pituus on " + kanta + " ja korkeus on " + korkeus + ", kolmion pinta-ala on " + tulos.ToString("0.00"));
                    } // else if
                } // try
                catch (Exception virhe)
                { Console.WriteLine("Oops! Tapahtui virhe! Yritä uudelleen!"); 
                } // catch

                Console.Write("Paina <Enter> jatkaaksesi...");
                Console.ReadLine();
            } while (!valinta.Equals("L") && !valinta.Equals("l"));
        } // main
    } // class
} // namespace