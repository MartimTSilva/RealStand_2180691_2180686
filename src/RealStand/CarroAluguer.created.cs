using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class CarroAluguer
    {
        public CarroAluguer(string estado, string matricula, string numeroChassis, string marca, string modelo, string combustivel) :
            base(numeroChassis, marca, modelo, combustivel)
        {
            Estado = estado;
            Matricula = matricula;
            Aluguer = new HashSet<Aluguer>();
        }

        public override string ToString()
        {
            return Matricula;
        }
    }
}
