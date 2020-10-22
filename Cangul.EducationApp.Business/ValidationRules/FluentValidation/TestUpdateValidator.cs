using Cangul.EducationApp.DTO.Test;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Business.ValidationRules.FluentValidation
{
    public class TestUpdateValidator : AbstractValidator<TestUpdateDto>
    {
        public TestUpdateValidator()
        {
            RuleFor(I => I.Id).NotNull();
            RuleFor(I => I.Name).NotNull().WithMessage("Name alanı boş geçilemez").MaximumLength(50).WithMessage("Max 50 Karakter girilmeli");
            RuleFor(I => I.Description).MaximumLength(500).WithMessage("Max 500 Karakter girilmeli");
            
        }

    }
}
