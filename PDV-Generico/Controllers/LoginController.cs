using Microsoft.AspNetCore.Mvc;
using PDV_Generico.Models.Funcionario;
using System.Web;

namespace PDV_Generico.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult EsqueciSenha()
        {
            return View();
        }
        [HttpPost]
        public void ChecarLogin(FuncionarioLoginModel funcionario)
        {
            if(funcionario.Login())
            {
                if (funcionario.funcao == "Admin")
                {
                    Response.Redirect("/Admin/Home");
                }
                else
                {
                    Response.Redirect("/Funcionario/Home");
                }
            }
            else
            {
                Response.Redirect("/Login/Login");
            }
        }
    }
}
