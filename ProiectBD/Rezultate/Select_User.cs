﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD.Rezultate
{
    //Toate clasele din "Rezultate" sunt template-uti pentru obiecte care contin date returnate de procedurile sql
    public class Select_User
    {
        public string Username { get; set; }
        public string INFO1
        {
            get
            {
                return $"{Username}";
            }
        }
    }
}
