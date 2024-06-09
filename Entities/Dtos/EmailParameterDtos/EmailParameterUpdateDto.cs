using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.EmailParameterDtos
{
    public class EmailParameterUpdateDto : EmailParameterDto
    {
        [Key]
        public int EmailParameterId { get; set; }
    }
}
