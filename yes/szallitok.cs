using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace yes
{

    class Sebessegkategoria
    {
        public string tipus;
        public double ev;
        public string utas;
        public string szemelyzet;
        public double Utazosebesseg;
        public double felszallo_tomeg;
        public double fesztav;

        public Sebessegkategoria(string tipus, double ev, string utas, string szemelyzet, double utazosebesseg, double felszallo_tomeg, double fesztav)
        {
            this.tipus = tipus;
            this.ev = ev;
            this.utas = utas;
            this.szemelyzet = szemelyzet;
            this.Utazosebesseg = utazosebesseg;
            this.felszallo_tomeg = felszallo_tomeg;
            this.fesztav = fesztav;
        }

        public string Kategorianev
        {
            get
            {
                if (Utazosebesseg < 500) return "Alacsony sebességű";
                else if (Utazosebesseg < 1000) return "Szubszonikus";
                else if (Utazosebesseg < 1200) return "Transzszonikus";
                else return "Szuperszonikus";
            }
        }
    }

    internal class szallitok
    {

    }
}
