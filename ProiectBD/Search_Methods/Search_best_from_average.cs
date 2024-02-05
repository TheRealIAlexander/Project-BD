using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProiectBD.Library_Classes;
using ProiectBD.Rezultate;

namespace ProiectBD.Search_Methods
{
    public class Search_best_from_average
    {
        public List<Angajatii_cu_un_traseu_mai_mare_decat_media> GetList8()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Angajatii_cu_un_traseu_mai_mare_decat_media >("dbo.Angajatii_cu_un_traseu_mai_mare_decat_media").ToList();
                return output;
            }
        }
    }
}
