using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Turnos.Data;
using Turnos.Models;

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

        public JsonResult obtenerTurnos(int idMedico, int idPaciente)
        {
            /* List<Turno> turnos = new List<Turno>();
            turnos = _context.Turno.Where(t => t.IdMedico == idMedico && t.IdPaciente == idPaciente).ToList(); */
            var turnos = _context.Turno.Where(t => t.IdMedico == idMedico && t.IdPaciente == idPaciente)
            .Select(t => new
            {
                t.IdTurno,
                t.IdMedico,
                t.IdPaciente,
                t.FechaHoraInicio,
                t.FechaHoraFin,
                paciente = t.Paciente.Nombre + " " + t.Paciente.Apellido,
                medico = t.Medico.Nombre + " " + t.Medico.Apellido
            })
            .ToList();


            return Json(turnos);
        }

        [HttpPost]
        public JsonResult GrabarTurno(Turno turno)
        {
            //return Json(turno);
            var ok = false;
            try
            {
                _context.Turno.Add(turno);
                _context.SaveChanges();
                ok = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("{0}: Excepción encontrada", e);
            }

            var jsonResult = new { ok = ok };
            return Json(jsonResult);
        }

        [HttpPost]
        public JsonResult EliminarTurno(int idTurno)
        {
            var ok = false;
            try
            {
                var turnoEliminar = _context.Turno.Where(t => t.IdTurno == idTurno).FirstOrDefault();
                if (turnoEliminar != null)
                {
                    _context.Turno.Remove(turnoEliminar);
                    _context.SaveChanges();
                    ok = true;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("{0}: Excepción encontrada", e);
            }

            var jsonResult = new { ok = ok };
            return Json(jsonResult);
        }

    }
}