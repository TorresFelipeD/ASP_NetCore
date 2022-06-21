using Microsoft.AspNetCore.Mvc;
using ASP_NetCore.Models;
using System.Collections.Generic;
using System.Linq;
using ASP_NetCore.Models.InMemory;

namespace ASP_NetCore.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno/Index/{Id?}")]
        public IActionResult Index(string Id)
        {
            var AlumnoObj = (from alum in _context.Alumnos
                                 where alum.Id == Id
                                 select alum).SingleOrDefault();

            if (string.IsNullOrEmpty(Id))
            {
                return View("MultiAlumno",_context.Alumnos.ToList());
            }
            else
            {
                return View(AlumnoObj);
            }
        }

        public IActionResult MultiAlumno()
        {
            List<Alumno> alumnos = GenerarAlumnos(7);

            return View(_context.Alumnos.ToList());
        }

        private List<Alumno> GenerarAlumnos(int cantidad = 20)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno() { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((x) => x.Id).Take(cantidad).ToList();
        }

        private readonly EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}