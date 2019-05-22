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
            this.clientesTableAdapter.Fill(this.realStandDataSet.Clientes);

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
        }

        /// <summary>
        /// Ao clicar na tab "Oficina" do menu, atualiza a listbox dos clientes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                listBoxClientesOficina.DataSource = standContainer.Clientes.ToList<Cliente>();
                //Mete a listbox dos clientes da oficina sem nenhum item selecionado
                listBoxClientesOficina.SelectedIndex = -1;
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
            listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
            //Mete a listbox dos Carros da oficina sem nenhum item selecionado
            listBoxCarrosOficina.SelectedIndex = -1;
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
        }

        /// <summary>
        /// Mostra todos os serviços do carro selecionado da oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCarrosOficina_Click(object sender, EventArgs e)
        {
            CarroOficina selectedCarroOficina = (CarroOficina)listBoxCarrosOficina.SelectedItem;
            listBoxServicosOficina.DataSource = selectedCarroOficina.Servico.ToList();
            //Mete a listbox dos serviços da oficina sem nenhum item selecionado
            listBoxServicosOficina.SelectedIndex = -1;
        }
    }
}
