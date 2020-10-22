using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class QuestionTest : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public bool IsActive { get; set; }

    }
}
