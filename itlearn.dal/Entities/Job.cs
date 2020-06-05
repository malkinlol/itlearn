using System;
using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Site { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        [Required]
        public string Info { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
