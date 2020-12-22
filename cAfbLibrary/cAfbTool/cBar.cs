using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cAfbLibrary.cAfbTool
{

    public class cBar : BarManager
    {
     //   public ItemClickEventArgs(BarItem item, BarItemLink link);

        //
        // Summary:
        //     Gets the DevExpress.XtraBars.BarItem whose link was clicked.
        public BarItem Item { get; }
        //
        // Summary:
        //     Gets the clicked DevExpress.XtraBars.BarItemLink.
        public BarItemLink Link { get; }
    }
}
