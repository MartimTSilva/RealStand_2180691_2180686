using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Parcela
    {
        public Parcela()
        {
        }

        public Parcela(decimal valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao + " (" + Valor.ToString("0.00") + "€" + ")";
        }
    }
}
