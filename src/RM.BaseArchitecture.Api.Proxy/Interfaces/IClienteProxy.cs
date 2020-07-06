using System.Collections.Generic;
using RM.BaseArchitecture.Dto;

namespace RM.BaseArchitecture.Api.Proxy.Interfaces
{
    public interface IClienteProxy
    {
        IList<ClienteViewModel> ListarClientes();
    }
}