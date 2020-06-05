using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class Course
    {
        public Course()
        {
            Requirements = new HashSet<Requirement>();
            CourseThemes = new HashSet<CourseTheme>();
            CourseTags = new HashSet<CourseTag>();
            CourseLearns = new HashSet<CourseLearn>();
            CourseComments = new HashSet<CourseComment>();
            ResultCourses = new HashSet<ResultCourse>();
        }

        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string ShortDesciption { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public int Enrolled { get; set; }
        public string Level { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Approved { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int SubcategoryCourseId { get; set; }
        public virtual SubcategoryCourse SubcategoryCourse { get; set; }

        public virtual ICollection<Requirement> Requirements { get; set; }
        public virtual ICollection<CourseTheme> CourseThemes { get; set; }
        public virtual ICollection<CourseTag> CourseTags { get; set; }
        public virtual ICollection<CourseLearn> CourseLearns { get; set; }
        public virtual ICollection<CourseComment> CourseComments { get; set; }
        public virtual ICollection<ResultCourse> ResultCourses { get; set; }
    }
}
