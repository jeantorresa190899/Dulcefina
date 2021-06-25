using Dulcefina.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Models.Repository
{
    public class TortaRepository: ITortaRepository
    {
       

        ColegioContext db = new ColegioContext();
        public IEnumerable<Tortum> GetAllTorta()
        {   
            return db.Torta.ToList();
        }

        public IEnumerable<Topping> GetAllTopping()
        {
            return db.Toppings.ToList();
        }
    


    }
}
