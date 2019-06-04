using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Venda
    {
        public Venda()
        {
        }

        public Venda(double valor, string estado, DateTime data, CarroVenda carroVenda)
        {
            Valor = valor;
            Estado = estado;
            Data = data;
            CarroVenda = carroVenda;
        }

        public override string ToString()
        {
            return CarroVenda.Marca + " - " + CarroVenda.Modelo + " (" + Data.ToString("dd-MM-yyyy") + ")";
        }
    }
}
