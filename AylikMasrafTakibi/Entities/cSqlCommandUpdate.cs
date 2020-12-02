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
        public cSqlCommandUpdate()
        {
                
        }

        public cSqlCommandUpdate(string Values, string Master)
        {
            string command = "update " + Master + " set  "+ Values + " ";
            RunQueryUpdate(command);
        }

        public cSqlCommandUpdate(string Values, string Master, string Condition)
        {
            string command = "update " + Master + " set " + Values + " where " + Condition + " " ;
            RunQueryUpdate(command);
        }


        public bool RunQueryUpdate(string ProcedureName)
        {
            bool res = false;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand Command = new SqlCommand();
                Command.CommandText = ProcedureName;
                Command.CommandType = CommandType.StoredProcedure;
                Command.Connection = con;
                da.UpdateCommand = Command;
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
