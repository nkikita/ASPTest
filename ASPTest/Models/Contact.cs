using System.ComponentModel.DataAnnotations;

namespace ASPTest.Models
{
    public class Contact
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage ="NOOOOOOOOOOOOOOOOOOOOOOI")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "NOOOOOOOOOOOOOOOOOOOOOOI")]
        public string Email { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "NOOOOOOOOOOOOOOOOOOOOOOI")]
        public int Age{ get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "NOOOOOOOOOOOOOOOOOOOOOOI")]
        public string Mess { get; set; }
    }
}
