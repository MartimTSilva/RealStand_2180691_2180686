using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Servico
    {
        public Servico(string tipo)
        {
            Tipo = tipo;
            this.Parcela = new HashSet<Parcela>();
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
