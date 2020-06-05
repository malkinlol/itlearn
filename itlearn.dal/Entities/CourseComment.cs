using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class CourseComment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CommentDate { get; set; }

        public int Rating { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public bool isAdmin { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
