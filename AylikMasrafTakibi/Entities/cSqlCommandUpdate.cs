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
        #region const
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        #endregion
        public cSqlCommandUpdate()
        {

        }

        public bool SqlCommandUpdate(string Master, DataTable Values, SqlDataAdapter da)
        {
            string str = "";
            
            switch (Master)
            {
                case "parGider":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = str + "update " + Master + " set code = '" 
                            + Values.Rows[i]["code"] + "', explanation= '" 
                            + Values.Rows[i]["explanation"] 
                            + "', gidertipi = "
                            + Values.Rows[i]["gidertipkod"] 
                            +", vadetarih = '"
                            + Values.Rows[i]["vadetarih"] + "', pasif = " 
                            +Convert.ToByte(Values.Rows[i]["pasif"]) + " where id = "
                            + Values.Rows[i]["id"] + " ";
                        
                    }
                    break;
                case "parGiderTip":
                    for (int i = 0; i < Values.Rows.Count; i++)
                    {
                        str = str + "update " + Master + " set code = '"
                            + Values.Rows[i]["code"] + "', explanation= '"
                            + Values.Rows[i]["explanation"]
                            + "', pasif = "
                            + Convert.ToByte(Values.Rows[i]["pasif"]) + " where id = "
                            + Values.Rows[i]["id"] + " ";
                    }
                    break;
            }
         
            return RunQueryUpdate(str, da);
        }
  
        public bool RunQueryUpdate(string Procedure, SqlDataAdapter da)
        {
            bool res = false;
            try
            {
                con.Open();
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
