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
    //Clasa contine metoda de adaugare a unui nou user
    public class Set_user_and_password
    {
        public void InsertPerson(string user, string pass)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute("dbo.Adaugare_user @USER, @PASS", new { USER =user, PASS= pass});
            }
        }
        
    }
}
