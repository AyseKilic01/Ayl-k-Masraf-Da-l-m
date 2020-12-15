using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylikMasrafTakibi.Entities.Dto
{
    public partial class DtoGider
    {
        public int id { get; set; }
        public string code { get; set; }
        public string explanation { get; set; }
        public Nullable<System.DateTime> vadetarih { get; set; }
        public bool pasif { get; set; }

        public virtual DtoGiderTip gidertipi { get; set; }
    }
}
