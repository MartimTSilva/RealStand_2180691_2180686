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
                    break;
                case 2:
                    listBoxClientesOficina.DataSource = standContainer.Clientes.ToList<Cliente>();
                    listBoxClientesOficina.SelectedIndex = -1;
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
            listBoxCarrosOficina.DataSource = selectedCliente.CarroOficina.ToList();
        }

        /// <summary>
        /// Adiciona cliente à base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGravarCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente(nomeTextBox.Text, int.Parse(nIFMaskedTextBox.Text), moradaTextBox.Text, contactoMaskedTextBox.Text);
            standContainer.Clientes.Add(novoCliente);
            standContainer.SaveChanges();
            clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();
            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";
        }
    }
}
