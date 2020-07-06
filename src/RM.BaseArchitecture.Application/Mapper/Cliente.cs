using RM.BaseArchitecture.Domain.Value_Objects;
using RM.BaseArchitecture.Dto;

namespace RM.BaseArchitecture.Application.Mapper
{
    public static class Cliente
    {
        public static Domain.Entities.Cliente ToDomain(this ClienteViewModel viewModel)
        {
            return new Domain.Entities.Cliente
            {
                Nome = viewModel.Nome,
                DataNascimento = viewModel.DataNascimento,
                Email = new Email(viewModel.Email)
            };
        }

        public static ClienteViewModel ToViewModel(this Domain.Entities.Cliente domain)
        {
            return new ClienteViewModel
            {
                Nome = domain.Nome,
                DataNascimento = domain.DataNascimento,
                Email = domain.Email.Endereco
            };
        }
    }
}