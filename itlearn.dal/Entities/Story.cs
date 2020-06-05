using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.dal.Entities
{
    public class Story
    {
        [Key]
        public int StoryId { get; set; }

        public string Link { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int ThemeId { get; set; }
    }
}
