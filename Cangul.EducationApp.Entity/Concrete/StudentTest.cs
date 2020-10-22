using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class StudentTest
    {
        public int Id { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int TestID { get; set; }
        public Test Test { get; set; }
        public List<StudentAnswer> StudentAnswers { get; set; }

    }
}
