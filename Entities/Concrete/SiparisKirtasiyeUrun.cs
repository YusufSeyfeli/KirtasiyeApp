using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SiparisKirtasiyeUrun
    {
        [Key]
        public int SiparisKirtasiyeId { get; set; }
        public int UrunId { get; set; }
        public int SiparisKirtasiyeUrunId { get; set; }
        public int Miktar { get; set; }
        public Urunler Urun { get; set; }
        public SiparisKirtasiye SiparisKirtasiye { get; set; }


    }
}
