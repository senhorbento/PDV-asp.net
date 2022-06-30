using Microsoft.AspNetCore.Mvc;
using PDV_Generico.Models;
using System.Web;

namespace PDV_Generico.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()

        {
            return View();
        }

        public IActionResult EsqueciSenha()
        {
            return View();
        }

        public IActionResult NovoUsuario()
        {
            return View();
        }

        [HttpPost]
        public void ChecarLogin(string BxUsuario, string BxSenha)
        {
            Funcionario checagem = new Funcionario();
            checagem.usuario = BxUsuario;
            checagem.senha = BxSenha;

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
