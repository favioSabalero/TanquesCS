using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class CoheteGroso : Misil
    {
        public override void danio(Tanque tanque)
        {
            tanque.recibirAtaque(tanque.coraza);
        }
    }
}
