using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afbLibrary
{
    [ToolboxItem(true)]
    public partial class cGridControl : GridControl
    {
        protected override bool ProcessGridKeys(KeyEventArgs keys, bool onlyEvent)
        {
            GridView gridview = (GridView)this.MainView;
            switch (keys.KeyCode)
            {
                case Keys.Delete:
                    if (MessageBox.Show("Seçilen Satır Silinecektir\r\nOnaylıyor Musunuz?", "AYLIK MASRAF TAKİBİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        gridview.DeleteSelectedRows();
                    }
                    break;
            }
            return base.ProcessGridKeys(keys, onlyEvent);
        }
    }
}
