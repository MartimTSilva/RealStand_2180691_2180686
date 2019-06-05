using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Aluguer
    {
        public Aluguer()
        {
        }

        public Aluguer(DateTime dataInicio, DateTime dataFim, double valor, long kms, Cliente cliente, CarroAluguer carroAluguer)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Valor = valor;
            Kms = kms;
            Cliente = cliente;
            CarroAluguer = carroAluguer;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
