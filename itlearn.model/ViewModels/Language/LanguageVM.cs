using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Language
{
    public class LanguageVM
    {
        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Поле \"Название\" должно быть обязательно заполнено")]
        [StringLength(50, ErrorMessage = "Длина поля \"Название\" не должно превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле \"Описание\" должно быть обязательно заполнено")]
        [StringLength(10000, ErrorMessage = "Длина поля \"Описание\" не должно превышать 10000 символов")]
        public string Description { get; set; }

        public string Avatar { get; set; }

        public bool IsEnable { get; set; }
    }
}
