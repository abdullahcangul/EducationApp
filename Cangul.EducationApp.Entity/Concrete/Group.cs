using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ExamGroup> ExamGroups { get; set; }
        public List<Trot> Trots { get; set; }
        public List<StudentTrot> StudentTrots { get; set; }
        public bool IsActive { get; set; }

    }
}
