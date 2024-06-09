using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.SiparisKirtasiyeDtos
{
    public class SiparisKirtasiyeDto
    {
        public int PersonelId { get; set; }
        public DateTime SiparisTarih { get; set; }
        public float ToplamFiyat { get; set; }
    }
}
