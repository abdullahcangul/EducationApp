using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DTO.Test;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cangul.EducationApp.Business.ValidationRules.FluentValidation
{
    public class TestAddValidator : AbstractValidator<TestAddDto>
    {
        private readonly ITestService _testService;

        public TestAddValidator(ITestService testService)
        {
            RuleFor(I => I.Name).NotNull().WithMessage("Name alanı boş geçilemez").MaximumLength(50).WithMessage("Max 50 Karakter girilmeli").CustomAsync(UniqueName2); 
            RuleFor(I => I.Description).MaximumLength(500).WithMessage("Max 500 Karakter girilmeli");
            _testService = testService;
        }

        private async Task UniqueName2(string name, CustomContext context, CancellationToken arg3)
        {
            var test = await _testService.FindByNameAsync(name);

            if (test != null)
            {
                context.AddFailure("Test Name is already registered.");
            }
                
        }

    }
}
