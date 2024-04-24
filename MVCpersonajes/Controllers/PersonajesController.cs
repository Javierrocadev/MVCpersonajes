using Microsoft.AspNetCore.Mvc;

namespace MVCpersonajes.Controllers
{
    public class PersonajesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PersonajesAjax()
        {
            return View();
        }
    }
}
