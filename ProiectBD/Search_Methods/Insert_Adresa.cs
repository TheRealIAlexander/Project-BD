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
    //Clasa contine cele 3 functii pentru insert,update,delete pentru tabelul Adresa Livrare
    public class Insert_Adresa
    {
        public void InsertAdresa(int ap,string bl,int sc,string st,int nr,string oras,string judet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute("dbo.Insert_Adresa @AP, @BL,@SC,@ST,@NR,@ORAS,@JUDET", new { AP = ap, BL = bl, SC =sc, ST =st,NR=nr,ORAS=oras,JUDET=judet });
            }
        }
        public void UpdateAdresa(int ap, string bl, int sc, string st, int nr, string oras, string judet,string str_ck,int nr_ck)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute("dbo.Update_Adresa @AP, @BL,@SC,@ST,@NR,@ORAS,@JUDET,@STR_CK,@NR_CK", new { AP = ap, BL = bl, SC = sc, ST = st, NR = nr, ORAS = oras, JUDET = judet,STR_CK =str_ck,NR_CK=nr_ck });
            }
        }
        public void DeleteAdresa(string str_ck, int nr_ck)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Firma_CurieratDB")))
            {
                connection.Execute($"Delete From [Adresa Livrare] Where Strada= {str_ck} and Numarul= {nr_ck}");
            }
        }
    }
}
