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
    public class Search_colete_intarziate
    {
        public List<Colete_Intarziate > GetList7()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Colete_Intarziate  >("dbo.Colete_care_au_intarziat").ToList();
                return output;
            }
        }
    }
}
