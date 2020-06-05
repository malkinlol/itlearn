using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Test
{
    public class TestVM
    {
        public int TestId { get; set; }

        [Required(ErrorMessage = "Поле \"Уровень\" должно быть обязательно заполнено")]
        [Range(1, 10, ErrorMessage = "Поле \"Уровень\" должно быть в пределах от 1 до 10")]
        public int Level { get; set; }

       
        //[Required(ErrorMessage = "Поле \"Тема\" должно быть обязательно заполнено")]
        public int ThemeId { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsCorrectTest { get; set; }

        public string ThemeName { get; set; }
        public string ChapterName { get; set; }
        public string LanguageName { get; set; }
    }
}
