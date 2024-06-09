using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SiparisKirtasiye
    {
        [Key]
        public int SiparisKirtasiyeId { get; set; }
        public int PersonelId { get; set; }
        public DateTime SiparisTarih { get; set; }
        public float ToplamFiyat { get; set; }
        public SiparisKirtasiyeUrun SiparisKirtasiyeUrun { get; set; }
        public Personel Personel { get; set; }

    }
}
