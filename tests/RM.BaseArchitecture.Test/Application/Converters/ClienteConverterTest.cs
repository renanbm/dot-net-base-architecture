using System;
using RM.BaseArchitecture.Application.Mapper;
using RM.BaseArchitecture.Domain.Value_Objects;
using RM.BaseArchitecture.Dto;
using Xunit;
using Cliente = RM.BaseArchitecture.Domain.Entities.Cliente;

namespace RM.BaseArchitecture.Test.Application.Converters
{
    public class ClienteConverterTest
    {
        [Fact]
        public void Converter_Converte_Dto_Para_Domain()
        {
            var clienteDto = new ClienteViewModel
            {
                Nome = "Renan Ben Moshe",
                Email = "renan.moshe@gmail.com",
                DataNascimento = new DateTime(1990, 11, 28)
            };

            var clienteDomain = clienteDto.ToDomain();

            Assert.True(clienteDomain.Nome == "Renan Ben Moshe");
            Assert.True(clienteDomain.Email.Endereco == "renan.moshe@gmail.com");
            Assert.True(clienteDomain.DataNascimento == new DateTime(1990, 11, 28));
        }

        [Fact]
        public void Converter_Converte_Domain_Para_Dto()
        {
            var clienteDomain = new Cliente
            {
                Nome = "Renan Ben Moshe",
                Email = new Email("renan.moshe@gmail.com"),
                DataNascimento = new DateTime(1990, 11, 28)
            };

            var clienteDto = clienteDomain.ToViewModel();

            Assert.True(clienteDto.Nome == "Renan Ben Moshe");
            Assert.True(clienteDto.Email == "renan.moshe@gmail.com");
            Assert.True(clienteDto.DataNascimento == new DateTime(1990, 11, 28));
        }
    }
}
