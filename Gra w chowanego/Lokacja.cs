using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mieszkanie_s._338
{
    abstract class Lokacja
    {
        string nazwa;
        public Lokacja(string _nazwa)
        {
            this.nazwa = _nazwa;
        }
        public string Nazwa
        {
            get { return nazwa; }
        }
        public Lokacja[] Wyjscia;

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
