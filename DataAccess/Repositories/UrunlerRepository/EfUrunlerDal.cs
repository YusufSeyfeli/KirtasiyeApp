using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.UrunlerRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.UrunlerRepository
{
    public class EfUrunlerDal : EfEntityRepositoryBase<Urunler, SimpleContextDb>, IUrunlerDal
    {
    }
}
