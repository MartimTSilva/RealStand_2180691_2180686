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

        public float GetTotal()
        {
            float total = 0;
            foreach (CarroOficina carro in this.CarroOficina.ToList())
            {
                total += carro.GetTotal();
            }
            return total;
        }

        public override string ToString()
        {
            return Nome + " (" + NIF + ")";
        }

        public static List<Cliente> SearchClientByName(StandContainer standContainer, string searchName)
        {
            return (from Cliente in standContainer.Clientes
                    where Cliente.Nome.Contains(searchName)
                    select Cliente).ToList();
        }

        public static List<Cliente> SearchClientByNIF(StandContainer standContainer, string searchNIF)
        {
            return (from Cliente in standContainer.Clientes
                    where Cliente.NIF.Contains(searchNIF)
                    select Cliente).ToList();
        }

        public static bool CheckName(string name)
        {
            if (name == "")
            {
                return false;
            }
            return true;
        }

        public static bool CheckNIF(string nif)
        {
            if (nif.Length != 9)
            {
                return false;
            }
            return true;
        }

        public static bool CheckMorada(string morada)
        {
            if (morada == "")
            {
                return false;
            }
            return true;
        }

        public static bool CheckContacto(string contacto)
        {
            if (contacto.Length != 9)
            {
                return false;
            }
            return true;
        }
    }
}
