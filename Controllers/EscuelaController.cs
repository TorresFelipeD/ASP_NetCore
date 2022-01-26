using System;
using ASP_NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetCore.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index(){
            Random rdm = new Random();

            return View(new Escuela(
                NombreEscuela: "Academia",
                AñoGraduacion: DateTime.Now.AddYears(-rdm.Next(5)).Year
            ));
        }
    }
}