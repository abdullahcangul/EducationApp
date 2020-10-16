using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class ExamGroup : IEntity
    {
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public bool IsActive { get; set; }


    }
}
