using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylikMasrafTakibi.Entities
{
    class cSqlCommandUpdate
    {

        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");

        public cSqlCommandUpdate()
        {
                
        }

        public bool SqlCommandUpdate(Array[] Values, string Master)
        {
            string command = "update " + Master + " set  "+ Values + " ";
            return RunQueryUpdate(command);
        }

        public bool SqlCommandUpdate(Array[] Values, string Master, Array[] Condition)
        {
            string command = "update " + Master + " set " + Values + " where " + Condition + " " ;
            return RunQueryUpdate(command);
        }


        public bool RunQueryUpdate(string Procedure)
        {
            bool res = false;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = new SqlCommand(Procedure, con);
                da.UpdateCommand.ExecuteNonQuery();
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
