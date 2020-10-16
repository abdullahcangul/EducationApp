using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string QuestionDescription { get; set; }

        public List<Option> Options { get; set; }

        public List<QuestionTest> QuestionTest { get; set; }


        public List<Image> Images { get; set; }

        public List<QuestionSection> QuestionSections { get; set; }
        public bool IsActive { get; set; } = true;


    }
}
