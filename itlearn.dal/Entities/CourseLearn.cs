using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class CourseLearn
    {
        [Key]
        public int CourseLearnId { get; set; }
        [Required]
        public string Learn { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
