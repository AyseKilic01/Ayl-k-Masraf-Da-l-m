using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afbLibrary.FormClass
{
    public class Result
    {
        bool boolval = true;
        string stringval = "";
        public bool BoolVal { get { return boolval; } set { boolval = value; } }
        public string StringVal { get { return stringval; } set { stringval = value; } }
    }
}
