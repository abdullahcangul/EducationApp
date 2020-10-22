using Cangul.EducationApp.Business.ValidationRules.FluentValidation;
using Cangul.EducationApp.DTO.Test;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cangul.EducationApp.WebUI.CustomCollectionExtensions
{
    public static class CollectionExtension
    {
        public static void AddCustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<TestAddDto>, TestAddValidator>();
            services.AddTransient<IValidator<TestUpdateDto>, TestUpdateValidator>();
        }
    }
}
