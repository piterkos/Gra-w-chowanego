using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mieszkanie_s._338
{
    class LokacjaWewnetrznazDrzwiami:Pomieszczenie, IPosiadaDrzwiZewnetrzne
    {
        public LokacjaWewnetrznazDrzwiami(string nazwa, string _opisDrzwi, string dekoracje) : base(nazwa,dekoracje)
        {
            this.opisDrzwi = _opisDrzwi;
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
