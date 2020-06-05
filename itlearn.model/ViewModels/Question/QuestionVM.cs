using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Question
{
    public class QuestionVM
    {
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Поле \"Вопрос\" должно быть обязательно заполнено")]
        [StringLength(200, ErrorMessage = "Длина поля \"Вопрос\" не должно превышать 200 символов")]
        public string SomeQuestion { get; set; }

        [Required(ErrorMessage = "Поле \"Тест\" должно быть обязательно заполнено")]
        public int TestId { get; set; }

        public bool IsCorrectQuestion { get; set; }

        public string Avatar { get; set; }
        public string ThemeName { get; set; }
        public string ChapterName { get; set; }
        public string LanguageName { get; set; }
    }
}
