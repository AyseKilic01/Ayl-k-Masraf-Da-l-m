using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylikMasrafTakibi.Entities.Dto
{
   public partial class DtoGiderTip
    {
        public DtoGiderTip()
        {
            this.TblGider = new HashSet<DtoGider>();
        }
        public int id { get; set; }
        public string code { get; set; }
        public string explanation { get; set; }
        public bool pasif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DtoGider> TblGider { get; set; }
    }
}
