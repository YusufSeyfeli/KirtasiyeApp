using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urunler
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public float BirimFiyat { get; set; }
        public int Stok { get; set; }
        public List<SiparisUrun> SiparisUruns { get; set; }
        public List<SiparisKirtasiyeUrun> SiparisKirtasiyeUruns { get; set; }

    }
}
