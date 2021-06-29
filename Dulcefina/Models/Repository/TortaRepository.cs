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

       // _TortaList = new List<Tortum>()=new Tortum();
      /*  public List<Tortum> GetAllTortum()
        {
            
            return _TortaList;
        }*/

        public IEnumerable<Tortum> GetAllTorta()
        {   
            return db.Torta.ToList();
        }

        public IEnumerable<Topping> GetAllTopping()
        {
            return db.Toppings.ToList();
        }

        public Tortum VerDetalleTorta(string codTorta)
        {
            var obj = (from d in db.Torta
                       where d.IdTorta == codTorta
                       select d).Single();
            return obj;
        }



    }
}
