using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class TanqueComun : Tanque
    {
        public override void recibirAtaque(decimal danio)
        {
            coraza -= danio;
        }

        public override void atacarTanque(Tanque tanque)
        {
            base.atacarTanque(tanque);
        }
    }
}
