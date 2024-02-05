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
    //Crearea unei liste care contine coletele unui anumid client
    public class Search_by_client
    {
        public List<Clientul_si_coletele_sale> GetList6(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Clientul_si_coletele_sale>("dbo.Clientul_si_coletele_sale @NUME", new { NUME = name }).ToList();
                return output;
            }
        }
    }
}
