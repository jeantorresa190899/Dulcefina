using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int? Dni { get; set; }
        public string Domicilio { get; set; }
        public int? Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
