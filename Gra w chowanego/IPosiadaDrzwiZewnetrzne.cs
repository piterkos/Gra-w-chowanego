using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mieszkanie_s._338
{
    interface IPosiadaDrzwiZewnetrzne
    {
        string OpisDrzwi { get;}
        Lokacja LokacjaDrzwi { get; set; }
    }
}
