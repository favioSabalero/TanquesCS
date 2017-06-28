using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class MisilTermico : Misil
    {
        public override void danio(Tanque tanque)
        {
            if (tanque.emiteCalor())
                tanque.recibirAtaque(20);
        }
    }
}
