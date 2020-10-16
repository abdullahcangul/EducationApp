using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Test:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int TrotId { get; set; }
        public Trot Trot { get; set; }
        public List<QuestionTest> QuestionTest { get; set; }
        public bool IsActive { get; set; }

    }
}
