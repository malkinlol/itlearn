using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class SubcategoryCourse
    {
        public SubcategoryCourse()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int SubcategoryCourseId { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int CategoryCourseId { get; set; }
        public virtual CategoryCourse CategoryCourse { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
