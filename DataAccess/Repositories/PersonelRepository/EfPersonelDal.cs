using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.PersonelRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.PersonelRepository
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, SimpleContextDb>, IPersonelDal
    {
    }
}
