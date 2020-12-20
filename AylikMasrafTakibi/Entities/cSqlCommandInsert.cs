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
        #region const
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommandBuilder cmdBuilder;
        DataTable changes;
        #endregion
        public bool SqlCommandInsert(string Master, DataTable Values, SqlDataAdapter da)
        {
            string str = "set dateformat dmy ";
            switch (Master)
            {
                case "parGider":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = str + "insert into " + Master + " Values('" + Values.Rows[i]["code"] + "', '" + Values.Rows[i]["explanation"] + "', " 
                            + Values.Rows[i]["gidertipkod"] 
                            + ", '" + Convert.ToDateTime(Values.Rows[i]["vadetarih"]) + "', " + Convert.ToByte(Values.Rows[i]["pasif"]) + ")  ";
                    }
                    break;
                case "parGiderTip":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = "insert into " + Master + " Values('" + Values.Rows[i]["code"] + "', '" + Values.Rows[i]["explanation"] + "', " + Convert.ToByte(Values.Rows[i]["pasif"]);
                    }
                    break;
                default:
                    break;

            }
      
            return RunQueryInsert(str, da);
        }
        public bool CheckInsert(SqlDataAdapter da, DataTable dt)
        {
            cmdBuilder = new SqlCommandBuilder(da);
            changes = dt.GetChanges();
            if (changes != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["id"].ToString().Trim() == "")
                    {
                        return true;
                    }
                }
            }
            return false;
          
        }
        public bool RunQueryInsert(string Procedure, SqlDataAdapter da)
        {
            bool res = false;
            try
            {
                con.Open();
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
