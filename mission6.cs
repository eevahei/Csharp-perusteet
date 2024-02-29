using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    internal class Kesätyöpalkka
    {
        // ominaisuudet
        public string etunimi = "";
        public string sukunimi = "";
        public double toukokuu = 0;
        public double kesäkuu = 0;
        public double heinäkuu = 0;
        public double elokuu = 0;

        // metodit
        public void TulostaKeskiarvo()
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************************");
            Console.WriteLine("          Kesätyöpalkan kuukauden keskiarvo");
            Console.WriteLine("******************************************************");
            Console.WriteLine("");
            Console.WriteLine("      Työntekijä: " + this.sukunimi + (" ") + this.etunimi);
            Console.WriteLine("");
            Console.WriteLine("      Toukokuun palkka: " + this.toukokuu);
            Console.WriteLine("      Kesäkuun palkka: " + this.kesäkuu);
            Console.WriteLine("      Heinäkuun palkka: " + this.heinäkuu);
            Console.WriteLine("      Elokuun palkka: " + this.elokuu);
            Console.WriteLine("");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("      Palkan keskiarvo kuukaudessa: " + this.LaskeKeskiarvo().ToString("0.00"));
            Console.WriteLine("");
        } // TulostaKeskiarvo

        private double LaskeKeskiarvo()
        { 
            double ka = (this.toukokuu + this.kesäkuu + this.heinäkuu + this.elokuu) / 4;
            return ka;
        }

            static void Main(string[] args)
        {
            // ilmentymää olioluokalle
            Kesätyöpalkka kp = new Kesätyöpalkka();

            try
            {
                // kysytään palkkalaskelmaan tarvittavat tiedot
                Console.WriteLine("Anna kesätyöpalkan keskiarvon laskemiseen vaadittavat tiedot:");
                Console.Write("Etunimi: ");
                kp.etunimi = Console.ReadLine();
                Console.Write("Sukunimi: ");
                kp.sukunimi = Console.ReadLine();
                Console.Write("Toukokuun palkka: ");
                kp.toukokuu = Double.Parse(Console.ReadLine());
                Console.Write("Kesäkuun palkka: ");
                kp.kesäkuu = Double.Parse(Console.ReadLine());
                Console.Write("Heinäkuun palkka: ");
                kp.heinäkuu = Double.Parse(Console.ReadLine());
                Console.Write("Elokuun palkka: ");
                kp.elokuu = Double.Parse(Console.ReadLine());

                // tulostetaan keskiarvo
                kp.TulostaKeskiarvo();
            } catch (Exception virhe)
            {
                Console.WriteLine("VIRHE: Jokin mättää! Yritä uudelleen!");
            } // try

        } // main
    } // class
} // namespace
