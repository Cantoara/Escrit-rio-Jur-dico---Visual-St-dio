using Escritório_Jurídico___Visual_Stúdio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Escritório_Jurídico___Visual_Stúdio.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly ILogger<AgendamentoController> _logger;

        public AgendamentoController(ILogger<AgendamentoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AgendamentoUsuario()
        {
            return View();
        }
        public IActionResult CadastroAgendamento()
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
