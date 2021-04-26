using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DbInitializer
    {
        public static void Initialize(DefaultDbContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "79498812241"
                },
                new Cliente
                {
                    Nome = "Beltrano da Silva",
                    CPF = "28593621007"
                }
            };

            context.AddRange(clientes);

            var contactos = new Contacto[]
            {
                new Contacto
                {
                    Nome = "COntacto 1",
                    Telefone = "999999999",
                    Email = "emailcontacto1@teste.com",
                    Cliente = clientes[0]
                },
                new Contacto
                {
                    Nome = "COntacto 2",
                    Telefone = "333333",
                    Email = "emailcontacto2@teste.com",
                    Cliente = clientes[1]
                },
            };

            context.AddRange(contactos);

            context.SaveChanges();
        }
    }
}
