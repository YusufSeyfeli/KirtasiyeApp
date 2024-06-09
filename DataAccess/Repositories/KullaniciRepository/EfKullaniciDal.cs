using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.KullaniciRepository;
using DataAccess.Context.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.KullaniciRepository
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, SimpleContextDb>, IKullaniciDal
    {
        public async Task<List<SiparisUrun>> GetSiparisUrun (int kullaniciId)
        {
            using (var context = new SimpleContextDb())
            {
                var result = from musteriSiparis in context.MusteriSiparises.Where(p => p.KullaniciId== kullaniciId)
                             join siparisUrun in context.SiparisUruns on musteriSiparis.SiparisId equals siparisUrun.SiparisId
                             select new SiparisUrun
                             {
                                 SiparisId = musteriSiparis.SiparisId,
                                 
                             };
                return await result.OrderBy(p => p.SiparisTarih).ToListAsync();
            }
        }
        public async Task<List<OperationClaim>> GetUserOperatinonClaims(int KullaniciId)
        {
            using (var context = new SimpleContextDb())
            {
                var result = from userOperationClaim in context.UserOperationClaims.Where(p => p.KullaniciId == KullaniciId)
                             join operationClaim in context.OperationClaims on userOperationClaim.OperationClaimId equals operationClaim.OperationClaimId
                             select new OperationClaim
                             {
                                 OperationClaimId = operationClaim.OperationClaimId,
                                 OperationClaimName = operationClaim.OperationClaimName
                             };
                return await result.OrderBy(p => p.OperationClaimName).ToListAsync();
            }
        }




    }
}
