using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SiparisUrun
    {
        [Key]
        public int SiparisUrunId { get; set; }
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public DateTime SiparisTarih { get; set; }
        public float ToplamFiyat { get; set; }
        public MusteriSiparis MusteriSiparis { get; set; }
        public Urunler Urun { get; set; }
    }
}
