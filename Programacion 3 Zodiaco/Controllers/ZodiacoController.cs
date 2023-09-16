using Microsoft.AspNetCore.Mvc;
using Programacion_3_Zodiaco.Models;

namespace Programacion_3_Zodiaco.Controllers
{
    public class ZodiacoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FechaViewModel dato)
        {
            string resultado = ZodiacoViewModel.Signo(dato.datetime);
            ViewData["message"] = resultado;
            return View();
        }
    }
}
