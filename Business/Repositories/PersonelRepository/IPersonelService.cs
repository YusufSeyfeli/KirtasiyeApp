using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.PersonelRepository
{
    public interface IPersonelService
    {
        Task<IResult> Add(Personel personel);
        Task<IResult> Update(Personel personel);
        Task<IResult> Delete(Personel personel);
        Task<IDataResult<List<Personel>>> GetList();
        Task<IDataResult<Personel>> GetById(int id);
    }
}
