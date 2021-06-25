using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Models.Interface
{
    public interface ITortaRepository
    {
        IEnumerable<Tortum> GetAllTorta();

        IEnumerable<Topping> GetAllTopping();

    }
}
