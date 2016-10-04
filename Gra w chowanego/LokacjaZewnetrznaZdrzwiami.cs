using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mieszkanie_s._338
{
    class LokacjaZewnetrznaZdrzwiami : Zewnatrz, IPosiadaDrzwiZewnetrzne
    {
        public LokacjaZewnetrznaZdrzwiami(string nazwa, bool czyCieplo, string opisDrzwi):base(nazwa, czyCieplo)
        {
            this.opisDrzwi = opisDrzwi;
        }
        Lokacja lokacjaDrzwi;
        string opisDrzwi;
        public Lokacja LokacjaDrzwi
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
