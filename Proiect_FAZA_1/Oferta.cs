using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_FAZA_1
{
    internal class Oferta
    {
        public int ID { get; set; }
        public string Doritor { get; set; }

        public int Stare { get; set; } // 0 activa, 1 acceptata, 2 refuzata
        public int ID_Imobil { get; set; }
        public int pret_oferit { get; set; }
        public Oferta(int iD, string doritor, int ID_Imobil, int pret_oferit)
        {
            ID = iD;
            Doritor = doritor;
            Stare = 0;// plasata/activa
            this.ID_Imobil = ID_Imobil;
            this.pret_oferit = pret_oferit;
        }
        public Oferta(int iD, string doritor,int Stare, int ID_Imobil, int pret_oferit)
        {
            ID = iD;
            Doritor = doritor;
            this.Stare = Stare;// plasata/activa
            this.ID_Imobil = ID_Imobil;
            this.pret_oferit = pret_oferit;
        }
    }
}
