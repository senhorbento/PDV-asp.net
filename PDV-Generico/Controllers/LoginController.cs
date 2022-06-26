using Microsoft.AspNetCore.Mvc;
using PDV_Generico.Models;

namespace PDV_Generico.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void ChecarLogin()
        {
            //Falta receber os dados do html
            Usuario checagem = new Usuario();
            checagem.usuario = "opa";
            checagem.senha = "123";

            if(checagem.Login())
            {
                Response.Redirect("/Admin/Index");
            }
            else
            {
                Response.Redirect("/Login/Index");
            }
        }

    }
}
