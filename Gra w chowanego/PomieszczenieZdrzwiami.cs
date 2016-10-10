using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class PomieszczenieZdrzwiami : PomieszczenieZkryjowka, IPosiadaDrzwiZewnetrzne
    {
        public PomieszczenieZdrzwiami(string nazwa, string _opisDrzwi, string dekoracje, string kryjowka) : base(nazwa, dekoracje, kryjowka)
        {
            this.opisDrzwi = _opisDrzwi;
            
        }
        Lokal lokacjaDrzwi;
        string opisDrzwi;
        public Lokal PomieszczenieZaDrzwiamiWejsciowymi
        {
            get
            {
                return lokacjaDrzwi;
            }
            set
            {
                lokacjaDrzwi = value;
            }

        }

        public string OpisDrzwi
        {
            get
            {
                return opisDrzwi;
            }

        }
    }
}
