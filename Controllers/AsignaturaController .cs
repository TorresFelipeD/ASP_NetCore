using System;
using System.Collections.Generic;
using ASP_NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetCore.Controllers
{
    public class AsignaturaController  : Controller
    {
        public IActionResult Index()
        {
            Random rdm = new Random();
            Asignatura asignatura = new Asignatura(){
                Nombre = "Matematicas"
            };

            return View(asignatura);
        }

        public IActionResult MultiAsignatura(){
            var listAsignatura = new List<Asignatura>(){
                new Asignatura(){Nombre = "Programación"},
                new Asignatura(){Nombre = "Algebra"},
                new Asignatura(){Nombre = "Historia"},
                new Asignatura(){Nombre = "Ciencias"}
            };
            return View(listAsignatura);
        }
    }
}