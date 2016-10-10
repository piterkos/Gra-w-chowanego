using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class Pomieszczenie:Lokal
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
