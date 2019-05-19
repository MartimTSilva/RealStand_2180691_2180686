using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class CarroOficina
    {
        public CarroOficina(string matricula, short kms, int clienteId)
        {
            Matricula = matricula;
            Kms = kms;
            ClienteId = clienteId;
        }
    }
}
