using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class Carro
    {
        public static bool VerificaCombustivel(int combustivelIndex)
        {
            if (combustivelIndex == -1)
            {
                return false;
            }
            return true;
        }
    }
}
