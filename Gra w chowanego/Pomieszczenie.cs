using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mieszkanie_s._338
{
    class Pomieszczenie:Lokacja
    {
        string dekoracje;
        string Dekoracje { get; }

        public Pomieszczenie(string nazwa, string _dekoracje) : base(nazwa)
        {
            this.dekoracje = _dekoracje;
        }
        public override string Opis
        {
            get
            {
                return base.Opis + "\n Tutaj widzisz: " + dekoracje;
            }
        }
    }
}
