using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Post
{
    public class PostVM
    {
        public int PostId { get; set; }
        [Required(ErrorMessage = "Поле \"Заголовок\" должно быть обязательно заполнено")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Поле \"Сообщение\" должно быть обязательно заполнено")]
        public string Message { get; set; }
        [Required]
        public string MiniDescription { get; set; }
        public string[] Tags { get; set; }
        public DateTime PostDate { get; set; }

        public int CountWatch { get; set; }
        public bool IsAvatar { get; set; }
        public string Avatar { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
