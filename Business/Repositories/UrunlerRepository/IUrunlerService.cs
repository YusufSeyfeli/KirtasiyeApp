using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Entities.Dtos.UrunlerDtos;

namespace Business.Repositories.UrunlerRepository
{
    public interface IUrunlerService
    {
        Task<IResult> Add(UrunlerDto urunlerDto);
        Task<IResult> Update(UrunlerUpdateDto urunlerUpdateDto);
        Task<IResult> Delete(int urunlerId);
        Task<IDataResult<List<UrunlerGetListDto>>> GetList();
        Task<IDataResult<Urunler>> GetById(int id);
    }
}
