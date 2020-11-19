using Cangul.EducationApp.Business.Concrete;
using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Repositories;
using Cangul.EducationApp.DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));


            services.AddScoped<ITestService, TestManager>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<ITopicService, TopicManager>();


            services.AddScoped<ITestDal, EfTestRepository>();
            services.AddScoped<IQuestionDal, EfQuestionRepository>();
            services.AddScoped<ITopicDal, EfTopicRepository>();

        }
    }
}
