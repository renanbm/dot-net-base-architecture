using System.Collections.Generic;
using RM.BaseArchitecture.Dto;

namespace RM.BaseArchitecture.Application.Interfaces
{
    public interface IClienteAppService
    {
        IList<ClienteViewModel> ListarClientes();
    }
}