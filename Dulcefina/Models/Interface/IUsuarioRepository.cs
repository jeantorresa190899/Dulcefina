using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Models.Interface
{
    public interface IUsuarioRepository
    {
        IEnumerable<Cliente> GetAllUsuarios();
        void Add(Cliente cliente);
    }
}
