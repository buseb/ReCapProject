using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Colors>
    {
        public ColorValidator()
        {
            RuleFor(c => c.CarColorName).NotEmpty();
            RuleFor(c => c.CarColorName).MinimumLength(3);

        }
    }
}
