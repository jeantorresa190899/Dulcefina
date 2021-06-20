using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public string IdPago { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
