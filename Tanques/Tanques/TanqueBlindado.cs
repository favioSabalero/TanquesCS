using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class TanqueBlindado : Tanque
    {
        public decimal blindaje { get; set; }
        public override void recibirAtaque(decimal danio)
        {
            coraza -= danio + blindaje;
        }
        public override void atacarTanque(Tanque tanque)
        {
            base.atacarTanque(tanque);
            blindaje--;
        }
    }
}
