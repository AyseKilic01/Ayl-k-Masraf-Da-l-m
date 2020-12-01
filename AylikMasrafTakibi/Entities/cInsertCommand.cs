using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylikMasrafTakibi.Entities
{
    class cInsertCommand
    {
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");

        SqlDataAdapter da = new SqlDataAdapter();

        private void InsertCommand()
        {
            SqlCommand command = new SqlCommand("insert into @tablename values( )",con);

        }
    }
}
