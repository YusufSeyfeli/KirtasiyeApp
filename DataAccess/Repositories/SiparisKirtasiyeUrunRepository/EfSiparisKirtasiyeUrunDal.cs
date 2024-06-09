using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.SiparisKirtasiyeUrunRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.SiparisKirtasiyeUrunRepository
{
    public class EfSiparisKirtasiyeUrunDal : EfEntityRepositoryBase<SiparisKirtasiyeUrun, SimpleContextDb>, ISiparisKirtasiyeUrunDal
    {
    }
}
