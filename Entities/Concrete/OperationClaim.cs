using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OperationClaim
    {
        [Key]
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }
        public List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
