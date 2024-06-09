using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.SiparisKirtasiyeRepository
{
    public interface ISiparisKirtasiyeService
    {
        Task<IResult> Add(SiparisKirtasiye siparisKirtasiye);
        Task<IResult> Update(SiparisKirtasiye siparisKirtasiye);
        Task<IResult> Delete(SiparisKirtasiye siparisKirtasiye);
        Task<IDataResult<List<SiparisKirtasiye>>> GetList();
        Task<IDataResult<SiparisKirtasiye>> GetById(int id);
    }
}
