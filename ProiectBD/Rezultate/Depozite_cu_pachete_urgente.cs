using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Depozite_cu_pachete_urgente
    {
        public string Strada { get; set; }
        public int Numarul { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public string Nume { get; set; }
        public int IDColet { get; set; }
        public string INFO
        {
            get
            {
                return $"Pachetul:{Nume}, cu id-ul:{IDColet} se afla la depozitul de pe strada:{Strada},numarul:{Numarul},oras:{Oras},judet:{Judet}";
            }
        }
    }
}
