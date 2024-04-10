using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_FAZA_1
{
    internal class Cerere
    {
        public int ID { get; }
        public string Petant { get; set; }
        public string Subiect { get; set; }
        public string Descriere { get; }
        //public int Pret { get; set; }

        public Cerere(int iD, string Petant, string Subiect, string Descriere)
        {
            ID = iD;
            this.Subiect = Subiect;
            this.Descriere = Descriere;
            this.Petant = Petant;
            //this.adresa = adresa;

        }
    }
}
