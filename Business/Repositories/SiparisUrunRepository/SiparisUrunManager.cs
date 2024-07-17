using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.SiparisUrunRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.SiparisUrunRepository.Validation;
using Business.Repositories.SiparisUrunRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.SiparisUrunRepository;

namespace Business.Repositories.SiparisUrunRepository
{
    public class SiparisUrunManager : ISiparisUrunService
    {
        private readonly ISiparisUrunDal _siparisUrunDal;

        public SiparisUrunManager(ISiparisUrunDal siparisUrunDal)
        {
            _siparisUrunDal = siparisUrunDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisUrunValidator))]
        [RemoveCacheAspect("ISiparisUrunService.Get")]

        public async Task<IResult> Add(SiparisUrun siparisUrun)
        {
            await _siparisUrunDal.Add(siparisUrun);
            return new SuccessResult(SiparisUrunMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisUrunValidator))]
        [RemoveCacheAspect("ISiparisUrunService.Get")]

        public async Task<IResult> Update(SiparisUrun siparisUrun)
        {
            await _siparisUrunDal.Update(siparisUrun);
            return new SuccessResult(SiparisUrunMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("ISiparisUrunService.Get")]

        public async Task<IResult> Delete(int siparisUrun)
        {
            await _siparisUrunDal.Delete(siparisUrun);
            return new SuccessResult(SiparisUrunMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<SiparisUrun>>> GetList()
        {
            return new SuccessDataResult<List<SiparisUrun>>(await _siparisUrunDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<SiparisUrun>> GetById(int id)
        {
            return new SuccessDataResult<SiparisUrun>(await _siparisUrunDal.Get(p => p.SiparisUrunId == id));
        }

    }
}
