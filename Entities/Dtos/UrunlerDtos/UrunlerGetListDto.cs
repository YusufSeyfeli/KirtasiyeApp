using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.UrunlerDtos
{
    public class UrunlerGetListDto :UrunlerDto
    {
        [Key]
        public int UrunId { get; set; }

    }
}
