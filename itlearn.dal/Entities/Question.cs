using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        [Key]
        public int QuestionId { get; set; }

        [Required]
        [StringLength(200)]
        public string SomeQuestion { get; set; }

        public int TestId { get; set; }
        public virtual Test Test { get; set; }

        public string Avatar { get; set; }

        public bool IsCorrectQuestion { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

    }
}
