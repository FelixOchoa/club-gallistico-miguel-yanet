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

    public class Pelea2
    {
        public Pollo Pollo1 { get; set; }
        public Pollo Pollo2 { get; set; }
        public Pelea2(Pollo pollo1, Pollo pollo2)
        {
            Pollo1 = pollo1;
            Pollo2 = pollo2;
        }
    }
}
