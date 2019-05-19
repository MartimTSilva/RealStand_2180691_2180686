using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Cliente
    {
        public Cliente(string nome, short nIF)
        {
            Nome = nome;
            NIF = nIF;
            CarroOficina = new HashSet<CarroOficina>();
        }

        public int getTotal()
        {
            return CarroOficina.Count;
        }

        public override string ToString()
        {
            return Nome + " (" + NIF + ")";
        }
    }
}
