using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Theme
    {
        public Theme()
        {
        }

        [Key]
        public int ThemeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string MiniDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsEnable { get; set; }

        public int CountReadTime { get; set; }

        public bool IsEnableTheme { get; set; }

        public int ChapterId { get; set; }
        public virtual Chapter Chapter { get; set; }

        public virtual Test Test { get; set; }
    }
}
