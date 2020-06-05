using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class CourseTheme
    {
        public CourseTheme()
        {
            CourseThemeQAs = new HashSet<CourseThemeQA>();
        }

        [Key]
        public int CourseThemeId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TimeRead { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<CourseThemeQA> CourseThemeQAs { get; set; }
    }
}
