using System.Collections.Generic;
using RM.BaseArchitecture.Application.Interfaces;
using RM.BaseArchitecture.Dto;
using Microsoft.AspNetCore.Mvc;

namespace RM.BaseArchitecture.Soa.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        [Route(nameof(ListarClientes))]
        public IList<ClienteViewModel> ListarClientes()
        {
            return _clienteAppService.ListarClientes();
        }
    }
}
