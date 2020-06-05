using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Course
{
    public class ResultCourseVM
    {
        public int CourseId { get; set; }
        public int ThemeId { get; set; }
        public string UserId { get; set; }
        public int QAId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsFinish { get; set; }
    }
}
