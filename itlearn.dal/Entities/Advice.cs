using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Advice
    {
        [Key]
        public int AdviceId { get; set; }
        public int TestId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public string Link { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
