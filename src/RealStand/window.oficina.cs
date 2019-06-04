﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStand
{
    partial class window
    {
        private bool novoCarroOficina = false;
        private bool novoServicoOficina = false;

        void CleanInputCarroOficina()
        {
            //Limpa textboxes
            maskedTextBoxMatriculaOficina.Text = "";
            numericUpDownKMsOficina.Text = "0";
            textBoxChassiOficina.Text = "";
            textBoxMarcaOficina.Text = "";
            textBoxModeloOficina.Text = "";
            comboBoxCombustivelOficina.SelectedItem = null;
        }
        void CleanInputServicosOficina()
        {
            dateTimePickerDataEntregaOficina.Text = null;
            dateTimePickerDataSaidaOficina.Text = null;
            comboBoxTipoServicosOficina.SelectedIndex = -1;
        }

        /// <summary>
        /// Método para colocar tudo do Form da Oficina a null
        /// </summary>
        private void IniciaOficina()
        {
            //Reseta a Ficha de Cliente
            labelClienteSelecionadoOficina.Text = "Nenhum cliente selecionado";
            labelNifClienteSelecionadoOficina.Text = "*********";
            labelTotalClienteOficina.Text = "0.00€";

            //Esvazia todos os "inputs" da groupbox de Adicionar um carro.
            foreach (Control c in groupBoxCriarCarroOficina.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
                else if (c is NumericUpDown)
                {
                    c.Text = "0";
                }
                else if (c is ComboBox)
                    (c as ComboBox).SelectedIndex = -1;
            }
            //Mais algumas Caixas
            dateTimePickerDataEntregaOficina.Text = null;
            comboBoxTipoServicosOficina.SelectedItem = null;
            dateTimePickerDataSaidaOficina.Text = null;
            textBoxDescricaoParcelaOficina.Text = "";
            maskedTextBoxValorParcelaOficina.Text = "";

            //Desseleciona todos os itens nas listboxes
            listBoxClientesOficina.SelectedIndex = -1;
            listBoxCarrosOficina.SelectedIndex = -1;
            listBoxServicosOficina.SelectedIndex = -1;
            listBoxParcelasOficina.SelectedIndex = -1;

            //Reseta todas as listboxes
            listBoxCarrosOficina.DataSource = null;
            listBoxServicosOficina.DataSource = null;
            listBoxParcelasOficina.DataSource = null;

            //Bloqueia alguns botões e groupboxes para evitar toques aceidentais e erros
            groupBoxCriarCarroOficina.Enabled = false;
            groupBoxCriarServicoOficina.Enabled = false;
            groupBoxCriarParcelaOficina.Enabled = false;
            groupBoxCarrosOficina.Enabled = false;
            groupBoxServicosOficina.Enabled = false;
            groupBoxParcelasOficina.Enabled = false;
            buttonRemoverCarroOficina.Enabled = false;
            buttonRemoverServicoOficina.Enabled = false;
            buttonRemoverParcelaOficina.Enabled = false;
            buttonEditarCarroOficina.Enabled = false;
            buttonGuardarCarroOficina.Enabled = false;
        }
        /// <summary>
        /// Mostra todos os carros do cliente selecionado na listbox dos carros da oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxClientesOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            try
            {
                listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                groupBoxCarrosOficina.Enabled = true;
                CleanInputCarroOficina();
            }
            catch (System.NullReferenceException)
            {
                return;
            }

            //Limpa e mete as listboxes sem nenhum item selecionado quando é selecionado um novo cliente.
            listBoxCarrosOficina.SelectedIndex = -1;
            listBoxServicosOficina.SelectedIndex = -1;
            listBoxParcelasOficina.SelectedIndex = -1;
            listBoxServicosOficina.DataSource = null;
            listBoxParcelasOficina.DataSource = null;
            CleanInputServicosOficina();

            //Preenche a ficha do cliente
            labelClienteSelecionadoOficina.Text = selectedCliente.Nome;
            labelNifClienteSelecionadoOficina.Text = selectedCliente.NIF;
            labelTotalClienteOficina.Text = selectedCliente.GetTotal();
        }

        /// <summary>
        /// Adiciona um carro da oficina ao cliente que esteja selecionado na listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            novoCarroOficina = true;
            listBoxCarrosOficina.SelectedIndex = -1;
            groupBoxCriarCarroOficina.Enabled = true;
            buttonGuardarCarroOficina.Enabled = true;
            buttonEditarCarroOficina.Enabled = false;
            buttonRemoverCarroOficina.Enabled = false;
            CleanInputCarroOficina();
        }

        /// <summary>
        /// Mostra todos os serviços do carro selecionado da oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCarrosOficina_Click(object sender, EventArgs e)
        {
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            try
            {
                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                groupBoxCriarServicoOficina.Enabled = true;
                groupBoxServicosOficina.Enabled = true;
                buttonRemoverServicoOficina.Enabled = false;
                buttonRemoverCarroOficina.Enabled = true;
                buttonRemoverParcelaOficina.Enabled = false;
                groupBoxCriarCarroOficina.Enabled = false;
                buttonEditarServicoOficina.Enabled = false;
                buttonCriarServicoOficina.Enabled = true;
                groupBoxCriarServicoOficina.Enabled = false;
            }
            catch (System.NullReferenceException)
            {
                return;
            }

            //Mete a listbox dos serviços da oficina sem nenhum item selecionado
            listBoxServicosOficina.SelectedIndex = -1;
            listBoxParcelasOficina.DataSource = null;
            buttonEditarCarroOficina.Enabled = true;

            //Preenche textboxes com as informações do carro
            maskedTextBoxMatriculaOficina.Text = selectedCarroOficina.Matricula;
            numericUpDownKMsOficina.Text = selectedCarroOficina.Kms.ToString();
            textBoxChassiOficina.Text = selectedCarroOficina.NumeroChassis;
            textBoxMarcaOficina.Text = selectedCarroOficina.Marca;
            textBoxModeloOficina.Text = selectedCarroOficina.Modelo;

            switch (selectedCarroOficina.Combustivel)
            {
                case "Gasóleo":
                    comboBoxCombustivelOficina.SelectedIndex = 0;
                    break;
                case "Gasolina":
                    comboBoxCombustivelOficina.SelectedIndex = 1;
                    break;
                case "Diesel":
                    comboBoxCombustivelOficina.SelectedIndex = 2;
                    break;
                case "Gás":
                    comboBoxCombustivelOficina.SelectedIndex = 3;
                    break;
                case "Híbrido":
                    comboBoxCombustivelOficina.SelectedIndex = 4;
                    break;
            }

            CleanInputServicosOficina();
        }

        /// <summary>
        /// Adiciona uma parcela a um serviço na oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarParcelaOficina_Click(object sender, EventArgs e)
        {
            double ValorParcela;
            try
            {
                ValorParcela = double.Parse(maskedTextBoxValorParcelaOficina.Text.Replace('€', ' '));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Valor da parcela incorreto.");
                return;
            }
            string DescricaoParcela = textBoxDescricaoParcelaOficina.Text;

            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            Parcela novaParcela = new Parcela(ValorParcela, DescricaoParcela);

            if (Parcela.VerificaDescricaoParcela(DescricaoParcela))
            {
                if (selectedServico == null)
                {
                    return;
                }

                selectedServico.Parcela.Add(novaParcela);
                standContainer.SaveChanges();
                listBoxParcelasOficina.DataSource = selectedServico.Parcela.ToList();
                listBoxParcelasOficina.SelectedIndex = -1;
                labelTotalClienteOficina.Text = selectedCliente.GetTotal();

                //Limpa textboxes
                textBoxDescricaoParcelaOficina.Text = "";
                maskedTextBoxValorParcelaOficina.Text = null;
            }
            else if (!Parcela.VerificaDescricaoParcela(DescricaoParcela))
            {
                MessageBox.Show("Descrição de parcela vazia.");
            }
        }

        /// <summary>
        /// Mostra todos as parcelas do serviço selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxServicosOficina_Click(object sender, EventArgs e)
        {
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            try
            {
                listBoxParcelasOficina.DataSource = selectedServico.Parcela.ToList();
                groupBoxCriarParcelaOficina.Enabled = true;
                groupBoxParcelasOficina.Enabled = true;
                buttonRemoverServicoOficina.Enabled = true;
                buttonRemoverParcelaOficina.Enabled = false;
                buttonEditarServicoOficina.Enabled = true;
            }
            catch (System.NullReferenceException)
            {
                return;
            }

            //Coloca os dados nas textboxes
            dateTimePickerDataEntregaOficina.Value = selectedServico.DataEntrega;
            dateTimePickerDataSaidaOficina.Value = selectedServico.DataSaida;
            switch (selectedServico.Tipo)
            {
                case "Manutenção":
                    comboBoxTipoServicosOficina.SelectedIndex = 0;
                    break;
                case "Tipo 2":
                    comboBoxTipoServicosOficina.SelectedIndex = 1;
                    break;
                case "Tipo 3":
                    comboBoxTipoServicosOficina.SelectedIndex = 2;
                    break;
            }

            //Mete a listbox das parcelas da oficina sem nenhum item selecionado
            groupBoxCriarServicoOficina.Enabled = false;
            listBoxParcelasOficina.SelectedIndex = -1;
        }

        private void buttonRemoverParcelaOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            Parcela selectedParcela = (Parcela)listBoxParcelasOficina.SelectedItem;
            standContainer.Parcelas.Remove(selectedParcela);
            standContainer.SaveChanges();
            listBoxParcelasOficina.DataSource = selectedServico.Parcela.ToList();
            listBoxParcelasOficina.SelectedIndex = -1;
            buttonRemoverParcelaOficina.Enabled = false;
            labelTotalClienteOficina.Text = selectedCliente.GetTotal();
        }

        private void buttonRemoverCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (selectedCarroOficina.Servico.Count == 0)
            {
                standContainer.Carros.Remove(selectedCarroOficina);
                standContainer.SaveChanges();
                listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                buttonRemoverCarroAluguer.Enabled = false;
                CleanInputCarroOficina();
                listBoxCarrosOficina.SelectedIndex = -1;
                buttonRemoverCarroOficina.Enabled = false;
                buttonEditarCarroOficina.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não é possivel apagar um carro com serviços ativos");
            }

        }

        private void listBoxParcelasOficina_Click(object sender, EventArgs e)
        {
            if (listBoxParcelasOficina.SelectedItem != null)
            {
                buttonRemoverParcelaOficina.Enabled = true;
            }
        }

        private void buttonGuardarCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;

            string matricula = maskedTextBoxMatriculaOficina.Text;
            int kms = int.Parse(numericUpDownKMsOficina.Text);
            string numeroChassis = textBoxChassiOficina.Text;
            string marca = textBoxMarcaOficina.Text;
            string modelo = textBoxModeloOficina.Text;
            string combustivel = comboBoxCombustivelOficina.Text;

            if (CarroOficina.VerificaMatricula(matricula) && CarroOficina.VerificaKMs(kms)
                && CarroOficina.VerificaNumeroChassis(numeroChassis) && CarroOficina.VerificaMarca(marca)
                && CarroOficina.VerificaModelo(modelo) & CarroOficina.VerificaCombustivel(comboBoxCombustivelOficina.SelectedIndex))
            {
                if (novoCarroOficina)
                {
                    CarroOficina novoCarroOficina = new CarroOficina(matricula, kms, numeroChassis, marca, modelo, combustivel);
                    try
                    {
                        selectedCliente.CarroOficina.Add(novoCarroOficina);
                    }
                    catch (System.NullReferenceException)
                    {
                        return;
                    }
                }
                else
                {
                    CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
                    selectedCarroOficina.Matricula = maskedTextBoxMatriculaOficina.Text;
                    selectedCarroOficina.Kms = int.Parse(numericUpDownKMsOficina.Text);
                    selectedCarroOficina.NumeroChassis = textBoxChassiOficina.Text;
                    selectedCarroOficina.Marca = textBoxMarcaOficina.Text;
                    selectedCarroOficina.Modelo = textBoxModeloOficina.Text;
                    selectedCarroOficina.Combustivel = comboBoxCombustivelOficina.Text;
                }

                standContainer.SaveChanges();
                listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                listBoxServicosOficina.SelectedIndex = -1;
                listBoxCarrosOficina.SelectedIndex = -1;
                CleanInputCarroOficina();
                groupBoxCriarCarroOficina.Enabled = false;
                buttonCriarServicoOficina.Enabled = false;
            }
            else if (!CarroOficina.VerificaMatricula(matricula))
            {
                MessageBox.Show("Matricula inválida");
            }
            else if (!CarroOficina.VerificaKMs(kms))
            {
                MessageBox.Show("Quilometragem inválida");
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
            else if (!CarroOficina.VerificaCombustivel(comboBoxCombustivelOficina.SelectedIndex))
            {
                MessageBox.Show("Combustível não selecionado");
            }
        }

        private void buttonEditarCarroOficina_Click(object sender, EventArgs e)
        {
            novoCarroOficina = false;
            groupBoxCriarCarroOficina.Enabled = true;
            buttonEditarCarroOficina.Enabled = false;
            buttonRemoverCarroOficina.Enabled = false;
            buttonGuardarCarroOficina.Enabled = true;
        }

        private void buttonRemoverServicoOficina_Click_1(object sender, EventArgs e)
        {
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;

            if (selectedServico.Parcela.Count == 0)
            {
                standContainer.Servicos.Remove(selectedServico);
                standContainer.SaveChanges();
                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                dateTimePickerDataEntregaOficina.Text = null;
                dateTimePickerDataSaidaOficina.Text = null;
                comboBoxTipoServicosOficina.SelectedIndex = -1;
                buttonRemoverServicoOficina.Enabled = false;
                buttonEditarServicoOficina.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não é possivel apagar um serviço com parcelas ativas");
            }
        }

        private void buttonGuardarServicoOficina_Click(object sender, EventArgs e)
        {
            DateTime DataEntrega = dateTimePickerDataEntregaOficina.Value;
            DateTime DataSaida = dateTimePickerDataSaidaOficina.Value;
            string TipoServico = comboBoxTipoServicosOficina.Text;

            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            Servico novoServico = new Servico(DataEntrega, TipoServico, DataSaida);

            if (Servico.VerificaTipoServico(TipoServico) && Servico.VerificaDatasServico(DataEntrega, DataSaida))
            {
                if (novoServicoOficina)
                {
                    selectedCarroOficina.Servico.Add(novoServico);
                }
                else
                {
                    Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
                    selectedServico.DataEntrega = dateTimePickerDataEntregaOficina.Value;
                    selectedServico.DataSaida = dateTimePickerDataSaidaOficina.Value;
                    selectedServico.Tipo = comboBoxTipoServicosOficina.Text;
                }

                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                standContainer.SaveChanges();
                listBoxServicosOficina.SelectedIndex = -1;
                listBoxParcelasOficina.SelectedIndex = -1;
                groupBoxCriarServicoOficina.Enabled = false;
                CleanInputServicosOficina();

            }
            else if (!Servico.VerificaDatasServico(DataEntrega, DataSaida))
            {
                MessageBox.Show("Erro! A data de entrada não pode ser mais recente que a data de saída.");

            }
            else if (!Servico.VerificaTipoServico(TipoServico))
            {
                MessageBox.Show("Erro! Tipo de serviço não selecionado.");

            }

        }

        private void buttonCriarServicoOficina_Click(object sender, EventArgs e)
        {
            novoServicoOficina = true;
            listBoxServicosOficina.SelectedIndex = -1;
            groupBoxCriarServicoOficina.Enabled = true;
            buttonGuardarServicoOficina.Enabled = true;
            buttonEditarServicoOficina.Enabled = false;
            buttonRemoverServicoOficina.Enabled = false;
            CleanInputServicosOficina();
        }

        private void buttonEditarServicoOficina_Click(object sender, EventArgs e)
        {
            novoServicoOficina = false;
            groupBoxCriarServicoOficina.Enabled = true;
            buttonEditarServicoOficina.Enabled = false;
            buttonRemoverServicoOficina.Enabled = false;
            buttonGuardarServicoOficina.Enabled = true;
        }
    }
}
