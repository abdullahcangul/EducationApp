using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Test:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public string Description { get; set; }

        public List<QuestionTest> QuestionTest { get; set; }
        public List<StudentAnswer> StudentAnswer { get; set; }
        public bool IsActive { get; set; }

    }
}
