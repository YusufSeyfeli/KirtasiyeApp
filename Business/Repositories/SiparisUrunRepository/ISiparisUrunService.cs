using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.SiparisUrunRepository
{
    public interface ISiparisUrunService
    {
        Task<IResult> Add(SiparisUrun siparisUrun);
        Task<IResult> Update(SiparisUrun siparisUrun);
        Task<IResult> Delete(int siparisUrun);
        Task<IDataResult<List<SiparisUrun>>> GetList();
        Task<IDataResult<SiparisUrun>> GetById(int id);
    }
}
