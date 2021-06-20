using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string IdPedido { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public string IdEntrega { get; set; }
        public int? IdCliente { get; set; }
        public string IdPago { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Entrega IdEntregaNavigation { get; set; }
        public virtual MetodoPago IdPagoNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
