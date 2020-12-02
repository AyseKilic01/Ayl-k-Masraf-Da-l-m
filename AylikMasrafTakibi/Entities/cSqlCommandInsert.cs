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

        string values;
        string master;
        string condition;

        public string Values
        {
            get { return values; }
            set { values = value; }
        }
        public string Master
        {
            get { return master; }
            set { master = value; }
        }

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }


        public cSqlCommandInsert()
        {

        }
        public cSqlCommandInsert(string Master, string Values)
        {
            string command = "insert into " + Master + "( " + " ) values (" + Values + ")";
            RunQueryInsert(command);
        }

        public cSqlCommandInsert(string Master, string Values, string Condition)
        {
            string command = "insert into " + Master +"( "+ " ) values ("+ Values +") where " + Condition + " ";
            RunQueryInsert(command);
        }
        public bool RunQueryInsert(string ProcedureName)
        {
            bool res = false;
            try
            {
                SqlCommand Command = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                Command.CommandText = ProcedureName;
                Command.CommandType = CommandType.StoredProcedure;
                Command.Connection = con;
                da.InsertCommand = Command;
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
