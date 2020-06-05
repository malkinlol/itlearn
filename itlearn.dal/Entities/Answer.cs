using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required]
        [StringLength(200)]
        public string SomeAnswer { get; set; }

        public bool IsRight { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
