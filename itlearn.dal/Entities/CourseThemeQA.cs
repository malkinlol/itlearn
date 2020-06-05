using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class CourseThemeQA
    {
        [Key]
        public int QAId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CourseThemeId { get; set; }
        public virtual CourseTheme CourseTheme { get; set; }
    }
}
