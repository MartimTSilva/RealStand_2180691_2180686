using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class CarroOficina
    {
        public CarroOficina(string matricula, int kms, string numeroChassis, string marca, string modelo, string combustivel) :
            base(numeroChassis, marca, modelo, combustivel)
        {
            Matricula = matricula;
            Kms = kms;
            Servico = new HashSet<Servico>();
        }

        public float GetTotal()
        {
            float total = 0;
            foreach (Servico servico in this.Servico.ToList())
            {
                total += servico.GetTotal();
            }
            return total;
        }

        public override string ToString()
        {
            return Marca + " - " + Modelo + " (" + Matricula + ")";
        }

        public static bool VerificaMatricula(string matricula)
        {
            if (matricula == "" || matricula.Length != 8)
            {
                return false;
            }
            return true;
        }

        public static bool VerificaKMs(int kms)
        {
            if (kms == 0)
            {
                return false;
            }
            return true;
        }
    }
}
