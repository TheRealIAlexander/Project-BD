using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Adresele_de_livrare_in_ziua
    {
        public int Apartament { get; set; }
        public string Bloc { get; set; }
        public int Scara { get; set; }
        public string Strada { get; set; }
        public int Numarul { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }

        public string INFO
        {
            get
            {
                return $"Apartament:{Apartament},Bloc:{Bloc},Scara:{Scara},Strada:{Strada},Numarul:{Numarul},Ora:{Oras},Judet:{Judet}";
            }
        }
    }
}
