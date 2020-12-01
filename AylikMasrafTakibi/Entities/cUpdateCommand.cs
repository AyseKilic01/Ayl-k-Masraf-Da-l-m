using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AylikMasrafTakibi.Entities
{


    class cUpdateCommand
    {
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");

        public bool RunQuery(string ProcedureName, SqlParameter[] Parameters)
        {
            bool res = false;
            try
            {
                SqlCommand Command = new SqlCommand();
                Command.CommandText = ProcedureName;
                Command.CommandType = CommandType.StoredProcedure;
                Command.Connection = con;
                Command.Parameters.AddRange(Parameters);
                Command.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

    }
}
