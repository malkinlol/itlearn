using System.ComponentModel.DataAnnotations;

namespace itlearn.model.ViewModels.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "E-mail обязательное поле")]
        [StringLength(70, ErrorMessage = "Длина e-mail не должна превышать 70 символов")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль обязательное поле")]
        [StringLength(30, ErrorMessage = "Длина пароля не должна превышать 30 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Повторите пароль обязательное поле")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
