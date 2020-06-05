using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Language
    {
        public Language()
        {
            Chapters = new HashSet<Chapter>();
        }

        [Key]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10000)]
        public string Description { get; set; }

        public bool IsEnable { get; set; }

        public string Avatar { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

    }
}
