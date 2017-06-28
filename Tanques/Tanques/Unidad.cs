using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class Unidad
    {
        public List<Tanque> tanques { get; set; }

        public List<Misil> misilesSinDisparar()
        {
            var misilesSin = new List<Misil>();
            tanques.ForEach(tanque => misilesSin.AddRange(tanque.misiles));
            /*return tanques.Aggregate(new List<Misil>(), 
                (misiles, t) => 
                { 
                    misiles.AddRange(t.misiles); 
                    return misiles; 
                });*/
            return misilesSin;
        }

        public List<Tanque> tanquesVivos()
        {
            return tanques.Where(t => t.vivo()).ToList();
        }

        public List<Tanque> tanquesArmados()
        {
            return tanques.Where(t => t.armado()).ToList();
        }

        public void atacarUnidad(Unidad unidad)
        {
            tanquesArmados().ForEach(tanque => tanque.atacarUnidad(unidad));
        }
    }
}
