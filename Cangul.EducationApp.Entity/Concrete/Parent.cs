using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Parent : IEntity
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public bool IsActive { get; set; }

    }
}
