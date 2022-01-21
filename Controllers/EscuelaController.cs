using Microsoft.AspNetCore.Mvc;

namespace ASP_NetCore.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}