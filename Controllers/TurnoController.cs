using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Turnos.Data;

namespace Turnos.Controllers
{
    public class TurnoController : Controller
    {
        private readonly TurnosContext _context;
        private IConfiguration _configuration;
        public TurnoController(TurnosContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["IdMedico"] = new SelectList((from medico in _context.Medico.ToList() select new { IdMedico = medico.IdMedico, NombreCompleto = medico.Nombre + " " + medico.Apellido }), "IdMedico", "NombreCompleto");

            ViewData["IdPaciente"] = new SelectList((from paciente in _context.Paciente.ToList() select new { IdPaciente = paciente.IdPaciente, NombreCompleto = paciente.Nombre + " " + paciente.Apellido }), "IdPaciente", "NombreCompleto");

            return View();
        }
    }
}