using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }

        public List<StudentTrot> StudentTrots { get; set; }
        public int ClassromId { get; set; }
        public Classroom Classroom { get; set; }

        public List<Parent> Parents { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public bool IsActive { get; set; }


    }
}
