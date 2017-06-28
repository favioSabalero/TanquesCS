using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    abstract class Tanque
    {
        public int nroTripulantes { get; set; }
        public List<Misil> misiles { get; set; }
        public decimal coraza { get; set; }

        public virtual void atacarTanque(Tanque tanque)
        {
            if (misiles.Count < 1)
                throw new Exception("No hay misiles");
            var misil = misiles.First();
            misil.danio(tanque);
            misiles.Remove(misil);
        }

        public abstract void recibirAtaque(decimal danio);

        public bool emiteCalor()
        {
            return nroTripulantes > 5;
        }

        public bool vivo()
        {
            return coraza > 0;
        }

        public bool armado()
        {
            return vivo() && misiles.Count > 0;
        }

        public void atacarUnidad(Unidad unidad)
        {
            atacarTanque(unidad.tanquesVivos().First());
        }
    }
}
