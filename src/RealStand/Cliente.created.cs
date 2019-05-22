using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Cliente
    {
        public Cliente(string nome, int nIF, string morada, string contacto)
        {
            Nome = nome;
            NIF = nIF;
            Morada = morada;
            Contacto = contacto;
            CarroOficina = new HashSet<CarroOficina>();
        }

        public override string ToString()
        {
            return Nome + " (" + NIF + ")";
        }
    }
}
