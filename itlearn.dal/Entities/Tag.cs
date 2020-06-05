using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class CourseTag
    {
        [Key]
        public int CourseTagId { get; set; }
        [Required]
        public string Name { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
