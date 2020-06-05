using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class UserLearn
    {
        [Key]
        public int UserLearnId { get; set; }
        public string UserId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int CountLearnTheme { get; set; }
        public int CountAllTheme { get; set; }
    }
}
