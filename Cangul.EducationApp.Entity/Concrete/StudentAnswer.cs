using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class StudentAnswer : IEntity
    {
        public int Id { get; set; }
        public int StudentTestId { get; set; }
        public StudentTest StudentTest { get; set; }
        public int? AnswerId { get; set; }
        public Option Answer { get; set; }
        public int IsCorrect { get; set; }
        public bool IsActive { get; set; }

    }
}
