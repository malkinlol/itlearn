using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Notification
{
    public class NotificationVM
    {
        public int NotificationId { get; set; }

        [Required(ErrorMessage = "Поле \"Сообщение\" должно быть обязательно заполнено")]
        [StringLength(50, ErrorMessage = "Длина поля \"Сообщение\" не должно превышать 50 символов")]
        public string Message { get; set; }
        public string Language { get; set; }

        public DateTime NotificationDate { get; set; }
    }
}
