﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    public partial class CarroOficina
    {
        public CarroOficina(string matricula, int kms, int numeroChassis, string marca, string modelo, string combustivel)
        {
            Matricula = matricula;
            Kms = kms;
            NumeroChassis = numeroChassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Servico = new HashSet<Servico>();
        }

        public override string ToString()
        {
            return Marca + " - " + Modelo + "(" + Matricula + ")";
        }
    }
}