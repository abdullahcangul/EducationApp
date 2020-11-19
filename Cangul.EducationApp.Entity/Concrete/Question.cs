using Cangul.EducationApp.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cangul.EducationApp.Entity.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Anwer { get; set; }

        public int? AnswerId { get; set; }
        public Option Answer { get; set; }

        public int? TopicId { get; set; }
        public Topic Topic { get; set; }


        public List<Option> Options { get; set; }
        public List<QuestionTest> QuestionTests { get; set; }
        public List<Image> Images { get; set; }


        public bool IsActive { get; set; } = true;


    }
}
