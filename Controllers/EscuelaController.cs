using System;
using ASP_NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetCore.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index(){
            Random rdm = new Random();

            return View(new Escuela(){
                EscuelaId = "1",
                Nombre = "Academia",
                AñoFundacion = DateTime.Now.AddYears(-rdm.Next(5)).Year.ToString()
            });
        }
    }
}