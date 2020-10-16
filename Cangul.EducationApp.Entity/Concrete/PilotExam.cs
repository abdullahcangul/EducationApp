using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class PilotExam : IEntity
    {
        public PilotExam()
        {
            Exam = new Exam();
        }
        public int Id { get; set; }
        public string PilotExamDescription { get; set; }
        public int QuestionCount { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public List<Section> Sections { get; set; }
        public bool IsActive { get; set; }

    }
}
