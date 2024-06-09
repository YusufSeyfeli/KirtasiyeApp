using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.SiparisUrunRepository.Validation
{
    public class SiparisUrunValidator : AbstractValidator<SiparisUrun>
    {
        public SiparisUrunValidator()
        {
        }
    }
}
