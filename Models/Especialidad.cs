using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }

        [StringLength(200, ErrorMessage = "La descripción debe tener como máximo 200 caracteres")]
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        [Display(Name = "Descripción", Prompt = "Ingrese una descripción")]
        public string Descripcion { get; set; }

        public ICollection<Medico> MedicoLista { get; set; }
    }
}