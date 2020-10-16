using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class StudentAnswer : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        public bool IsActive { get; set; }

    }
}
