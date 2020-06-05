using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Chapter
    {
        public Chapter()
        {
            Themes = new HashSet<Theme>();
        }

        [Key]
        public int ChapterId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsEnable { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public virtual ICollection<Theme> Themes { get; set; }
    }
}
