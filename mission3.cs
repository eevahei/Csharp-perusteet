using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_3
{
    internal class Program
    {
        static void Main(string[ args])
        {
            // luodaan aloituslause
            Console.Writeline("Tervetuloa osallistumaan ruotsinkielen työelämän sanaston tietovisaan!");
            Console.Writeline("Vastaathan jokaiseen monivalintakysymykseen!");

            // luodaan 2-uloitteinen taulukko ja lisätään kysymykset ja oikeat vastaukset
            string[,] questions = new string[6, 2];
            questions[0, 0] = "Mitä tarkoittaa en arbetsuppgift (a: Työaika b: Työtehtävä c: Työpaikka?): ";
            questions[0, 1] = "b";
            questions[1, 0] = "Mitä tarkoittaa ett lönekrav (a: Palkkavaatimus b: Palkankorotus c: Työntekijä?): ";
            questions[1, 1] = "a";
            questions[2, 0] = "Mitä tarkoittaa en chef (a: sijainen b: Pomo c: Korvaus?): ";
            questions[2, 1] = "b";
            questions[3, 0] = "Mikä on ruotsinkielinen sana sanalle Ammatti (a: En tjänst b: En branch c: Ett yrke?): ";
            questions[3, 1] = "c";
            questions[4, 0] = "Mikä on ruotsinkielinen sana sanalle Työnantaja (a: En arbetstagare b: En praktikant c: En arbetsgivare?): ";
            questions[4, 1] = "c";
            questions[5, 0] = "Mikä on ruotsinkielinen sana sanalle Loma (a: Semester b: Ett arbete c: En ersättning?): ";
            questions[5,1 ] = "a";

            // poikkeuskäsittelijä
            try 
            {
                // kysytään kysymykset ja lasketaan oikeat vastaukset 
                int oikeat = 0;
                for (int i = 0 <= 5; i++)
                {
                    Console.Writeline("Kysymys " + (i + 1) + " : " + questions[i, 0]);
                    string answer = Console.Readline();
                    if (answer.Equals(questions[i, 1]))
                    {
                        oikeat++;
                        Console.Writeline("JES! Oikein meni!Hyvää työtä!");
                    }
                    else
                    {
                        Console.Writeline("VOI EI! Nyt ei mennyt ihan putkeen!");
                    } 
                } // for loppu

                // kerrotaan oikeiden vastausten määrä
                Console.Writeline("Oikeat vastaukset: " + oikeat + "/6");
            }   catch (Exception Virhe) { Console.Writeline("VIRHE: Joku mättää! Et syöttänyt kelvollista vastausta!"); }
        } // main loppu
    } // class loppu
} // namespace loppu