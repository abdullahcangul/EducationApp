using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tel { get; set; }
        public string ParentTel { get; set; }
        public string StudentNumber { get; set; }

        public List<StudentTest> studentTests { get; set; }

        public bool IsActive { get; set; }


    }
}
