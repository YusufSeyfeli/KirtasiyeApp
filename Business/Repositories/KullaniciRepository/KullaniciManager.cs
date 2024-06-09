using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.KullaniciRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.KullaniciRepository.Validation;
using Business.Repositories.KullaniciRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.KullaniciRepository;

namespace Business.Repositories.KullaniciRepository
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(KullaniciValidator))]
        [RemoveCacheAspect("IKullaniciService.Get")]

        public async Task<IResult> Add(Kullanici kullanici)
        {
            await _kullaniciDal.Add(kullanici);
            return new SuccessResult(KullaniciMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(KullaniciValidator))]
        [RemoveCacheAspect("IKullaniciService.Get")]

        public async Task<IResult> Update(Kullanici kullanici)
        {
            await _kullaniciDal.Update(kullanici);
            return new SuccessResult(KullaniciMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("IKullaniciService.Get")]

        public async Task<IResult> Delete(Kullanici kullanici)
        {
            await _kullaniciDal.Delete(kullanici);
            return new SuccessResult(KullaniciMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<Kullanici>>> GetList()
        {
            return new SuccessDataResult<List<Kullanici>>(await _kullaniciDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<Kullanici>> GetById(int id)
        {
            return new SuccessDataResult<Kullanici>(await _kullaniciDal.Get(p => p.KullaniciId == id));
        }

    }
}
