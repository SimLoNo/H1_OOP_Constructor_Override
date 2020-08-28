using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonN_Constructor_Override
{
    class Medarbejder
    {
        
        private int MinLoen = 5000;
        private int MaxLoen = 200000;
        private string fornavn;
        public string Fornavn
        {
            get { return fornavn; }
            set { fornavn = value; }
        }
        private string efternavn;
        public string Efternavn
        {
            get { return efternavn; }
            set { efternavn = value; }
        }

        public enum Jobbetegnelse {
            NA,
            Direktoer,
            Saelger,
            Produktion,
            Elev
        }
        private Jobbetegnelse jobbetegn;

        public Jobbetegnelse Jobbetegn
        {
            get { return jobbetegn; }
            set { if (value > 0 && value <= Jobbetegnelse.Elev) jobbetegn = (Jobbetegnelse)value;
                else jobbetegn = 0;
            }
        }



        private int ancinitet;

        public int Ancinitet
        {
            get { return ancinitet; }
            set { if(value >=0) ancinitet = value;
            else ancinitet = 0;
            }
        }

        private int loen;

        public int Loen
        {
            get { return loen; }
            set { if (value >= MinLoen && value <= MaxLoen) loen = value;
                else if (value > MaxLoen) loen = MaxLoen;
                else loen = MinLoen; }
        }




        public void RetJob(Jobbetegnelse NyBet) 
        {
            jobbetegn = NyBet;
        }

        public override string ToString()
        {
            return "Navn: " + fornavn + " " + efternavn + ", Jobbetengelse: " + jobbetegn + ", Månedsløn: " + loen + ", År i virksomhed: " + ancinitet;
        }
        public Medarbejder() : this("N/A", "N/A") { }
        public Medarbejder(string ForNvn, string EftNavn) : this(ForNvn, EftNavn, 0, 0, 0) { }
        public Medarbejder(string ForNvn, string EftNavn, Jobbetegnelse JobBet, int Ln, int Ancin)
        {
            Fornavn = ForNvn;
            Efternavn = EftNavn;
            Jobbetegn = JobBet;
            Loen = Ln;
            Ancinitet = Ancin;

        }

    }
}
