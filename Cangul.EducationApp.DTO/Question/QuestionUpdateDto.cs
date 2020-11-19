using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DTO.Question
{
    public class QuestionUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Anwer { get; set; }

        public int AnswerId { get; set; }
        public Option Answer { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
