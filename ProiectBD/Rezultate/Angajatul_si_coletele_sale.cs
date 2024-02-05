using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Angajatul_si_coletele_sale
    {
        public int IDColet { get; set; }
        public string Nume { get; set; }
        public string INFO
        {
            get
            {
                return $"Angajatul s-a ocupat de coletul:{Nume},cu id-ul: {IDColet}";
            }
        }
    }
}
