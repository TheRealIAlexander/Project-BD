using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProiectBD.Library_Classes;

namespace ProiectBD.Search_Methods
{
    //Clasa contine cele 3 functii pentru insert,update,delete pentru tabelul Client
    public class Insert_Client
    {
        public void InsertClient(string nume,string prenume,string email,string nrtel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute("dbo.Insert_Client @NUME, @PRENUME, @EMAIL, @NRTEL", new { NUME = nume, PRENUME = prenume, EMAIL = email, NRTEL = nrtel });
            }
        }
        public void UpdateClient(string nume, string prenume, string email, string nrtel,string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute("dbo.Update_Client @NUME, @PRENUME, @EMAIL, @NRTEL, @ID", new { NUME = nume, PRENUME = prenume, EMAIL = email, NRTEL = nrtel, ID=id});
            }
        }
        public void DeleteClient(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute($"Delete From Client Where Nume= {id}");
            }
        }
    }
}
