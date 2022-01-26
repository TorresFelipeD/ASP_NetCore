using System;
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
    }
}