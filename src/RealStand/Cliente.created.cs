using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Cliente
    {
        public Cliente(string nome, string nIF, string morada, string contacto)
        {
            Nome = nome;
            NIF = nIF;
            Morada = morada;
            Contacto = contacto;
            CarroOficina = new HashSet<CarroOficina>();
            Venda = new HashSet<Venda>();
            Aluguer = new HashSet<Aluguer>();
        }

        public override string ToString()
        {
            return Nome + " (" + NIF + ")";
        }
    }
}
