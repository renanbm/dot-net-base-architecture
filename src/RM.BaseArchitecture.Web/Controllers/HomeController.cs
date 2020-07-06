using System.Linq;
using RM.BaseArchitecture.Api.Proxy.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RM.BaseArchitecture.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteProxy _clienteProxy;

        public HomeController(IClienteProxy clienteProxy)
        {
            _clienteProxy = clienteProxy;
        }

        public IActionResult Index()
        {
            var cliente = _clienteProxy.ListarClientes().First();
            ViewData["Cliente"] = $"Nome: {cliente.Nome}  |  E-mail: {cliente.Email}  |  Data de Nascimento: {cliente.DataNascimento.ToShortDateString()}";
            return View();
        }
    }
}
