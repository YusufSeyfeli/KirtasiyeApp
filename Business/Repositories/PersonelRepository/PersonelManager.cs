using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.PersonelRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.PersonelRepository.Validation;
using Business.Repositories.PersonelRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.PersonelRepository;

namespace Business.Repositories.PersonelRepository
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(PersonelValidator))]
        [RemoveCacheAspect("IPersonelService.Get")]

        public async Task<IResult> Add(Personel personel)
        {
            await _personelDal.Add(personel);
            return new SuccessResult(PersonelMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(PersonelValidator))]
        [RemoveCacheAspect("IPersonelService.Get")]

        public async Task<IResult> Update(Personel personel)
        {
            await _personelDal.Update(personel);
            return new SuccessResult(PersonelMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("IPersonelService.Get")]

        public async Task<IResult> Delete(Personel personel)
        {
            await _personelDal.Delete(personel);
            return new SuccessResult(PersonelMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<Personel>>> GetList()
        {
            return new SuccessDataResult<List<Personel>>(await _personelDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<Personel>> GetById(int id)
        {
            return new SuccessDataResult<Personel>(await _personelDal.Get(p => p.PersonelId == id));
        }

    }
}
