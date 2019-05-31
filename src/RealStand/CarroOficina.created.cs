using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class CarroOficina
    {
        public CarroOficina(string matricula, int kms, string numeroChassis, string marca, string modelo, string combustivel)
        {
            Matricula = matricula;
            Kms = kms;
            NumeroChassis = numeroChassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
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
            return Marca + " - " + Modelo + "(" + Matricula + ")";
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
            if (kms == null)
            {
                return false;
            }
            return true;
        }

        public static bool VerificaNumeroChassis(string numeroChassis)
        {
            if (numeroChassis.Length < 17 || numeroChassis == "")
            {
                return false;
            }
            return true;
        }

        public static bool VerificaMarca(string marca)
        {
            if (marca == "")
            {
                return false;
            }
            return true;
        }

        public static bool VerificaModelo(string modelo)
        {
            if (modelo == "")
            {
                return false;
            }
            return true;
        }
    }
}
