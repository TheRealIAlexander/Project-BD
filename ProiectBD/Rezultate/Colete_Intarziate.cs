using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    public class Colete_Intarziate
    {
        public int IDColet { get; set; }
        public string Nume { get; set; }

        public string INFO
        {
            get
            {
                return $"Coletul:{Nume},cu id-ul:{IDColet} a intarziat la livrare cu mai mult de 7 zile";
            }
        }
    }
}
