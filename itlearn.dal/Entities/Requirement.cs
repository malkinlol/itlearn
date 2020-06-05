using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class Requirement
    {
        [Key]
        public int RequirementId { get; set; }
        public string RequireName { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
