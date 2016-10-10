using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class ZewnatrzZkryjowka : Zewnatrz, IKryjowka
    {
        public ZewnatrzZkryjowka(string nazwa, bool czyCieplo, string kryjowka):base(nazwa, czyCieplo)
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
