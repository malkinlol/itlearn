using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        public string MiniDescription { get; set; }

        public string Tags { get; set; }
        public DateTime PostDate { get; set; }
        public int CountWatch { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
