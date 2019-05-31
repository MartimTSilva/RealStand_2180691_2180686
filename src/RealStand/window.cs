using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStand
{
    public partial class window : Form
    {
        //Criação do Container
        private StandContainer standContainer;

        private bool newclient = false;

        public window()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        private void window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realStandDataSet.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.realStandDataSet.Clientes);

            standContainer = new StandContainer();
        }

        private bool VerificaCombustivel(string combustivel)
        {
            if (comboBoxCombustivelOficina.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

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

        /// <summary>
        /// Adiciona um carro da oficina ao cliente que esteja selecionado na listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;

            string matricula = maskedTextBoxMatriculaOficina.Text;
            int kms = int.Parse(numericUpDownKMsOficina.Text);
            string numeroChassis = textBoxChassiOficina.Text;
            string marca = textBoxMarcaOficina.Text;
            string modelo = textBoxModeloOficina.Text;
            string combustivel = comboBoxCombustivelOficina.SelectedText;

            if (CarroOficina.VerificaMatricula(matricula) && CarroOficina.VerificaKMs(kms) && CarroOficina.VerificaNumeroChassis(numeroChassis) && CarroOficina.VerificaMarca(marca) && CarroOficina.VerificaModelo(modelo) & VerificaCombustivel(combustivel))
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

                standContainer.SaveChanges();
                listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
                listBoxServicosOficina.SelectedIndex = -1;
                listBoxCarrosOficina.SelectedIndex = -1;
                CleanInputCarroOficina();
            }
            else if (!CarroOficina.VerificaNumeroChassis(numeroChassis))
            {
                MessageBox.Show("Número de Chassi incompleto. São 17 caracteres.");
            }
            else if (!CarroOficina.VerificaMatricula(matricula))
            {
                MessageBox.Show("Matricula inválida");
            }
            else
            {
                MessageBox.Show("Erro! Falta de informação." + "\n" + "Por favor, certifique-se que todas as caixas estão preenchidas.");
            }
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
        }

        /// <summary>
        /// Atualiza os dados quando muda de tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();
                    clientesListBox.SelectedIndex = -1;
                    break;
                case 2:
                    listBoxClientesOficina.DataSource = standContainer.Clientes.ToList<Cliente>();
                    IniciaOficina();
                    break;
                default:
                    break;
            }
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
                groupBoxCriarCarroOficina.Enabled = true;
                groupBoxCarrosOficina.Enabled = true;
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

            //Preenche a ficha do cliente
            labelClienteSelecionadoOficina.Text = selectedCliente.Nome;
            labelNifClienteSelecionadoOficina.Text = selectedCliente.NIF;
            GetTotal(selectedCliente);
        }

        private void GetTotal(Cliente selectedCliente)
        {
            if (selectedCliente == null)
            {
                return;
            }
            labelTotalClienteOficina.Text = selectedCliente.GetTotal().ToString("0.00€");
        }

        /// <summary>
        /// Adiciona um Serviço a um carro da oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarServicoOficina_Click(object sender, EventArgs e)
        {
            DateTime DataEntrega = dateTimePickerDataEntregaOficina.Value;
            DateTime DataSaida = dateTimePickerDataSaidaOficina.Value;
            string TipoServico = comboBoxTipoServicosOficina.Text;

            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            Servico novoServico = new Servico(DataEntrega, TipoServico, DataSaida);

            if (Servico.VerificaTipoServico(TipoServico) && Servico.VerificaDatasServico(DataEntrega, DataSaida))
            {
                selectedCarroOficina.Servico.Add(novoServico);
                standContainer.SaveChanges();
                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
                listBoxServicosOficina.SelectedIndex = -1;

                //Limpa textboxes
                dateTimePickerDataEntregaOficina.Text = null;
                comboBoxTipoServicosOficina.SelectedItem = null;
                dateTimePickerDataSaidaOficina.Text = null;
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
            }
            catch (System.NullReferenceException)
            {
                return;
            }
            //Mete a listbox dos serviços da oficina sem nenhum item selecionado
            listBoxServicosOficina.SelectedIndex = -1;
            listBoxParcelasOficina.DataSource = null;
        }

        /// <summary>
        /// Grava dos dados do cliente na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGravarCliente_Click(object sender, EventArgs e)
        {
            if (Cliente.CheckName(nomeTextBox.Text) &&
                !Cliente.CheckDuplicateNIF(standContainer, nIFMaskedTextBox.Text) &&
                Cliente.CheckMorada(moradaTextBox.Text) && 
                Cliente.CheckDuplicatePhoneNumber(standContainer, contactoMaskedTextBox.Text))
            {
                if(newclient)
                {
                        Cliente novoCliente = new Cliente(
                            nomeTextBox.Text, 
                            nIFMaskedTextBox.Text, 
                            moradaTextBox.Text, 
                            contactoMaskedTextBox.Text);
                        standContainer.Clientes.Add(novoCliente);
                }
                else
                {
                    Cliente selectedClient = (Cliente)clientesListBox.SelectedItem;
                    selectedClient.Nome = nomeTextBox.Text;
                    selectedClient.NIF = nIFMaskedTextBox.Text;
                    selectedClient.Morada = moradaTextBox.Text;
                    selectedClient.Contacto = contactoMaskedTextBox.Text;
                }
                standContainer.SaveChanges();
                clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();

                DisableDataInsertion();
                newclient = false;
            }
            else if (Cliente.CheckDuplicateNIF(standContainer, nIFMaskedTextBox.Text))
            {
                MessageBox.Show("Já existe um cliente com o mesmo NIF ou o NIF está incorreto!");
            }
            else
            {
                MessageBox.Show("Existem campos errados!");
            }
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
                GetTotal(selectedCliente);

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
            }
            catch (System.NullReferenceException)
            {
                return;
            }
            //Mete a listbox das parcelas da oficina sem nenhum item selecionado
            listBoxParcelasOficina.SelectedIndex = -1;
        }

        /// <summary>
        /// Mostra os dados do cliente selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientesListBox_Click(object sender, EventArgs e)
        {
            Cliente selectedClient = (Cliente)clientesListBox.SelectedItem;
            if (selectedClient == null)
            {
                return;
            }
            nomeTextBox.Text = selectedClient.Nome;
            nIFMaskedTextBox.Text = selectedClient.NIF;
            moradaTextBox.Text = selectedClient.Morada;
            contactoMaskedTextBox.Text = selectedClient.Contacto;
            buttonApagarCliente.Enabled = true;
            buttonEditarCliente.Enabled = true;
        }

        /// <summary>
        /// Ativa as caixas de texto para poder adicionar um novo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableDataInsertion()
        {
            nomeTextBox.Enabled = true;
            nIFMaskedTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoMaskedTextBox.Enabled = true;
            buttonGravarCliente.Visible = true;
        }

        private void DisableDataInsertion()
        {
            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";

            nomeTextBox.Enabled = false;
            nIFMaskedTextBox.Enabled = false;
            moradaTextBox.Enabled = false;
            contactoMaskedTextBox.Enabled = false;
            buttonGravarCliente.Visible = false;
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
            GetTotal(selectedCliente);
        }

        private void buttonRemoverServicoOficina_Click(object sender, EventArgs e)
        {
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;

            if (selectedServico.Parcela.Count == 0)
            {
                standContainer.Servicos.Remove(selectedServico);
                standContainer.SaveChanges();
                listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
            }
            else
            {
                MessageBox.Show("Não é possivel apagar um serviço com parcelas ativas");
            }
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
            }
            else
            {
                MessageBox.Show("Não é possivel apagar um carro com serviços ativos");
            }
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            EnableDataInsertion();
        }

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)clientesListBox.SelectedItem;
            standContainer.Clientes.Remove(selectedCliente);
            standContainer.SaveChanges();
            clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();
            clientesListBox.SelectedIndex = -1;
            buttonApagarCliente.Enabled = false;
            buttonEditarCliente.Enabled = false;
            DisableDataInsertion();
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            newclient = true;

            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";

            EnableDataInsertion();
        }

        private void buttonProcurarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            switch (comboBoxCampoProcura.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Têm de escolher um campo de procura!");
                    break;
                case 0:
                        clientes = Cliente.SearchClientByName(standContainer, textBoxClienteProcurarPor.Text);
                    break;
                case 1:
                        clientes = Cliente.SearchClientByNIF(standContainer, textBoxClienteProcurarPor.Text);
                    break;
                default:
                    break;
            }
            clientesListBox.DataSource = clientes;

        }
        
        private void listBoxParcelasOficina_Click(object sender, EventArgs e)
        {
            if (listBoxParcelasOficina.SelectedItem != null)
            {
                buttonRemoverParcelaOficina.Enabled = true;
            }
        }

        private void textBoxChassiOficina_TextChanged(object sender, EventArgs e)
        {
            int remain = 17 - textBoxChassiOficina.Text.Length;
            label4.Text = remain.ToString();
        }
    }
}
