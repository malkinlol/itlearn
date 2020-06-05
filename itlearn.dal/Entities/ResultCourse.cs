using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class ResultCourse
    {
        [Key]
        public int ResultId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ThemeId { get; set; }
        public string UserId { get; set; }
        public bool IsFinish { get; set; }
    }
}
