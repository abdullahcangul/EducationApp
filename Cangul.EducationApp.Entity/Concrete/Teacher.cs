using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Teacher:IEntity
    {
        public int Id { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public List<Student> Students { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public bool IsActive { get; set; }

    }
}
