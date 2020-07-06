using System.Collections.Generic;

namespace RM.BaseArchitecture.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        IList<Entities.Cliente> ListarClientes();
    }
}