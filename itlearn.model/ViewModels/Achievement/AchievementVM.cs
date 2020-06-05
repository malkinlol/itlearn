using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Achievement
{
    public class AchievementVM
    {
        public int AchievementId { get; set; }
        public int TestId { get; set; }
        public int Persent { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
    }
}
