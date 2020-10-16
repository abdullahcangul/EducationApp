using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Tc { get; set; }

        public DateTime BirthDate { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Parent Parent { get; set; }
        public bool IsActive { get; set; }


    }
}
