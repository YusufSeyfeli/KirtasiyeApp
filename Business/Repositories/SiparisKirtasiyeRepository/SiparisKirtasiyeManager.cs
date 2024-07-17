using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.SiparisKirtasiyeRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.SiparisKirtasiyeRepository.Validation;
using Business.Repositories.SiparisKirtasiyeRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.SiparisKirtasiyeRepository;

namespace Business.Repositories.SiparisKirtasiyeRepository
{
    public class SiparisKirtasiyeManager : ISiparisKirtasiyeService
    {
        private readonly ISiparisKirtasiyeDal _siparisKirtasiyeDal;

        public SiparisKirtasiyeManager(ISiparisKirtasiyeDal siparisKirtasiyeDal)
        {
            _siparisKirtasiyeDal = siparisKirtasiyeDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisKirtasiyeValidator))]
        [RemoveCacheAspect("ISiparisKirtasiyeService.Get")]

        public async Task<IResult> Add(SiparisKirtasiye siparisKirtasiye)
        {
            await _siparisKirtasiyeDal.Add(siparisKirtasiye);
            return new SuccessResult(SiparisKirtasiyeMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(SiparisKirtasiyeValidator))]
        [RemoveCacheAspect("ISiparisKirtasiyeService.Get")]

        public async Task<IResult> Update(SiparisKirtasiye siparisKirtasiye)
        {
            await _siparisKirtasiyeDal.Update(siparisKirtasiye);
            return new SuccessResult(SiparisKirtasiyeMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("ISiparisKirtasiyeService.Get")]

        public async Task<IResult> Delete(int siparisKirtasiye)
        {
            await _siparisKirtasiyeDal.Delete(siparisKirtasiye);
            return new SuccessResult(SiparisKirtasiyeMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<SiparisKirtasiye>>> GetList()
        {
            return new SuccessDataResult<List<SiparisKirtasiye>>(await _siparisKirtasiyeDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<SiparisKirtasiye>> GetById(int id)
        {
            return new SuccessDataResult<SiparisKirtasiye>(await _siparisKirtasiyeDal.Get(p => p.SiparisKirtasiyeId == id));
        }

    }
}
