using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.UrunlerRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.UrunlerRepository.Validation;
using Business.Repositories.UrunlerRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.UrunlerRepository;
using Entities.Dtos.UrunlerDtos;
using Core.Utilities.Business;
using AutoMapper;

namespace Business.Repositories.UrunlerRepository
{
    public class UrunlerManager : IUrunlerService
    {
        private readonly IUrunlerDal _urunlerDal;
        private readonly IMapper _mapper;

        public UrunlerManager(IUrunlerDal urunlerDal, IMapper mapper)
        {
            _urunlerDal = urunlerDal;
            _mapper = mapper;

        }

        //[SecuredAspect()]
        //[ValidationAspect(typeof(UrunlerValidator))]
        //[RemoveCacheAspect("IUrunlerService.Get")]

        public async Task<IResult> Add(UrunlerDto urunlerDto)
        {
           
            IResult result = BusinessRules.Run(await IsNameExistForAdd(urunlerDto.UrunAd));
            if (result != null)
            {
                return result;
            }
            var mapper = _mapper.Map<Urunler>(urunlerDto);
            try
            {
                await _urunlerDal.Add(mapper);
                return new SuccessResult(UrunlerMessages.Added);
            }
            catch (Exception ex)
            {
                return new Result(false, ex.Message);
            }
        }

        //[SecuredAspect()]
        //[ValidationAspect(typeof(UrunlerValidator))]
        //[RemoveCacheAspect("IUrunlerService.Get")]

        public async Task<IResult> Update(UrunlerUpdateDto urunlerUpdateDto)
        {

            var mapper = _mapper.Map<Urunler>(urunlerUpdateDto);

            try
            {
                await _urunlerDal.Update(mapper);
                return new SuccessResult(UrunlerMessages.Updated);
            }
            catch (Exception ex)
            {
                return new Result(false, ex.Message);
            }
        }

        //[SecuredAspect()]
        //[RemoveCacheAspect("IUrunlerService.Get")]

        public async Task<IResult> Delete(int urunlerId)
        {
            try
            {
                await _urunlerDal.Delete(urunlerId);
                return new SuccessResult(UrunlerMessages.Deleted);
            }
            catch (Exception ex)
            {
                return new Result(false, ex.Message);
            }

        }

        //[SecuredAspect()]
        //[CacheAspect()]
        //[PerformanceAspect()]
        public async Task<IDataResult<List<UrunlerGetListDto>>> GetList()
        {
            List<Urunler> listUrunler = await _urunlerDal.GetAll();
            var myListUrunler = _mapper.Map<List<UrunlerGetListDto>>(listUrunler);
            return new SuccessDataResult<List<UrunlerGetListDto>>(myListUrunler);
        }

        //[SecuredAspect()]
        public async Task<IDataResult<Urunler>> GetById(int id)
        {
            return new SuccessDataResult<Urunler>(await _urunlerDal.Get(p => p.UrunId == id));
        }

        private async Task<IResult> IsNameExistForAdd(string name)
        {
            var result = await _urunlerDal.Get(p => p.UrunAd == name);
            if (result != null)
            {
                return new ErrorResult(UrunlerMessages.NameExist);
            }
            return new SuccessResult();
        }

    }
}
