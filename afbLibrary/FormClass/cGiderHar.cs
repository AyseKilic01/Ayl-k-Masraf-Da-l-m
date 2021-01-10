using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary.FormClass
{
    public class cGiderHar
    {
        SqlDataAdapter daMain = null;
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        static string kod, aciklama, firmakod;
        dsGiderHareket dsGiderHar1 = new dsGiderHareket();
        static DateTime tarih;

        private void Init()
        {
        }

        public dsGiderHareket cDsGiderHar { get { return dsGiderHar1; } }

        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }

        public string FirmaKod
        {
            get { return firmakod; }
            set { firmakod = value; }
        }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }


        public void LoadData()
        {
            daMain.Fill(dsGiderHar1.giderhardetail);
        }
        public void SaveData()
        {
            daMain.Update(dsGiderHar1.giderhardetail);
        }

    }
}
