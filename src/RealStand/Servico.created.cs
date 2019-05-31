using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class Servico
    {
        public Servico(DateTime dataEntrega, string tipo, DateTime dataSaida)
        {
            DataEntrega = dataEntrega;
            Tipo = tipo;
            DataSaida = dataSaida;
            Parcela = new HashSet<Parcela>();
        }

        public float GetTotal()
        {
            float total = 0;
            foreach (Parcela parcela in this.Parcela.ToList())
            {
                total += (float)parcela.Valor;
            }
            return total;
        }

        public override string ToString()
        {
            return Tipo + " (" + DataEntrega + ")";
        }

        public static bool VerificaDatasServico(DateTime DataEntrada, DateTime DataSaida)
        {
            if (DataEntrada.Date > DataSaida.Date)
            {
                return false;
            }
            return true;
        }
        public static bool VerificaTipoServico(string TipoServico)
        {
            if (TipoServico == "")
            {
                return false;
            }
            return true;
        }
    }
}
