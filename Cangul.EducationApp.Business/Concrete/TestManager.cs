using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DataAccess.Interface;
using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cangul.EducationApp.Business.Concrete
{
    public class TestManager: GenericManager<Test>, ITestService
    {
        
        private readonly ITestDal _testDal;
        public TestManager(ITestDal testDal) :base(testDal)
        {
            _testDal = testDal;
        }

        public async Task<Test> FindByNameAsync(string name)
        {
          return await _testDal.FindByNameAsync(name);
        }
    }
}
