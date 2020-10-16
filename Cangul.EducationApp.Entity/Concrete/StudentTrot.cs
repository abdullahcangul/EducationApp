using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class StudentTrot:IEntity
    {
        public int Id { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int GroupId { get; set; }

        public Group Group { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public List<Answer> Answers { get; set; }
        public bool IsActive { get; set; }

    }
}
