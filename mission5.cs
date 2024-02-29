using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä5
{
    internal class Verotus
    {
        public class HoidaVertous
        { // Tähän ominaisuuteen tallennetaan summa
            private double summa = 0;

         public bool KysySumma()
            {
                bool ok = true; // onnistuiko
                try
                {
                    Console.Write("Anna vuoden verotettava ansiotulo euroina: ");
                    this.summa = double.Parse(Console.ReadLine());
                } catch (Exception virhe)
                { ok = false; // pieleen
                } // catch
                return ok;
            } // KysySumma

            public double LaskeVero()
            { double vero = 0;

            if (this.summa < 19200)
                { vero = 0;
                } // if
            else if ((this.summa >= 19200) && (this.summa < 28700))
                { 
                    vero = 8 + 0.06 * (this.summa - 19200);
                }
            else if ((this.summa >= 28700) && (this.summa < 47300))
                {
                    vero = 578 + 0.1725 * (this.summa - 28700);
                }
            else if ((this.summa >= 47300) && (this.summa < 82900))
                {
                    vero = 3786.50 + 0.2125 * (this.summa - 47300);
                }
            else
                { 
                    vero = 11351.50 + 0.3125 * (this.summa - 82900);
                }
                return vero;
            } // LaskeVero
        } // HoidaVerotus

        static void Main(string[] args)
        { // luodaan ilmentymä oliolle
            HoidaVertous apu = new HoidaVertous();
            // kysytään verotettava tulo
            if (apu.KysySumma())
            {
                double vero = apu.LaskeVero();
                Console.WriteLine("Tuloveron suuruus: " + vero.ToString("0.00") + " euroa");
            }
            else
            {
                Console.WriteLine("VIRHE: Antamasi luku ei kelpaa! Yritä uudelleen!");
            } // if
        } // main
    } // class
} // namespace