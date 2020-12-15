using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AylikMasrafTakibi.Entities
{
    public class cSqlDataAdapter
    {
        SqlDataAdapter da = null;

        public cSqlDataAdapter()
        {
            da = new SqlDataAdapter();

        }
        public cSqlDataAdapter(SqlCommand sCommand)
        {
            da = new SqlDataAdapter(sCommand);
        }

#region prop
        public SqlCommand SelectCommand
        {
            get { return da.SelectCommand; }
            set { da.SelectCommand = value; }
        }
        public SqlCommand InsertCommand
        {
            get { return da.InsertCommand; }
            set { da.InsertCommand = value; }
        }
        public SqlCommand UpdateCommand
        {
            get { return da.UpdateCommand; }
            set { da.UpdateCommand = value; }
        }
        public SqlCommand DeleteCommand
        {
            get { return da.DeleteCommand; }
            set { da.DeleteCommand = value; }
        }
#endregion


    }
}
