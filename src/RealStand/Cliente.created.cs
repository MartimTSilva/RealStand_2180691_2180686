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

        public string GetTotal()
        {
            float total = 0;
            foreach (CarroOficina carro in this.CarroOficina.ToList())
            {
                total += carro.GetTotal();
            }
            return total.ToString("0.00€");
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

        public static bool CheckMorada(string morada)
        {
            if (morada == "")
            {
                return false;
            }
            return true;
        }

        public static bool CheckDuplicateNIF(StandContainer standContainer, string NIF)
        {
            if ((from Cliente in standContainer.Clientes
                        where Cliente.NIF.Equals(NIF)
                        select Cliente).Count() >= 1 || NIF.Length != 9)
            {
                return true;
            }
            return false;
        }

        public static bool CheckDuplicatePhoneNumber(StandContainer standContainer, string phoneNumber)
        {
            if ((from Cliente in standContainer.Clientes
                 where Cliente.Contacto.Equals(phoneNumber)
                 select Cliente).Count() >= 1 || phoneNumber.Length != 9)
            {
                return true;
            }
            return false;
        }
    }
}
