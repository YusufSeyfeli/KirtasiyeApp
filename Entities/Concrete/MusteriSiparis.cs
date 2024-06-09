using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MusteriSiparis
    {
        [Key]
        public int SiparisId { get; set; }
        public int KullaniciId { get; set; }
        public int MusteriSiparisId { get; set; }
        public Kullanici Kullanici { get; set; }
        public SiparisUrun SiparisUrun { get; set; }
    }
}
