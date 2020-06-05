using System;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public string Position { get; set; }
        [Required]
        public string Site { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public bool IsGraduate { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
