using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.MusteriSiparisRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.MusteriSiparisRepository
{
    public class EfMusteriSiparisDal : EfEntityRepositoryBase<MusteriSiparis, SimpleContextDb>, IMusteriSiparisDal
    {
    }
}
