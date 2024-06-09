using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Authentication;
using Business.Repositories.EmailParameterRepository;
using Business.Repositories.OperationClaimRepository;
using Business.Repositories.UserOperationClaimRepository;
using Business.Repositories.UserRepository;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Repositories.EmailParameterRepository;
using DataAccess.Repositories.OperationClaimRepository;
using DataAccess.Repositories.UserOperationClaimRepository;
using Business.Repositories.UrunlerRepository;
using DataAccess.Repositories.UrunlerRepository;
using Business.Repositories.SiparisUrunRepository;
using DataAccess.Repositories.SiparisUrunRepository;
using Business.Repositories.SiparisKirtasiyeUrunRepository;
using DataAccess.Repositories.SiparisKirtasiyeUrunRepository;
using Business.Repositories.SiparisKirtasiyeRepository;
using DataAccess.Repositories.SiparisKirtasiyeRepository;
using Business.Repositories.PersonelRepository;
using DataAccess.Repositories.PersonelRepository;
using Business.Repositories.MusteriSiparisRepository;
using DataAccess.Repositories.MusteriSiparisRepository;
using Business.Repositories.KullaniciRepository;
using DataAccess.Repositories.KullaniciRepository;
using Business.Repositories.EmailParameterRepository;
using DataAccess.Repositories.EmailParameterRepository;
using DataAccess.Repositories.UserRepository;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<EmailParameterManager>().As<IEmailParameterService>();
            builder.RegisterType<EfEmailParameterDal>().As<IEmailParameterDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<TokenHandler>().As<ITokenHandler>();

            builder.RegisterType<UrunlerManager>().As<IUrunlerService>().SingleInstance();
            builder.RegisterType<EfUrunlerDal>().As<IUrunlerDal>().SingleInstance();

            builder.RegisterType<SiparisUrunManager>().As<ISiparisUrunService>().SingleInstance();
            builder.RegisterType<EfSiparisUrunDal>().As<ISiparisUrunDal>().SingleInstance();

            builder.RegisterType<SiparisKirtasiyeUrunManager>().As<ISiparisKirtasiyeUrunService>().SingleInstance();
            builder.RegisterType<EfSiparisKirtasiyeUrunDal>().As<ISiparisKirtasiyeUrunDal>().SingleInstance();

            builder.RegisterType<SiparisKirtasiyeManager>().As<ISiparisKirtasiyeService>().SingleInstance();
            builder.RegisterType<EfSiparisKirtasiyeDal>().As<ISiparisKirtasiyeDal>().SingleInstance();

            builder.RegisterType<PersonelManager>().As<IPersonelService>().SingleInstance();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>().SingleInstance();

            builder.RegisterType<MusteriSiparisManager>().As<IMusteriSiparisService>().SingleInstance();
            builder.RegisterType<EfMusteriSiparisDal>().As<IMusteriSiparisDal>().SingleInstance();

            builder.RegisterType<KullaniciManager>().As<IKullaniciService>().SingleInstance();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>().SingleInstance();

            builder.RegisterType<EmailParameterManager>().As<IEmailParameterService>().SingleInstance();
            builder.RegisterType<EfEmailParameterDal>().As<IEmailParameterDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
