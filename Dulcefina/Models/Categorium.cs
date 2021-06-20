using System;
using System.Collections.Generic;

namespace Dulcefina.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Torta = new HashSet<Tortum>();
        }

        public string IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Tortum> Torta { get; set; }
    }
}
