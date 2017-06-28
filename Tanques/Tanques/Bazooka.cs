using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanques
{
    class Bazooka : Misil
    {
        public int cabezasNucleares { get; set; }
        public override void danio(Tanque tanque)
        {
            tanque.recibirAtaque(cabezasNucleares * 2);
        }
    }
}
