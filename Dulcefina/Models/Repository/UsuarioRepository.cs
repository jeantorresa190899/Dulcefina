using Dulcefina.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Models.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ColegioContext db = new ColegioContext();
        public void Add(Cliente cliente)
        {
            try
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();  //Actualizar la tabla 
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public IEnumerable<Cliente> GetAllUsuarios()
        {
            return db.Clientes;
        }
        public int validar(Cliente cliente)
        {
            try
            {
                var Obj=(from tc in db.Clientes
                           where tc.Correo == cliente.Correo
                           select tc).FirstOrDefault();
                if (!"".Equals(Obj))
                {
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        /*  void Obtener1(Cliente cliente)
         {
             try
             {
                 var Obj = (from tc in db.Clientes
                            where tc.Correo == cliente.Correo
                            select tc).FirstOrDefault();
             // if(!"".Equals(Obj))

             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
         }*/




    }
}
