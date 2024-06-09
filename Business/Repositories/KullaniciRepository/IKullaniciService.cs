using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.KullaniciRepository
{
    public interface IKullaniciService
    {
        Task<IResult> Add(Kullanici kullanici);
        Task<IResult> Update(Kullanici kullanici);
        Task<IResult> Delete(Kullanici kullanici);
        Task<IDataResult<List<Kullanici>>> GetList();
        Task<IDataResult<Kullanici>> GetById(int id);
    }
}
