using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Test
    {
        public Test()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int TestId { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string Description { get; set; }
        public bool IsCorrectTest { get; set; }

        public int ThemeId { get; set; }
        public virtual Theme Theme { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

    }
}
