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
    //Crarea unei Liste unde se observa clientul si curierul cu care s-a intalnit
    public class Search_by_Date2
    {
       
            public List<Angajatii_si_Clientii_din_ziua> GetList2(string date)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
                {
                    var output = connection.Query<Angajatii_si_Clientii_din_ziua>("dbo.Angajatul_si_Clientii_din_ziua @DATA", new { DATA = date }).ToList();
                    return output;
                }
            }
        
    }
}
