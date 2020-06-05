using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class SubscribeCourse
    {
        [Key]
        public int SubscribeCourseId { get; set; }
        [Required]
        public int CourseId { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
