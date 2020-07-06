using System;
using RM.BaseArchitecture.Domain.Value_Objects;

namespace RM.BaseArchitecture.Domain.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Email Email { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
