using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Trot : IEntity
    {
        public int Id { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public bool IsActive { get; set; }


    }
}
