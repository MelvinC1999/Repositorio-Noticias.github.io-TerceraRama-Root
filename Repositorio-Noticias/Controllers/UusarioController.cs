using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Configuration;
using Repositorio_Noticias.LogicaNegocio;
using Repositorio_Noticias.Models;

namespace Repositorio_Noticias.Controllers
{
    public class UusarioController : Controller
    {
        private UsuarioBL _usuarioLogicaNegocio;
        private IConfiguration _configuration;

        public UusarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Noticia1()
        {
            return View("~/Views/Noticias/Noticia1.cshtml");
        }

        public IActionResult UsuarioController()
        {
            string cadenaConexion = _configuration.GetConnectionString("MiConexion");
            _usuarioLogicaNegocio = new UsuarioBL(cadenaConexion);
            return View();
        }
    }
}
