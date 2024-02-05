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
    //Crearea a doua functii pentru a extrage un user si parola aferenta din tabel
    public class Search_user
    {
        public List<Select_User> GetUser(string name1)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output = connection.Query<Select_User>($"select Username from Users where Username= '{name1}'").ToList();
                return output;
            }
        }
        public List<Select_Password> GetPass(string name2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                var output2 = connection .Query <Select_Password>($"select Password from Users where Password= '{name2}'").ToList();
                return output2 ;
            }
        }

        
    }
}
