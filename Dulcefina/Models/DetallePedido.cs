using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class DetallePedido
    {
        public string IdPedido { get; set; }
        public string IdTorta { get; set; }
        public string IdTop { get; set; }
        public string Mensaje { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Topping IdTopNavigation { get; set; }
        public virtual Tortum IdTortaNavigation { get; set; }
    }
}
