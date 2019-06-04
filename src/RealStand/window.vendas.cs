using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStand
{
    partial class window
    {
        private bool novoCarroVenda = false;
        void IniciaFormVendas()
        {
            //Reseta a Ficha de Cliente
            labelNomeClienteSelecionadoVendas.Text = "Nenhum cliente selecionado";
            labelNifClienteSelecionadoVendas.Text = "*********";

            //Desseleciona todos os itens nas listboxes
            listBoxVendasDoCliente.SelectedIndex = -1;

            //Limpa todas as caixas de texto
            textBoxProcurarPorVendas.Text = "";
            comboBoxCampoVendas.SelectedItem = null;
            CleanInputCarroVenda();
            dateTimePickerDataVenda.Text = null;
            textBoxEstadoVendas.Text = "";
            maskedTextBoxValorVenda.Text = "";
        }

        void CleanInputCarroVenda()
        {
            textBoxChassiVendas.Text = "";
            textBoxMarcaVendas.Text = "";
            textBoxModeloVendas.Text = "";
            comboBoxCombustivelVendas.SelectedItem = null; ;
            textBoxExtrasVendas.Text = "";
        }

        private void listBoxClientesVendas_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesVendas.SelectedItem;
            try
            {
                listBoxVendasDoCliente.DataSource = selectedCliente.Venda.ToList();
            }
            catch (System.Reflection.TargetInvocationException)
            {
                return;
            }
            listBoxVendasDoCliente.SelectedIndex = -1;
        }

        private void listBoxVendasDoCliente_Click(object sender, EventArgs e)
        {
            Venda selectedVenda = (Venda)listBoxVendasDoCliente.SelectedItem;
            textBoxChassiVendas.Text = selectedVenda.CarroVenda.NumeroChassis;
            textBoxMarcaVendas.Text = selectedVenda.CarroVenda.Marca;
            textBoxModeloVendas.Text = selectedVenda.CarroVenda.Modelo;
            textBoxExtrasVendas.Text = selectedVenda.CarroVenda.Extras;
            dateTimePickerDataVenda.Value = selectedVenda.Data;
            textBoxEstadoVendas.Text = selectedVenda.Estado;
            maskedTextBoxValorVenda.Text = selectedVenda.Valor.ToString();
            switch (selectedVenda.CarroVenda.Combustivel)
            {
                case "Gasóleo":
                    comboBoxCombustivelVendas.SelectedIndex = 0;
                    break;
                case "Gasolina":
                    comboBoxCombustivelVendas.SelectedIndex = 1;
                    break;
                case "Diesel":
                    comboBoxCombustivelVendas.SelectedIndex = 2;
                    break;
                case "Gás":
                    comboBoxCombustivelVendas.SelectedIndex = 3;
                    break;
                case "Híbrido":
                    comboBoxCombustivelVendas.SelectedIndex = 4;
                    break;
            }
        }

        private void buttonGuardarVendas_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesVendas.SelectedItem;
            string numeroChassis = textBoxChassiVendas.Text;
            string marca = textBoxMarcaVendas.Text;
            string modelo = textBoxModeloVendas.Text;
            string combustivel = comboBoxCombustivelVendas.Text;
            string extras = textBoxExtrasVendas.Text;
            DateTime dataVenda = dateTimePickerDataVenda.Value;
            string estado = textBoxEstadoVendas.Text;
            double valorVenda = double.Parse(maskedTextBoxValorVenda.Text.Replace('€', ' '));

            if (CarroOficina.VerificaNumeroChassis(numeroChassis) && CarroOficina.VerificaMarca(marca) && CarroOficina.VerificaModelo(modelo))
            {
                if (novoCarroVenda)
                {
                    CarroVenda novoCarroVenda = new CarroVenda(extras, numeroChassis, marca, modelo, combustivel);
                    Venda novaVenda = new Venda(valorVenda, estado, dataVenda, novoCarroVenda);
                    try
                    {
                        standContainer.Carros.Add(novoCarroVenda);
                        selectedCliente.Venda.Add(novaVenda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }
                else
                {
                    //Editar
                }

                standContainer.SaveChanges();
                listBoxVendasDoCliente.DataSource = selectedCliente.Venda.ToList();
            }
            else if (!CarroOficina.VerificaNumeroChassis(numeroChassis))
            {
                MessageBox.Show("Número de Chassi incompleto. São 17 caracteres");
            }
            else if (!CarroOficina.VerificaMarca(marca))
            {
                MessageBox.Show("Marca não inserida");
            }
            else if (!CarroOficina.VerificaModelo(modelo))
            {
                MessageBox.Show("Modelo não inserido");
            }
            else if (!CarroOficina.VerificaCombustivel(comboBoxCombustivelVendas.SelectedIndex))
            {
                MessageBox.Show("Combustível não selecionado");
            }

        }

        private void buttonCriarVenda_Click(object sender, EventArgs e)
        {
            novoCarroVenda = true;
        }
    }
}
