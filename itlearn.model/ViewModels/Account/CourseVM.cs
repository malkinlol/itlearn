using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Account
{
    public class CourseVM
    {
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Avatar { get; set; }
        [Required]
        public string ShortDesciption { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        [Range(1, 100)]
        public int Experience { get; set; }
        public int Rating { get; set; }
        public bool Approved { get; set; }
        [Required]
        public int Enrolled { get; set; }
        public string Level { get; set; }
        public DateTime CreatedDate { get; set; }


        public string UserId { get; set; }
        [Required]
        public int SubcategoryCourseId { get; set; }
    }
}
