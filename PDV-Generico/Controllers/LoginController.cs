using Microsoft.AspNetCore.Mvc;

namespace PDV_Generico.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
