using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        [Required(ErrorMessage = "Debe ingresar un Nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Apellido.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar una Dirección.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Email.")]
        [EmailAddress(ErrorMessage = "Dirección de email NO válido")]
        public string Email { get; set; }


        public ICollection<Turno> TurnoLista { get; set; }
    }
}