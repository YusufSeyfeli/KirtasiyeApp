using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.SiparisUrun
{
    public class SiparisUrunDto
    {
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public DateTime SiparisTarih { get; set; }
        public float ToplamFiyat { get; set; }
    }
}
