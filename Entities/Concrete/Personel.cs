using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public int InsanId { get; set; }
        public int DepartmanId { get; set; }
        public User User { get; set; }
        public List<SiparisKirtasiye> SiparisKirtasiyes { get; set; }
    }
}
