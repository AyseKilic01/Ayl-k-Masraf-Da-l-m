using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylikMasrafTakibi.Entities
{
    class CSqlCrud
    {
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommandBuilder cmdBuilder;
        DataTable changes;

        public bool SqlCommandInsert(string Master, DataTable Values, SqlDataAdapter da)
        {
            string str = "";
            switch (Master)
            {
                case "parGider":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = " '" + Values.Rows[i]["code"] + "', '" + Values.Rows[i]["explanation"] + "', "
                            //+ Values.Rows[i]["gidertip"] 
                            + "1031 "
                            + ", '" + Convert.ToDateTime(Values.Rows[i]["vadetarih"]) + "', " + Convert.ToByte(Values.Rows[i]["pasif"]);
                    }
                    break;
                case "parGiderTip":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = " '" + Values.Rows[i]["code"] + "', '" + Values.Rows[i]["explanation"] + "', " + Convert.ToByte(Values.Rows[i]["pasif"]);
                    }
                    break;
                default:
                    break;

            }

            string command = "insert into " + Master + " Values(" +
               str + ")";

            return RunQueryInsert(command, da);
        }


        public bool Check(SqlDataAdapter da, DataTable dt)
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
