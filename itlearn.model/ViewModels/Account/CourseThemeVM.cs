using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Account
{
    public class CourseThemeVM
    {
        public int CourseThemeId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TimeRead { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int CourseId { get; set; }
    }
}
