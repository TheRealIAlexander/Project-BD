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
    //Crearea unei Liste care contin pachetele urgente si adesa depozitului unde se regasesc
    public class Return_Data1
    {
        public List<Depozite_cu_pachete_urgente> GetList5()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Depozite_cu_pachete_urgente>("dbo.Depozitele_cu_pachete_urgente").ToList();
                return output;
            }
        }
    }
}
