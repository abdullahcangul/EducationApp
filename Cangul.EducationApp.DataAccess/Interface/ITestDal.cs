using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cangul.EducationApp.DataAccess.Interface
{
    public interface ITestDal : IGenericDal<Test>
    {
        Task<Test> FindByNameAsync(string name);
    }
}
