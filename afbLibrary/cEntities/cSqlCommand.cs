using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace afbLibrary.Base
{
    public class cSqlCommand
    {
        public cSqlCommand()
        {
            cnn = new SqlConnection(cons.getConnectionString());
            cmm = cnn.CreateCommand();
        }
        SqlConnection cnn = null;
        SqlCommand cmm = null;

        public string CommandText
        {
            get { return cmm.CommandText; }
            set
            {
                cmm.CommandText = value;
            }
        }
        public SqlTransaction Transaction
        {
            get { return cmm.Transaction; }
            set
            {
                cmm.Transaction = value;
            }
        }
        public SqlCommand CommandObject
        {
            get { return cmm; }
        }
        public System.Data.SqlClient.SqlParameterCollection Parameters
        {
            get { return cmm.Parameters; }
        }

        public int ExecuteNonQuery()
        {
            return cmm.ExecuteNonQuery();
        }
    }
}
