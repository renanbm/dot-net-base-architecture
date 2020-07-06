using System;
using System.Collections.Generic;
using RM.BaseArchitecture.Domain.Interfaces.Repository;
using RM.BaseArchitecture.Domain.Value_Objects;

namespace RM.BaseArchitecture.Infrastructure.Data
{
    public class ClienteRepository : IClienteRepository
    {
        public IList<Domain.Entities.Cliente> ListarClientes()
        {
            var clientes = new List<Domain.Entities.Cliente>();

            clientes.Add(new Domain.Entities.Cliente
            {
                Email = new Email("renan.moshe@gmail.com"),
                DataNascimento = new DateTime(1990, 11, 28),
                Nome = "Renan Ben Moshe"
            });

            return clientes;
        }
    }
}
