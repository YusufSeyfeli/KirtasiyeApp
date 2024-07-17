using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.SiparisKirtasiyeUrunRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.SiparisKirtasiyeUrunRepository.Validation;
using Business.Repositories.SiparisKirtasiyeUrunRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.SiparisKirtasiyeUrunRepository;

namespace Business.Repositories.SiparisKirtasiyeUrunRepository
{
    public class SiparisKirtasiyeUrunManager : ISiparisKirtasiyeUrunService
    {
        private readonly ISiparisKirtasiyeUrunDal _siparisKirtasiyeUrunDal;

        public SiparisKirtasiyeUrunManager(ISiparisKirtasiyeUrunDal siparisKirtasiyeUrunDal)
        {
            _siparisKirtasiyeUrunDal = siparisKirtasiyeUrunDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisKirtasiyeUrunValidator))]
        [RemoveCacheAspect("ISiparisKirtasiyeUrunService.Get")]

        public async Task<IResult> Add(SiparisKirtasiyeUrun siparisKirtasiyeUrun)
        {
            await _siparisKirtasiyeUrunDal.Add(siparisKirtasiyeUrun);
            return new SuccessResult(SiparisKirtasiyeUrunMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisKirtasiyeUrunValidator))]
        [RemoveCacheAspect("ISiparisKirtasiyeUrunService.Get")]

        public async Task<IResult> Update(SiparisKirtasiyeUrun siparisKirtasiyeUrun)
        {
            await _siparisKirtasiyeUrunDal.Update(siparisKirtasiyeUrun);
            return new SuccessResult(SiparisKirtasiyeUrunMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("ISiparisKirtasiyeUrunService.Get")]

        public async Task<IResult> Delete(int siparisKirtasiyeUrun)
        {
            await _siparisKirtasiyeUrunDal.Delete(siparisKirtasiyeUrun);
            return new SuccessResult(SiparisKirtasiyeUrunMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<SiparisKirtasiyeUrun>>> GetList()
        {
            return new SuccessDataResult<List<SiparisKirtasiyeUrun>>(await _siparisKirtasiyeUrunDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<SiparisKirtasiyeUrun>> GetById(int id)
        {
            return new SuccessDataResult<SiparisKirtasiyeUrun>(await _siparisKirtasiyeUrunDal.Get(p => p.SiparisKirtasiyeUrunId == id));
        }

    }
}
