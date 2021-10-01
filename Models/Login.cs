using System.ComponentModel.DataAnnotations;
namespace Turnos.Models
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Usuario.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar su Password")]
        public string Password { get; set; }
    }
}