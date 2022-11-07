using System.ComponentModel.DataAnnotations;

namespace ModBusRTU.Models
{
    public class User
    {
        [Display(Name = "Имя:")]
        [Required(ErrorMessage ="Введите имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия:")]
        [Required(ErrorMessage = "Введите фамилию")]
        public string Surname { get; set; }

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Введите почту")]
        public string Email { get; set; }
        
        [Display(Name = "Пароль:")]
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
    }
}
