using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary
{
    [ToolboxItem(true)]
    public partial class cBarManager : BarManager
    {
        public cBarManager(IContainer container) : base(container)
        {

        }
        public cBarManager(): base()
        {
            cBarButtonItem.Register();
            cBarSubItem.Register();
        }
    }
    public class cBarButtonItem : BarButtonItem
    {
        public const string BaseBarItemName = "BarButtonItem";
        public const string BarItemName = "cBarButtonItem";
        public const string BarItemCaption = "cBarButtonItem";
        static cBarButtonItem()
        {
            Register();
        }
        public static void Register()
        {
            Register(BarAndDockingController.Default);
        }
        public static void Register(BarAndDockingController controller)
        {
            Register(controller.PaintStyles);
        }
        public static void Register(BarManagerPaintStyleCollection styles)
        {
            foreach(BarManagerPaintStyle paintStyle in styles)
            {
                BarItemInfo list = paintStyle.ItemInfoCollection[BaseBarItemName];
                if(list != null && paintStyle.ItemInfoCollection[BarItemName] == null)
                {
                    paintStyle.ItemInfoCollection.Add(new BarItemInfo(BarItemName, BarItemCaption, -1, typeof(cBarButtonItem), list.LinkType, list.ViewInfoType
                        , list.LinkPainter, true, false));
                }
            }
        }



    }
    public class cBarSubItem : BarSubItem
    {
        public const string BaseBarItemName = "BarSubItem";
        public const string BarItemName = "cBarSubItem";
        public const string BarItemCaption = "cBarSubItem";
        static cBarSubItem()
        {
            Register();
        }
        public static void Register()
        {
            Register(BarAndDockingController.Default);
        }
        public static void Register(BarAndDockingController controller)
        {
            Register(controller.PaintStyles);
        }
        public static void Register(BarManagerPaintStyleCollection styles)
        {
            foreach (BarManagerPaintStyle paintStyle in styles)
            {
                BarItemInfo list = paintStyle.ItemInfoCollection[BaseBarItemName];
                if (list != null && paintStyle.ItemInfoCollection[BarItemName] == null)
                {
                    paintStyle.ItemInfoCollection.Add(new BarItemInfo(BarItemName, BarItemCaption, -1, typeof(cBarSubItem), list.LinkType, list.ViewInfoType
                        , list.LinkPainter, true, false));
                }
            }
        }
    }
}
