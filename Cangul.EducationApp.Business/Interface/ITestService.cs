using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cangul.EducationApp.Business.Interface
{
    public interface ITestService: IGenericService<Test>
    {
        Task<Test> FindByNameAsync(string name);
    }
}
