using System.Collections.Generic;

namespace Core.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ICollection<Contacto> Contactos { get; set; }
    }
}
