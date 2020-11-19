using Cangul.EducationApp.DataAccess.Interface;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Repositories
{
    public class EfQuestionRepository:EfGenericRepository<Question>,IQuestionDal
    {
    }
}
