using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.PersonelRepository.Validation
{
    public class PersonelValidator : AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
        }
    }
}
