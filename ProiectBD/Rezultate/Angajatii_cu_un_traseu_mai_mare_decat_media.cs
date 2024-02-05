using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    public class Angajatii_cu_un_traseu_mai_mare_decat_media
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string INFO
        {
            get
            {
                return $"Angajatul: {Nume} {Prenume} a parcurs distanta mai mare decat media";
            }
        }
    }
}
