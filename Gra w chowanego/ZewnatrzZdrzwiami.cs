using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class ZewnatrzZdrzwiami : ZewnatrzZkryjowka, IPosiadaDrzwiZewnetrzne
    {
        public ZewnatrzZdrzwiami(string nazwa, bool czyCieplo, string opisDrzwi, string kryjowka) : base(nazwa, czyCieplo, kryjowka)
        {
            this.opisDrzwi = opisDrzwi;
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
