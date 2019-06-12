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
        private bool novoCarroOficina = false;
        private bool novoServicoOficina = false;

        ///Limpa os inputs do carro
        void CleanInputCarroOficina()
        {
            maskedTextBoxMatriculaOficina.Text = "";
            numericUpDownKMsOficina.Text = "0";
            maskedTextBoxChassiOficina.Text = "";
            textBoxMarcaOficina.Text = "";
            textBoxModeloOficina.Text = "";
            comboBoxCombustivelOficina.SelectedItem = null;
        }

        ///Limpa os inputs dos servicos
        void CleanInputServicosOficina()
        {
            dateTimePickerDataEntregaOficina.Text = null;
            dateTimePickerDataSaidaOficina.Text = null;
            comboBoxTipoServicosOficina.SelectedIndex = -1;
        }

        /// Método para colocar tudo do Form da Oficina a null
        private void IniciaOficina()
        {
            //Reseta a Ficha de Cliente
            labelClienteSelecionadoOficina.Text = "Nenhum cliente selecionado";
            labelNifClienteSelecionadoOficina.Text = "*********";
            labelTotalClienteOficina.Text = "000,00€";

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
            textBoxProcurarPorOficina.Text = "";
            comboBoxCampoOficina.SelectedItem = null;

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
            buttonEmitirFaturaOficina.Enabled = false;
            buttonEditarCarroOficina.Enabled = false;
            buttonGuardarCarroOficina.Enabled = false;
        }

        /// Mostra todos os carros do cliente selecionado na listbox dos carros da oficina
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

            //Bloqueia algumas funcionalidades
            groupBoxServicosOficina.Enabled = false;
            groupBoxParcelasOficina.Enabled = false;
            buttonEditarCarroOficina.Enabled = false;
            buttonRemoverCarroOficina.Enabled = false;
        }

        /// Adiciona um carro da oficina ao cliente que esteja selecionado na listbox
        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            novoCarroOficina = true;
            listBoxCarrosOficina.SelectedIndex = -1;
            CleanInputCarroOficina();
            PreparaCarro();
        }

        void PreparaCarro()
        {
            groupBoxCriarCarroOficina.Enabled = true;
            buttonEditarCarroOficina.Enabled = false;
            buttonRemoverCarroOficina.Enabled = false;
            buttonGuardarCarroOficina.Enabled = true;
        }

        /// Mostra todos os serviços do carro selecionado da oficina
        private void listBoxCarrosOficina_Click(object sender, EventArgs e)
        {
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            try
            {
                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                groupBoxServicosOficina.Enabled = true;
                buttonRemoverServicoOficina.Enabled = false;
                buttonEmitirFaturaOficina.Enabled = false;
                buttonRemoverCarroOficina.Enabled = true;
                groupBoxCriarCarroOficina.Enabled = false;
                buttonEditarServicoOficina.Enabled = false;
                buttonCriarServicoOficina.Enabled = true;
                groupBoxCriarServicoOficina.Enabled = false;
                groupBoxParcelasOficina.Enabled = false;
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
            maskedTextBoxChassiOficina.Text = selectedCarroOficina.NumeroChassis;
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

        /// Adiciona uma parcela a um serviço na oficina
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

        /// Mostra todos as parcelas do serviço selecionado
        private void listBoxServicosOficina_Click(object sender, EventArgs e)
        {
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            try
            {
                listBoxParcelasOficina.DataSource = selectedServico.Parcela.ToList();
                groupBoxCriarParcelaOficina.Enabled = true;
                groupBoxParcelasOficina.Enabled = true;
                buttonRemoverServicoOficina.Enabled = true;
                buttonEmitirFaturaOficina.Enabled = true;
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

        /// Remove uma parcela que esteja selecionada 
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

        /// Remove um carro que esteja selecionado
        private void buttonRemoverCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (selectedCarroOficina.Servico.Count != 0)
            {
                if (MessageBox.Show("O carro que está a tentar remover tem serviços ativos. \nTem a certeza que quer continuar? " +
                "Todas as parcelas e serviços serão removidos.", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    standContainer.Carros.Remove(selectedCarroOficina);
                    standContainer.SaveChanges();
                    listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                    buttonRemoverCarroOficina.Enabled = false;
                    CleanInputCarroOficina();
                    listBoxCarrosOficina.SelectedIndex = -1;
                    buttonRemoverCarroOficina.Enabled = false;
                    buttonEditarCarroOficina.Enabled = false;
                    CleanInputServicosOficina();
                    listBoxServicosOficina.DataSource = null;
                    listBoxParcelasOficina.DataSource = null;
                    labelTotalClienteOficina.Text = selectedCliente.GetTotal();
                    groupBoxServicosOficina.Enabled = false;
                    groupBoxParcelasOficina.Enabled = false;
                }
            }
        }

        /// Ativa o botao de remover parcela sempre que uma parcela seja selecionada
        private void listBoxParcelasOficina_Click(object sender, EventArgs e)
        {
            if (listBoxParcelasOficina.SelectedItem != null)
            {
                buttonRemoverParcelaOficina.Enabled = true;
            }
        }

        /// Cria ou edita um carro do cliente que esteja selecionado
        private void buttonGuardarCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            string matricula = maskedTextBoxMatriculaOficina.Text;
            int kms = int.Parse(numericUpDownKMsOficina.Text);
            string numeroChassis = maskedTextBoxChassiOficina.Text;
            string marca = textBoxMarcaOficina.Text;
            string modelo = textBoxModeloOficina.Text;
            string combustivel = comboBoxCombustivelOficina.Text;
            if (CarroOficina.VerificaMatricula(matricula) && CarroOficina.VerificaKMs(kms)
                && Carro.VerificaNumeroChassis(numeroChassis) && Carro.VerificaMarca(marca)
                && Carro.VerificaModelo(modelo) & Carro.VerificaCombustivel(comboBoxCombustivelOficina.SelectedIndex))
            {
                if (novoCarroOficina) //Criar novo
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
                else //Editar Carro
                {
                    CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
                    selectedCarroOficina.Matricula = maskedTextBoxMatriculaOficina.Text;
                    selectedCarroOficina.Kms = int.Parse(numericUpDownKMsOficina.Text);
                    selectedCarroOficina.NumeroChassis = maskedTextBoxChassiOficina.Text;
                    selectedCarroOficina.Marca = textBoxMarcaOficina.Text;
                    selectedCarroOficina.Modelo = textBoxModeloOficina.Text;
                    selectedCarroOficina.Combustivel = comboBoxCombustivelOficina.Text;
                }
                standContainer.SaveChanges();
                listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                listBoxServicosOficina.SelectedIndex = -1;
                listBoxCarrosOficina.SelectedIndex = -1;
                listBoxParcelasOficina.SelectedIndex = -1;
                groupBoxCriarParcelaOficina.Enabled = false;
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
            else if (!Carro.VerificaNumeroChassis(numeroChassis))
            {
                MessageBox.Show("Número de Chassi incompleto. São 17 caracteres");
            }
            else if (!Carro.VerificaMarca(marca))
            {
                MessageBox.Show("Marca não inserida");
            }
            else if (!Carro.VerificaModelo(modelo))
            {
                MessageBox.Show("Modelo não inserido");
            }
            else if (!Carro.VerificaCombustivel(comboBoxCombustivelOficina.SelectedIndex))
            {
                MessageBox.Show("Combustível não selecionado");
            }
        }

        /// Desbloqueia as textboxes para que nestas sejam possivel alterar dados
        private void buttonEditarCarroOficina_Click(object sender, EventArgs e)
        {
            novoCarroOficina = false;
            PreparaCarro();
        }

        /// Remove um servico que esteja selecionado
        private void buttonRemoverServicoOficina_Click(object sender, EventArgs e)
        {
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            if (selectedServico.Parcela.Count != 0)
            {
                if (MessageBox.Show("O serviço que está a tentar remover tem parcelas ativas. \nTem a certeza que quer continuar? " +
                "Todas as parcelas serão eleminadas.", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    standContainer.Servicos.Remove(selectedServico);
                    standContainer.SaveChanges();
                    listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                    dateTimePickerDataEntregaOficina.Text = null;
                    dateTimePickerDataSaidaOficina.Text = null;
                    comboBoxTipoServicosOficina.SelectedIndex = -1;
                    buttonRemoverServicoOficina.Enabled = false;
                    buttonEmitirFaturaOficina.Enabled = false;
                    buttonEditarServicoOficina.Enabled = false;
                    listBoxParcelasOficina.DataSource = null;
                    groupBoxCriarParcelaOficina.Enabled = false;
                    Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
                    labelTotalClienteOficina.Text = selectedCliente.GetTotal();
                }
            }
        }

        /// Cria ou edita um servico do carro selecionado 
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
                listBoxParcelasOficina.SelectedIndex = -1;
                groupBoxCriarParcelaOficina.Enabled = false;
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

        void PreparaServico()
        {
            groupBoxCriarServicoOficina.Enabled = true;
            buttonGuardarServicoOficina.Enabled = true;
            buttonEditarServicoOficina.Enabled = false;
            buttonRemoverServicoOficina.Enabled = false;
            buttonEmitirFaturaOficina.Enabled = false;
        }

        ///Altera a variavel booleana para que quando seja guardado um servico, seja possivel saber se é um novo ou uma edição
        private void buttonCriarServicoOficina_Click(object sender, EventArgs e)
        {
            novoServicoOficina = true;
            listBoxServicosOficina.SelectedIndex = -1;
            CleanInputServicosOficina();
            PreparaServico();
        }

        ///Altera a variavel booleana para que quando seja guardado um servico, seja possivel saber se é um novo ou uma edição
        private void buttonEditarServicoOficina_Click(object sender, EventArgs e)
        {
            novoServicoOficina = false;
            PreparaServico();
        }

        /// Procura um cliente por um campo escolhido
        private void buttonFiltrarOficina_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            switch (comboBoxCampoOficina.SelectedIndex)
            {
                case 0:
                    clientes = Cliente.SearchClientByName(standContainer, textBoxProcurarPorOficina.Text);
                    break;
                case 1:
                    clientes = Cliente.SearchClientByNIF(standContainer, textBoxProcurarPorOficina.Text);
                    break;
                default:
                    MessageBox.Show("Têm de escolher um campo de procura!");
                    return;
            }
            listBoxClientesOficina.DataSource = clientes;
            //Limpa
            listBoxClientesOficina.SelectedIndex = -1;
            CleanInputCarroOficina();
            CleanInputDetalhesVenda();
            CleanInputServicosOficina();
            listBoxServicosOficina.DataSource = null;
            listBoxParcelasOficina.DataSource = null;
        }

        /// Emite a fatura de um servico selecionado
        private void buttonEmitirFaturaOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            string nomeFicheiro = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                nomeFicheiro = saveFileDialog.FileName;

                using (StreamWriter file = new StreamWriter(nomeFicheiro))
                {
                    file.WriteLine("\tREALSTAND\r\n\r\nNome: " + selectedCliente.Nome + "\r\n" + "NIF: " + selectedCliente.NIF + "\r\n" + "Tipo de Serviço: "
                        + selectedServico.Tipo + "\r\nEntrada: " + selectedServico.DataEntrega.ToShortDateString() + "\r\nSaída: " + selectedServico.DataSaida.ToShortDateString() + "\r\n");
                    foreach (Parcela item in selectedServico.Parcela)
                    {
                        file.WriteLine("---------------------------------");
                        file.WriteLine("Descrição: " + item.Descricao);
                        file.WriteLine("Valor: " + item.Valor + "€");
                    }
                    file.WriteLine("_________________________________");
                    file.WriteLine("TOTAL A PAGAR: " + selectedServico.GetTotal().ToString("0.00") + "€");
                }
                MessageBox.Show("Fatura Criada.");
            }
        }
    }
}
