using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AylikMasrafTakibi.Entities
{


    class cSqlCommandInsert
    {
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");

        public bool SqlCommandInsert(string Master, string[] Values)
        {
            string str = "";
            for (int i = 0; i < Values.Length; i++) {
                str = Values[i]+ ", ";
            }
            string command = "insert into " + Master + " Values(" +
               str  + ")";

            return RunQueryInsert(command);
        }

        public bool RunQueryInsert(string Procedure)
        {
            bool res = false;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(Procedure, con);
                da.InsertCommand = command;
                da.InsertCommand.ExecuteNonQuery();
                res = true;
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
    }
}
