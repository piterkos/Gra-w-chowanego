﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    interface IPosiadaDrzwiZewnetrzne
    {
        string OpisDrzwi { get;}
        Lokal PomieszczenieZaDrzwiamiWejsciowymi { get; set; }
    }
}
