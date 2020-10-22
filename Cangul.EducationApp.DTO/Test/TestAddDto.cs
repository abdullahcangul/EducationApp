using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DTO.Test
{
    public class TestAddDto:IDto
    {
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public string Description { get; set; }
    }
}
