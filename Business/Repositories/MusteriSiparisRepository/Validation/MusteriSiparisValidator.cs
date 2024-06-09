using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.MusteriSiparisRepository.Validation
{
    public class MusteriSiparisValidator : AbstractValidator<MusteriSiparis>
    {
        public MusteriSiparisValidator()
        {
        }
    }
}
