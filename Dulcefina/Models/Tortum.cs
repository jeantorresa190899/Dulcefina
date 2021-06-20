using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Tortum
    {
        public Tortum()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string IdTorta { get; set; }
        public string Porcion { get; set; }
        public string Sabor { get; set; }
        public string Relleno { get; set; }
        public string Color { get; set; }
        public decimal? Precio { get; set; }
        public string Foto { get; set; }
        public string IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
