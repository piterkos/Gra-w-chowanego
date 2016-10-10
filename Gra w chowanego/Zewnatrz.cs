﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class Zewnatrz:Lokal
    {
        public Zewnatrz(string _nazwa, bool czyGoraco) :base(_nazwa)
        {
            this.goraca = czyGoraco;
        }
        bool goraca;
        bool Goraco { get; }

        public override string Opis
        {
            get
            {
                if (goraca)
                {
                    return base.Opis + "\n Tu jest bardzo gorąco!";
                }
                else
                {
                    return base.Opis+ "\n Jest chłodno";
                }
            }
        }
    }
}
