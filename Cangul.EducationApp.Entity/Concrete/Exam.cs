using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Exam : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamDescription { get; set; }


        public PilotExam PilotExam { get; set; }
        public List<ExamGroup> ExamGroups { get; set; }
        public List<StudentTrot> StudentTrots { get; set; }

        public Test Test { get; set; }
        public bool IsActive { get; set; }

    }
}
