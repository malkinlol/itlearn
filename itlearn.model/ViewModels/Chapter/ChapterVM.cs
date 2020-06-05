using itlearn.model.ViewModels.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Chapter
{
    public class ChapterVM
    {
        public int ChapterId { get; set; }

        [Required(ErrorMessage = "Поле \"Название\" должно быть обязательно заполнено")]
        [StringLength(50, ErrorMessage = "Длина поля \"Название\" не должно превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле \"Язык программирования\" должно быть обязательно заполнено")]
        public int LanguageId { get; set; }

        public string LanguageName { get; set; }

        public List<LanguageVM> Languages { get; set; }

        public bool IsEnable { get; set; }
    }
}
