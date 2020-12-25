using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary
{
    [ToolboxItem(true)]
    public partial class cGridLookupEdit : GridLookUpEdit
    {
        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            foreach (System.Windows.Forms.Binding b in this.DataBindings) b.BindingManagerBase.EndCurrentEdit();
        }
        public DataRow cGetSelectedDataRow()
        {
            DataRow r = null;
            if (this.GetSelectedDataRow() != null && this.GetSelectedDataRow() is DataRowView) return (this.GetSelectedDataRow() as DataRowView).Row;
            return r;
        }
    }
}
