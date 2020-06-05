using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "E-mail обязательное поле.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль обязательное поле.")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
