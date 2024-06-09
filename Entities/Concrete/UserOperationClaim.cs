using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserOperationClaim
    {
        [Key]
        public int UserOperationClaimId { get; set; }
        public int KullaniciId { get; set; }
        public int OperationClaimId { get; set; }
        public Kullanici Kullanici { get; set; }
        public OperationClaim OperationClaim { get; set; }



    }
}
