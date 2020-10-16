using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }

        public Answer Answer { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public bool IsActive { get; set; }

    }
}
