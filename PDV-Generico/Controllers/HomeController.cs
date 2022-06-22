using Microsoft.AspNetCore.Mvc;
using PDV_Generico.Models;
using System.Diagnostics;

namespace PDV_Generico.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Venda()
        {
            return View();
        }
        public IActionResult Compra()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult Fornecedor()
        {
            return View();
        }
        public IActionResult Estoque()
        {
            return View();
        }

        public IActionResult Conta()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}