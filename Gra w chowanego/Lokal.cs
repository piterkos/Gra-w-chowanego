using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    abstract class Lokal
    {
        string nazwa;
        public Lokal(string _nazwa)
        {
            this.nazwa = _nazwa;
        }
        public string Nazwa
        {
            get { return nazwa; }
        }
        public Lokal[] Wyjscia;

        public virtual string Opis
        {
            get { string opis = "Stoisz w: " + nazwa + ". \n"+ "Widzisz wyjścia do następujących lokalizacji: ";
                for (int i = 0; i < Wyjscia.Length; i++)
                {
                    opis += " " + Wyjscia[i].Nazwa;
                    if (i < Wyjscia.Length)
                    {
                        opis += ",";
                    }
                }
                opis += ".";
                return opis;
            }

        }


    }
}
