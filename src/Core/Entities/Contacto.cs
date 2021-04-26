using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Contacto
    {
        public Contacto()
        {

        }

        public int ContactoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
