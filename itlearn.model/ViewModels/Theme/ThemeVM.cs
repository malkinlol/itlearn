using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Theme
{
    public class ThemeVM
    {
        public int ThemeId { get; set; }

        [Required(ErrorMessage = "Поле \"Название\" должно быть обязательно заполнено")]
        [StringLength(50, ErrorMessage = "Длина поля \"Название\" не должно превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле \"Описание\" должно быть обязательно заполнено")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле \"Глава\" должно быть обязательно заполнено")]
        public int ChapterId { get; set; }
        public int TestId { get; set; }
        public string ChapterName { get; set; }
        public bool IsEnable { get; set; }
        public bool IsEnableTheme { get; set; }

        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Поле \"Мини описание\" должно быть обязательно заполнено")]
        public string MiniDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        
        [Required]
        public int CountReadTime { get; set; }

        //-------------------------------------
        public int Index { get; set; }
        public bool StatusNext { get; set; }
        public bool StatusPrevious { get; set; }
    }
}
