using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public int InsanId { get; set; }
        public List<UserOperationClaim> UserOperationClaims { get; set; }
        public List<MusteriSiparis> MusteriSiparises{ get; set; }
        public User User { get; set; }


    }
}
