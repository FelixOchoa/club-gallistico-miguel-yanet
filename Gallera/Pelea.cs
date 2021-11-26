using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallera
{
    public class Pelea
    {
        public int idPelea { get; set; }
        public Gallo Gallo1 { get; set; }
        public Gallo Gallo2 { get; set; }

        public Pelea(Gallo gallo1, Gallo gallo2)
        {
            Gallo1 = gallo1;
            Gallo2 = gallo2;
        }
    }
}
