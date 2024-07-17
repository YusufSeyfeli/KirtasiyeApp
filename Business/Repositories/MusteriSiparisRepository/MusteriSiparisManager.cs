using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.MusteriSiparisRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.MusteriSiparisRepository.Validation;
using Business.Repositories.MusteriSiparisRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.MusteriSiparisRepository;

namespace Business.Repositories.MusteriSiparisRepository
{
    public class MusteriSiparisManager : IMusteriSiparisService
    {
        private readonly IMusteriSiparisDal _musteriSiparisDal;

        public MusteriSiparisManager(IMusteriSiparisDal musteriSiparisDal)
        {
            _musteriSiparisDal = musteriSiparisDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(MusteriSiparisValidator))]
        [RemoveCacheAspect("IMusteriSiparisService.Get")]

        public async Task<IResult> Add(MusteriSiparis musteriSiparis)
        {
            await _musteriSiparisDal.Add(musteriSiparis);
            return new SuccessResult(MusteriSiparisMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(MusteriSiparisValidator))]
        [RemoveCacheAspect("IMusteriSiparisService.Get")]

        public async Task<IResult> Update(MusteriSiparis musteriSiparis)
        {
            await _musteriSiparisDal.Update(musteriSiparis);
            return new SuccessResult(MusteriSiparisMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("IMusteriSiparisService.Get")]

        public async Task<IResult> Delete(int musteriSiparis)
        {
            await _musteriSiparisDal.Delete(musteriSiparis);
            return new SuccessResult(MusteriSiparisMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<MusteriSiparis>>> GetList()
        {
            return new SuccessDataResult<List<MusteriSiparis>>(await _musteriSiparisDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<MusteriSiparis>> GetById(int id)
        {
            return new SuccessDataResult<MusteriSiparis>(await _musteriSiparisDal.Get(p => p.MusteriSiparisId == id));
        }

    }
}
