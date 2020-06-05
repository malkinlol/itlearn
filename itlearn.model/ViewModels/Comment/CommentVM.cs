using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Comment
{
    public class CommentVM
    {
        public int CommentId { get; set; }

        public string Message { get; set; }

        public DateTime CommentDate { get; set; }
        public bool IsConfirm { get; set; }

        public int PostId { get; set; }
        public string PostName { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
    }
}
