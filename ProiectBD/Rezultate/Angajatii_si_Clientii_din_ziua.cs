using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Angajatii_si_Clientii_din_ziua
    {
        public string Nume1 { get; set; }
        public string Prenume1 { get; set; }
        public string Nume2 { get; set; }
        public string Prenume2 { get; set; }
        public string NrTelefon { get; set; }
        public string INFO
        {
            get
            {
                return $"Angajatul:{Nume1},{Prenume1} are clientul:{Nume2},{Prenume2} cu numarul:{NrTelefon}";
            }
        }
    }
}
