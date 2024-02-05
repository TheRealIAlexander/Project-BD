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
    //Crearea unei liste cu un singur element, acela fiind incasarile totale din ziua ceruta
    public class Search_by_Date3
    {
        public List<Incasarile_din_ziua> GetList4(string date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Incasarile_din_ziua>("dbo.Incasarile_din_ziua @DATA", new { DATA = date }).ToList();
                return output;
            }
        }
    }
}
