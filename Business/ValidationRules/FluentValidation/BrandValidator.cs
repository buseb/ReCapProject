using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.CarBrandName).NotEmpty();
            RuleFor(b => b.CarBrandName).MinimumLength(2);
        }
    }
}
