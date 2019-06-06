﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStand
{
    partial class window
    {
        bool newCarroAluguer = false;
        bool newAluguer = false;

        void ClearAluguerFields()
        {
            dateTimePickerDataInicioAluguer.ResetText();
            dateTimePickerDataFimAluguer.ResetText();
            textBoxQuilometragemAluguer.ResetText();
            maskedTextBoxValorAluguer.ResetText();
        }

        private void ClearVehicleDetails()
        {
            numeroChassisMaskedTextBox.ResetText();
            textBoxMarcaAluguer.ResetText();
            textBoxModeloAluguer.ResetText();
            comboBoxCombustivelAluguer.ResetText();
            estadoTextBox.ResetText();
            maskedTextBoxMatriculaAluguer.ResetText();
        }

        private void buttonCriarCarroAluguer_Click(object sender, EventArgs e)
        {
            newCarroAluguer = true;
            groupBoxAdicionarCarroAluguer.Enabled = true;
            buttonGuardarCarroAluguer.Visible = true;
        }

        private void buttonGuardarCarroAluguer_Click(object sender, EventArgs e)
        {
            if (newCarroAluguer)
            {
                CarroAluguer carroAluguer = new CarroAluguer(
                    estadoTextBox.Text, 
                    maskedTextBoxMatriculaAluguer.Text,
                    numeroChassisMaskedTextBox.Text,
                    textBoxMarcaAluguer.Text,
                    textBoxModeloAluguer.Text,
                    comboBoxCombustivelAluguer.Text
                    );
                standContainer.Carros.Add(carroAluguer);
            }
            else
            {
                CarroAluguer selectedCarroAluguer = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
                selectedCarroAluguer.NumeroChassis = numeroChassisMaskedTextBox.Text;
                selectedCarroAluguer.Marca = textBoxMarcaAluguer.Text;
                selectedCarroAluguer.Modelo = textBoxModeloAluguer.Text;
                selectedCarroAluguer.Combustivel = comboBoxCombustivelAluguer.Text;
                selectedCarroAluguer.Estado = estadoTextBox.Text;
                selectedCarroAluguer.Matricula = maskedTextBoxMatriculaAluguer.Text;
            }
            standContainer.SaveChanges();
            listBoxCarrosAluguer.DataSource = standContainer.Carros.OfType<CarroAluguer>().ToList();
            newCarroAluguer = false;
            groupBoxAdicionarCarroAluguer.Enabled = false;
            buttonGuardarCarroAluguer.Visible = false;
        }

        private void buttonCriarAluguer_Click(object sender, EventArgs e)
        {
            newAluguer = true;
            groupBoxAluguerCarro.Enabled = true;
            buttonGuardarAluguer.Visible = true;
        }

        private void buttonGuardarAluguer_Click(object sender, EventArgs e)
        {
            if (newAluguer)
            {
                Cliente selectedcliente = (Cliente)listBoxClientesAluguer.SelectedItem;
                CarroAluguer selectedCarroAluguer = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
                Aluguer newAluguer = new Aluguer(
                    DateTime.Parse(dateTimePickerDataInicioAluguer.Text),
                    DateTime.Parse(dateTimePickerDataFimAluguer.Text),
                    double.Parse(maskedTextBoxValorAluguer.Text.Replace('€', ' ')),
                    long.Parse(textBoxQuilometragemAluguer.Text),
                    selectedcliente,
                    selectedCarroAluguer
                );
                standContainer.Aluguers.Add(newAluguer);
            }
            else
            {
                // TODO
            }
            standContainer.SaveChanges();
            listBoxAluguer.DataSource = standContainer.Aluguers.ToList();
            newAluguer = false;
            groupBoxAluguerCarro.Enabled = false;
            buttonGuardarAluguer.Visible = false;
            ClearAluguerFields();
        }

        private void listBoxCarrosAluguer_Click(object sender, EventArgs e)
        {
            CarroAluguer selectedCarroAluguer = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            if (selectedCarroAluguer == null)
            {
                return;
            }
            numeroChassisMaskedTextBox.Text = selectedCarroAluguer.NumeroChassis;
            textBoxMarcaAluguer.Text = selectedCarroAluguer.Marca;
            textBoxModeloAluguer.Text = selectedCarroAluguer.Modelo;
            comboBoxCombustivelAluguer.Text = selectedCarroAluguer.Combustivel;
            estadoTextBox.Text = selectedCarroAluguer.Estado;
            maskedTextBoxMatriculaAluguer.Text = selectedCarroAluguer.Matricula;

            // Ativa os botoes de editar e apagar
            buttonEditarCarroAluguer.Enabled = true;
            buttonEliminarCarroAluguer.Enabled = true;
        }

        private void buttonEditarCarroAluguer_Click(object sender, EventArgs e)
        {
            groupBoxAdicionarCarroAluguer.Enabled = true;
            buttonGuardarCarroAluguer.Visible = true;
        }
    }
}
