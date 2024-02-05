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
    //Crearea unei liste cu adresele de livrare la care au ajuns curierii in ziua specificata
    public class Search_by_Date
    {
        public List<Adresele_de_livrare_in_ziua> GetList1(string date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Adresele_de_livrare_in_ziua>("dbo.Adresele_de_livrat_in_ziua @DATA", new { DATA = date }).ToList();
                return output;
            }
        }
    }
}
