using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Management
    {
        [Key]
        public int ManagementId { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int ChapterId { get; set; }
        public int ThemeId { get; set; }
        public int TestId { get; set; }
        public bool IsEnable { get; set; }
    }
}
