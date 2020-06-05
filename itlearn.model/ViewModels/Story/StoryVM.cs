using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Story
{
    public class StoryVM
    {
        public int StoryId { get; set; }

        public string Link { get; set; }

        public string UserId { get; set; }

        public int ThemeId { get; set; }
    }
}
