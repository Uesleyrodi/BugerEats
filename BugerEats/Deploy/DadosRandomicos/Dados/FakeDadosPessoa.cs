using Bogus;
using Bogus.Extensions.Brazil;
using System.Collections.Generic;

namespace BugerEats.Deploy
{
    public class FakeDadosPessoa
    {
        public static List<Pessoa> ListaPessoasFake()
        {
            var pessoaFaker = new Faker<Pessoa>("pt_BR")
                .RuleFor(p => p.Nome, f => f.Person.FullName)
                .RuleFor(p => p.Cpf, f => f.Person.Cpf())
                .RuleFor(p => p.Email, f => f.Internet.Email(f.Person.FirstName).ToLower())
                .RuleFor(p => p.WhatsApp, f => f.Person.Phone);
            var pessoa = pessoaFaker.Generate(1);

            return pessoa;
        }
    }
}
