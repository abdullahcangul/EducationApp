using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class DifficultyLevel : IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool IsActive { get; set; }

    }
}
