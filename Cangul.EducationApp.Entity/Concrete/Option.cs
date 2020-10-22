using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        public int AnswerQuestionId { get; set; }
        public Question AnswerQuestion { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public bool IsActive { get; set; }

    }
}
