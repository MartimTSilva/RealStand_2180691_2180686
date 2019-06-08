using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            groupBoxCarroAluguer.Enabled = true;
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
            groupBoxCarroAluguer.Enabled = false;
            buttonGuardarCarroAluguer.Visible = false;
        }

        private void buttonCriarAluguer_Click(object sender, EventArgs e)
        {
            newAluguer = true;
            groupBoxAluguer.Enabled = true;
            buttonGuardarAluguer.Visible = true;
        }

        private void buttonGuardarAluguer_Click(object sender, EventArgs e)
        {
            Cliente selectedcliente = (Cliente)listBoxClientesAluguer.SelectedItem;
            if (newAluguer)
            {
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
                Aluguer selectedAluguer = (Aluguer)listBoxAluguer.SelectedItem;
                selectedAluguer.DataInicio = dateTimePickerDataInicioAluguer.Value;
                selectedAluguer.DataFim = dateTimePickerDataFimAluguer.Value;
                selectedAluguer.Kms = long.Parse(textBoxQuilometragemAluguer.Text);
                selectedAluguer.Valor = double.Parse(maskedTextBoxValorAluguer.Text.Replace('€', ' '));
            }
            standContainer.SaveChanges();
            listBoxAluguer.DataSource = standContainer.Aluguers.ToList();
            labelTotalGastoAluguer.Text = selectedcliente.GetTotalAluguer();
            newAluguer = false;
            groupBoxAluguer.Enabled = false;
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
            groupBoxCarroAluguer.Enabled = true;
            buttonGuardarCarroAluguer.Visible = true;
        }

        private void listBoxAluguer_Click(object sender, EventArgs e)
        {
            Aluguer selectedAluguer = (Aluguer)listBoxAluguer.SelectedItem;
            if (selectedAluguer == null)
            {
                return;
            }

            dateTimePickerDataInicioAluguer.Value = selectedAluguer.DataInicio;
            dateTimePickerDataFimAluguer.Value = selectedAluguer.DataFim;
            textBoxQuilometragemAluguer.Text = selectedAluguer.Kms.ToString();
            maskedTextBoxValorAluguer.Text = selectedAluguer.Valor.ToString();

            // Ativa os botoes de editar e apagar
            buttonEditarAluguer.Enabled = true;
            buttonEliminarAluguer.Enabled = true;
        }

        private void buttonEditarAluguer_Click(object sender, EventArgs e)
        {
            groupBoxAluguer.Enabled = true;
            buttonGuardarAluguer.Visible = true;
        }

        private void buttonEliminarCarroAluguer_Click(object sender, EventArgs e)
        {
            CarroAluguer selectedCarroAluguer = (CarroAluguer)listBoxCarrosAluguer.SelectedItem;
            standContainer.Carros.Remove(selectedCarroAluguer);
            standContainer.SaveChanges();
            listBoxCarrosAluguer.DataSource = standContainer.Carros.OfType<CarroAluguer>().ToList();
            listBoxCarrosAluguer.SelectedIndex = -1;

            // Desativa os botoes de editar e eliminar
            buttonEditarCarroAluguer.Enabled = false;
            buttonEliminarCarroAluguer.Enabled = false;

            // Desativa a edicao
            groupBoxCarroAluguer.Enabled = false;
            buttonGuardarCarroAluguer.Visible = false;

            ClearVehicleDetails();
        }

        private void buttonEliminarAluguer_Click(object sender, EventArgs e)
        {
            Aluguer selectedAluguer = (Aluguer)listBoxAluguer.SelectedItem;
            standContainer.Aluguers.Remove(selectedAluguer);
            standContainer.SaveChanges();

            listBoxAluguer.DataSource = standContainer.Aluguers.ToList();
            listBoxAluguer.SelectedIndex = -1;

            // Desativa os botoes de editar e eliminar
            buttonEditarAluguer.Enabled = false;
            buttonEliminarAluguer.Enabled = false;

            // Desativa a edicao
            groupBoxAluguer.Enabled = false;
            buttonGuardarAluguer.Visible = false;

            ClearAluguerFields();

            Cliente selectedcliente = (Cliente)listBoxClientesAluguer.SelectedItem;
            labelTotalGastoAluguer.Text = selectedcliente.GetTotalAluguer();
        }

        private void listBoxClientesAluguer_Click(object sender, EventArgs e)
        {
            Cliente selectedcliente = (Cliente)listBoxClientesAluguer.SelectedItem;
            labelTotalGastoAluguer.Text = selectedcliente.GetTotalAluguer();
        }

        private void buttonAluguerFiltrar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            switch (comboBoxAluguerFiltrarPorCampo.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Têm de escolher um campo de procura!");
                    break;
                case 0:
                    clientes = Cliente.SearchClientByName(standContainer, textBoxAluguerFiltrarPor.Text);
                    break;
                case 1:
                    clientes = Cliente.SearchClientByNIF(standContainer, textBoxAluguerFiltrarPor.Text);
                    break;
                default:
                    break;
            }
            listBoxClientesAluguer.DataSource = clientes;
        }

        private void buttonEmitirFaturaAluguer_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesAluguer.SelectedItem;
            Aluguer selectedAluguer = (Aluguer)listBoxAluguer.SelectedItem;
            String nomeFicheiro = "Aluguer - " + selectedCliente.Nome + ".txt";
            using (StreamWriter file = new StreamWriter(nomeFicheiro))
            {
                file.WriteLine("\tREALSTAND\r\n\r\nNome: " + selectedCliente.Nome + "\r\n" + "NIF: " + selectedCliente.NIF 
                    + "\r\nData de inicio: " + selectedAluguer.DataInicio + "\r\nData de fim: " + selectedAluguer.DataFim + "\r\n");
                file.WriteLine("---------------------------------");
                file.WriteLine("Marca: " + selectedAluguer.CarroAluguer.Marca + "\r\nModelo: " + selectedAluguer.CarroAluguer.Modelo
                   + "\r\nMatrícula: " + selectedAluguer.CarroAluguer.Matricula);
                file.WriteLine("_________________________________");
                file.WriteLine("TOTAL A PAGAR: " + selectedAluguer.Valor.ToString("0.00") + "€");
            }
        }
    }
}
