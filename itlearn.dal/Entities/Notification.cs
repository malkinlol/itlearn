using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [StringLength(100)]
        public string Message { get; set; }

        public DateTime NotificationDate { get; set; }
    }
}
