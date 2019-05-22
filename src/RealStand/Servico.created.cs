using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Servico
    {
        public Servico(DateTime dataEntrega, string tipo, DateTime dataSaida, ICollection<Parcela> parcela)
        {
            DataEntrega = dataEntrega;
            Tipo = tipo;
            DataSaida = dataSaida;
            this.Parcela = new HashSet<Parcela>();
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
