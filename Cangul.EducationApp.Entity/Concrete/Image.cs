using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public bool IsActive { get; set; }

    }
}
