using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Library_Classes
{
    public class Colet
    {
        public int IDColet { get; set; }
        public string Nume { get; set; }
        public float Volum { get; set; }
        public float Greutate { get; set; }
        public string DataPrimirii { get; set; }
        public float Pret { get; set; }
        public int isFragil { get; set; }
        public int isUrgent { get; set; }
        public int isPlatit { get; set; }

    }
}
