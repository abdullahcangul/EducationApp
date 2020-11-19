using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DataAccess.Interface;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Business.Concrete
{
    public class QuestionManager:GenericManager<Question>,IQuestionService
    {
        private readonly IQuestionDal _questionDal;
        public QuestionManager(IQuestionDal questionDal):base(questionDal)
        {
            _questionDal = questionDal;
        }

    }
}
