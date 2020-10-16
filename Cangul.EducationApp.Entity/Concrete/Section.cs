using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Section : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionCount { get; set; }

        public Trot Trot { get; set; }
        public List<QuestionSection> QuestionSections { get; set; }

        public int PilotExamId { get; set; }
        public PilotExam PilotExam { get; set; }
        public bool IsActive { get; set; }

    }
}
