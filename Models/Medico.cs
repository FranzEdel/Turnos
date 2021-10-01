using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

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

        [Display(Name = "Horario desde")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraAtencionDesde { get; set; }

        [Display(Name = "Horario hasta.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraAtencionHasta { get; set; }

        public int IdEspecialidad { get; set; }
        public Especialidad Especialidad { get; set; }

        public ICollection<Turno> TurnoLista { get; set; }

    }
}