using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Incasarile_din_ziua
    {
        public float Incasari { get; set; }
        public string INFO
        {
            get
            {
                return $"Incasarile totale din aceasta data sunt:{Incasari}lei";
            }
        }
    }
}
