using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Answer
{
    public class AnswerVM
    {
        public int AnswerId { get; set; }

        [Required(ErrorMessage = "Поле \"Ответ\" должно быть обязательно заполнено")]
        [StringLength(200, ErrorMessage = "Длина поля \"Ответ\" не должно превышать 200 символов")]
        public string SomeAnswer { get; set; }

        public bool IsRight { get; set; }

        [Required(ErrorMessage = "Поле \"Вопрос\" должно быть обязательно заполнено")]
        public int QuestionId { get; set; }

        public string QuestionName { get; set; }
        public string ThemeName { get; set; }
        public string ChapterName { get; set; }
        public string LanguageName { get; set; }
    }
}
