using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace afbLibrary
{
    public static class cons
    {
        public static string servername, databasename, username, password = "";

        public static void setConnectionString()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(System.Windows.Forms.Application.StartupPath + @"//config/configConnection.xml");


            foreach (XmlNode node in xml.DocumentElement)
            {
                servername = node.ChildNodes[0].InnerText;
                databasename = node.ChildNodes[1].InnerText;
                username = node.ChildNodes[2].InnerText;
                password = node.ChildNodes[3].InnerText;
            }

        }
        public static string getConnectionString()
        {
            // return "Data Source=" + servername.ToString() + ";Initial Catalog=" + databasename.ToString() + ";User ID=" + username.ToString() + ";Password=" + password.ToString();
            return "server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI";
        }
    }
}
