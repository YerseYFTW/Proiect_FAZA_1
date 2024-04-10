using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_FAZA_1
{
    internal class Imobil
    {
        public int ID { get; }
        public string Proprietar { get; set; }
        public int NrCamere { get; set; }
        public string adresa { get;  }
        public int Pret { get; set; }

        public Imobil(int iD, string proprietar, int nrCamere, int pret, string adresa)
        {
            ID = iD;
            Proprietar = proprietar;
            NrCamere = nrCamere;
            Pret = pret;
            this.adresa = adresa;
            
        }

        
    }
}
