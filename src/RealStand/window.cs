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

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.realStandDataSet);

        }

        private void window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realStandDataSet.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.realStandDataSet.Clientes);

            standContainer = new StandContainer();
        }

        /// <summary>
        /// Adiciona um carro da oficina ao cliente que esteja selecionado na listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)listBoxClientesOficina.SelectedItem;
            CarroOficina novoCarroOficina = new CarroOficina(maskedTextBoxMatriculaOficina.Text, int.Parse(textBoxKMsOficina.Text), int.Parse(textBoxChassiOficina.Text), textBoxMarcaOficina.Text, textBoxModeloOficina.Text, comboBoxCombustivelOficina.SelectedText);
            if (novoCarroOficina == null)
            {
                return;
            }
            selectedCliente.CarroOficina.Add(novoCarroOficina);
            standContainer.SaveChanges();
            listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();

            //Limpa textboxes
            maskedTextBoxMatriculaOficina.Text = "";
            textBoxKMsOficina.Text = "";
            textBoxChassiOficina.Text = "";
            textBoxMarcaOficina.Text = "";
            textBoxModeloOficina.Text = "";
            comboBoxCombustivelOficina.Text = "";
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
                    labelClienteSelecionadoOficina.Text = "Nenhum cliente selecionado";
                    labelNifClienteSelecionadoOficina.Text = "*********";
                    labelTotalClienteOficina.Text = "0.00€";
                    listBoxClientesOficina.SelectedIndex = -1;
                    listBoxCarrosOficina.SelectedIndex = -1;
                    listBoxServicosOficina.SelectedIndex = -1;
                    listBoxParcelasOficina.SelectedIndex = -1;
                    listBoxCarrosOficina.DataSource = null;
                    listBoxServicosOficina.DataSource = null;
                    listBoxParcelasOficina.DataSource = null;
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
            }
            catch (System.NullReferenceException)
            {
                return;
            }

            //Mete as listboxs sem nenhum item selecionado
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
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            Servico novoServico = new Servico(dateTimePickerDataEntregaOficina.Value , comboBoxTipoServicosOficina.SelectedItem.ToString(), dateTimePickerDataSaidaOficina.Value);
            if (novoServico == null)
            {
                return;
            }
            selectedCarroOficina.Servico.Add(novoServico);
            standContainer.SaveChanges();
            listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();

            //Limpa textboxes
            dateTimePickerDataEntregaOficina.Text = null;
            comboBoxTipoServicosOficina.Text = "";
            dateTimePickerDataSaidaOficina.Text = null;
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
            if(newclient)
            {
                Cliente novoCliente = new Cliente(nomeTextBox.Text, nIFMaskedTextBox.Text, moradaTextBox.Text, contactoMaskedTextBox.Text);
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
        }

        /// <summary>
        /// Adiciona uma parcela a um serviço na oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionarParcelaOficina_Click(object sender, EventArgs e)
        {
            Cliente selectedCliente = (Cliente)clientesListBox.SelectedItem;
            Servico selectedServico = (Servico)listBoxServicosOficina.SelectedItem;
            Parcela novaParcela = new Parcela(decimal.Parse(maskedTextBoxValorParcelaOficina.Text.Replace('€', ' ')), textBoxDescricaoParcelaOficina.Text);

            if (selectedServico == null)
            {
                return;
            }
            selectedServico.Parcela.Add(novaParcela);
            standContainer.SaveChanges();
            listBoxParcelasOficina.DataSource = selectedServico.Parcela.ToList();
            GetTotal(selectedCliente);

            //Limpa textboxes
            textBoxDescricaoParcelaOficina.Text = "";
            maskedTextBoxValorParcelaOficina.Text = null;
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
            AllowDataInsertion();

            Cliente selectedClient = (Cliente)clientesListBox.SelectedItem;
            nomeTextBox.Text = selectedClient.Nome;
            nIFMaskedTextBox.Text = selectedClient.NIF;
            moradaTextBox.Text = selectedClient.Morada;
            contactoMaskedTextBox.Text = selectedClient.Contacto;
        }

        /// <summary>
        /// Ativa as caixas de texto para poder adicionar um novo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllowDataInsertion()
        {
            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";

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

        private void clientesBindingNavigator_Click(object sender, EventArgs e)
        {
            newclient = true;
            AllowDataInsertion();
        }
    }
}
