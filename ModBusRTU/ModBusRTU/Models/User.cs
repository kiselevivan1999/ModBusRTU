using System.ComponentModel.DataAnnotations;

namespace ModBusRTU.Models
{
    public class User
    {
        [Display(Name = "Имя:")]
        public string Name { get; set; }

        [Display(Name = "Фамилия:")]
        public string Surname { get; set; }

        [Display(Name = "E-mail:")]
        public string Email { get; set; }
        
        [Display(Name = "Пароль:")]
        public string Password { get; set; }
    }
}
