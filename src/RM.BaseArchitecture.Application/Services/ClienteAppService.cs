using System.Collections.Generic;
using System.Linq;
using RM.BaseArchitecture.Application.Interfaces;
using RM.BaseArchitecture.Domain.Interfaces.Repository;
using RM.BaseArchitecture.Dto;

namespace RM.BaseArchitecture.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IList<ClienteViewModel> ListarClientes()
        {
            var clientes = _clienteRepository.ListarClientes();
            return clientes.Select(Mapper.Cliente.ToViewModel).ToList();
        }
    }
}