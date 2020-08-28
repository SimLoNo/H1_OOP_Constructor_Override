using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonN_Constructor_Override
{
    class Program
    {
        static void Main(string[] args)
        {// Opreter reference til Medarbejder klassen og liste til at holde medarbejderne.
            Medarbejder Medarb = new Medarbejder(); 
            
            // Opretter medarbejderne og indsætter dem i en liste.
            
                Medarbejder Med1 = new Medarbejder();
                Medarbejder Med2 = new Medarbejder("Abe", "Torkildsen" );
                Medarbejder Med3 = new Medarbejder("Hugo", "Rabud");
                Medarbejder Med4 = new Medarbejder("Karsen","Kortin",Medarbejder.Jobbetegnelse.Direktoer, 210000, -2);
                Medarbejder Med5 = new Medarbejder("Camilla", "Bundvhed", Medarbejder.Jobbetegnelse.Elev, 200, 3);
                Medarbejder Med6 = new Medarbejder("Kryler", "Palani", Medarbejder.Jobbetegnelse.Saelger, 6000, 5);
                List<Medarbejder> MedarbejderListe = new List<Medarbejder>() { Med1, Med2, Med3, Med4, Med5, Med6 };



            //Udskriver listen med medarbejdere.
            Console.WriteLine("Udskriver medarbejderne.");
            foreach (var item in MedarbejderListe)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine();
            Console.WriteLine();
            Random Rnd = new Random();
            Medarbejder.Jobbetegnelse[] NyJob = new Medarbejder.Jobbetegnelse[5] { Medarbejder.Jobbetegnelse.NA, Medarbejder.Jobbetegnelse.Direktoer, Medarbejder.Jobbetegnelse.Saelger, Medarbejder.Jobbetegnelse.Produktion, Medarbejder.Jobbetegnelse.Elev, };
            foreach (var item in MedarbejderListe)
            {
                item.RetJob(NyJob[Rnd.Next(1,5)]);
                Console.WriteLine(item.ToString());

            }
            Console.ReadKey();
        }
    }
}
