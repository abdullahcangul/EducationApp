using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DTO.Question
{
    public class QuestionListDto:IDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Anwer { get; set; }
    }
}
