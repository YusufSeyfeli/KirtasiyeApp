using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.SiparisUrunRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.SiparisUrunRepository
{
    public class EfSiparisUrunDal : EfEntityRepositoryBase<SiparisUrun, SimpleContextDb>, ISiparisUrunDal
    {
    }
}
