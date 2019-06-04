using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class CarroVenda
    {
        public CarroVenda()
        {
        }

        public CarroVenda(
            string extras, string numeroChassis, string marca, string modelo, string combustivel) :
            base(numeroChassis, marca, modelo, combustivel)
        {
            Extras = extras;
        }
    }
}
