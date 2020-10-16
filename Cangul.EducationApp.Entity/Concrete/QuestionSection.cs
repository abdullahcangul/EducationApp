using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class QuestionSection : IEntity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public int SequenceNumber { get; set; }
        public bool IsActive { get; set; }


    }
}
