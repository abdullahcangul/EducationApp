using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public string QuestionAnswer { get; set; }
        public int StudentTrotId { get; set; }
        public StudentTrot StudentTrot { get; set; }

        public int OptionId { get; set; }
        public Option Option { get; set; }
        public List<StudentAnswer> StudentAnswers { get; set; }
        public bool IsActive { get; set; }
    }
}
