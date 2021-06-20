using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Topping
    {
        public Topping()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string IdTop { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
