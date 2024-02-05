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
    //Crearea unei liste care contine coletele repartizate angajatului al carui nume il introducem de la tastatura
    public class Search_by_angajat
    {
        public List<Angajatul_si_coletele_sale> GetList3(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Angajatul_si_coletele_sale>("dbo.Angajatul_si_coletele_sale @NUME", new { NUME = name }).ToList();
                return output;
            }
        }
    }
}
