using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.EmailParameterDtos;
using Entities.Dtos.KullaniciDtos;
using Entities.Dtos.MusteriSiparisDtos;
using Entities.Dtos.OperationClaimDtos;
using Entities.Dtos.PersonelDtos;
using Entities.Dtos.SiparisKirtasiyeDtos;
using Entities.Dtos.SiparisKirtasiyeUrunDtos;
using Entities.Dtos.SiparisUrun;
using Entities.Dtos.UrunlerDtos;
using Entities.Dtos.UserDtos;
using Entities.Dtos.UserOperationClaimDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<UserOperationClaim, UserOperationClaimDto>();
            CreateMap<UserOperationClaimDto, UserOperationClaim>();

            CreateMap<OperationClaim, OperationClaimDto>();
            CreateMap<OperationClaimDto, OperationClaim>();

            CreateMap<EmailParameter, EmailParameterDto>();
            CreateMap<EmailParameterDto, EmailParameter>();
            CreateMap<EmailParameter, EmailParameterUpdateDto>();
            CreateMap<EmailParameterUpdateDto, EmailParameter>();


            CreateMap<Kullanici, KullaniciDto>();
            CreateMap<KullaniciDto, Kullanici>();
            CreateMap<Kullanici, KullaniciUpdateDto>();
            CreateMap<KullaniciUpdateDto, Kullanici>();



            CreateMap<MusteriSiparis, MusteriSiparisDto>();
            CreateMap<MusteriSiparisDto, MusteriSiparis>();
            CreateMap<MusteriSiparis, MusteriSiparisUpdateDto>();
            CreateMap<MusteriSiparisUpdateDto, MusteriSiparis>();

            CreateMap<OperationClaim, OperationClaimDto>();
            CreateMap<OperationClaimDto, OperationClaim>();
            CreateMap<OperationClaim, OperationClaimUpdateDto>();
            CreateMap<OperationClaimUpdateDto, OperationClaim>();


            CreateMap<Personel, PersonelDto>();
            CreateMap<PersonelDto, Personel>();

            CreateMap<SiparisKirtasiye, SiparisKirtasiyeDto>();
            CreateMap<SiparisKirtasiyeDto, SiparisKirtasiye>();

            CreateMap<SiparisKirtasiyeUrun, SiparisKirtasiyeUrunDto>();
            CreateMap<SiparisKirtasiyeUrunDto, SiparisKirtasiyeUrun>();

            CreateMap<SiparisUrun, SiparisUrunDto>();
            CreateMap<SiparisUrunDto, SiparisUrun>();


            CreateMap<Urunler, UrunlerDto>();
            CreateMap<UrunlerDto, Urunler>();
            CreateMap<Urunler, UrunlerUpdateDto>();
            CreateMap<UrunlerUpdateDto, Urunler>();
            CreateMap<Urunler, UrunlerGetListDto>();
            CreateMap<UrunlerGetListDto, Urunler>();






        }
    }
}
