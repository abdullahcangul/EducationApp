using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DTO.Test
{
    public class TestListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamDescription { get; set; }

    }
}
