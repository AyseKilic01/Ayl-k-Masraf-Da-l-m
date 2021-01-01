using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary.FormClass
{
    public class cFirm
    {
        SqlDataAdapter daMain = null;
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        dsFirm dsFirm1 = new dsFirm();
        public cFirm()
        {
            Init();
        }
        public dsFirm cDsFirm { get { return dsFirm1; } }
        private void Init()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.kod, a.aciklama, a.pasif  from parFirma a ";

            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("kod", SqlDbType.VarChar, 50);
            cb.AddField("aciklama", SqlDbType.VarChar, 130);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parFirma";
            cb.Con = con;
            cb.CreateCommands(daMain);
        }
        public void LoadData()
        {
            daMain.Fill(dsFirm1.Firma);
        }
        public void SaveData()
        {
            daMain.Update(dsFirm1.Firma);
        }
        public Result Validate()
        {
            return new Result { BoolVal = true, StringVal = "" };
        }
    }
}
