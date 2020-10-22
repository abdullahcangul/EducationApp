using Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Context;
using Cangul.EducationApp.DataAccess.Interface;
using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Repositories
{
    public class EfTestRepository : EfGenericRepository<Test>, ITestDal
    {
         EducationContext context=new EducationContext();

        public async Task<Test> FindByNameAsync(string name)
        {
            return await  context.Test.Where(I => I.Name == name).FirstOrDefaultAsync();
        }
    }
}
