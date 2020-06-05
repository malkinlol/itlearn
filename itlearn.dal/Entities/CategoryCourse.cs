using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class CategoryCourse
    {
        public CategoryCourse()
        {
            SubcategoryCourses = new HashSet<SubcategoryCourse>();
        }

        [Key]
        public int CategoryCourseId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<SubcategoryCourse> SubcategoryCourses { get; set; }
    }
}
