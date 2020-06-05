using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Message { get; set; }

        public DateTime CommentDate { get; set; }

        public bool IsConfirm { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
