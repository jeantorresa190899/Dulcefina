using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Entrega
    {
        public Entrega()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public string IdEntrega { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
