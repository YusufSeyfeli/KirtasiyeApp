using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.SiparisKirtasiyeUrunRepository
{
    public interface ISiparisKirtasiyeUrunService
    {
        Task<IResult> Add(SiparisKirtasiyeUrun siparisKirtasiyeUrun);
        Task<IResult> Update(SiparisKirtasiyeUrun siparisKirtasiyeUrun);
        Task<IResult> Delete(int siparisKirtasiyeUrun);
        Task<IDataResult<List<SiparisKirtasiyeUrun>>> GetList();
        Task<IDataResult<SiparisKirtasiyeUrun>> GetById(int id);
    }
}
