using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class PomieszczenieZkryjowka : Pomieszczenie, IKryjowka
    {
        public PomieszczenieZkryjowka(string nazwa, string dekoracje,string kryjowka) :base(nazwa, dekoracje)
        {
            this.miejsceDoUkrycia = kryjowka;
        }

        string miejsceDoUkrycia;
        public string MiejsceDoUkrycia
        {
            get
            {
                return miejsceDoUkrycia;
            }
        }
    }
}
