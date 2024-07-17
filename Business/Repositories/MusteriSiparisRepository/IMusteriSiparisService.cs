using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.MusteriSiparisRepository
{
    public interface IMusteriSiparisService
    {
        Task<IResult> Add(MusteriSiparis musteriSiparis);
        Task<IResult> Update(MusteriSiparis musteriSiparis);
        Task<IResult> Delete(int musteriSiparis);
        Task<IDataResult<List<MusteriSiparis>>> GetList();
        Task<IDataResult<MusteriSiparis>> GetById(int id);
    }
}
