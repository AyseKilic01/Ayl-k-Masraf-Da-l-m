using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Windows.Forms;

namespace cAfbLibrary.cAfbTool
{
    [ToolboxItem(true)]
    public class cGrid : GridControl
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
