using Dulcefina.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Models.Repository
{
    public class CarritoRepository: ICarritoRepository
    {
        ColegioContext db = new ColegioContext();

        public void Add(DetallePedido detalle)
        {
            try
            {
                db.DetallePedidos.Add(detalle);
                db.SaveChanges();
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
