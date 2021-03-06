﻿using System;
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
        // Mostra o texto das tabs na horizontal
        // Baseado no exemplo
        // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-display-side-aligned-tabs-with-tabcontrol
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
            standContainer = new StandContainer();
            UpdateStatusBar(sender, e);
        }

        private void UpdateStatusBar(object sender, EventArgs e)
        {
            toolStripStatusLabelAluguer.Text = "Aluguers: " + standContainer.Aluguers.Count();
            toolStripStatusLabelVendas.Text = "Vendas: " + standContainer.Vendas.Count();
            toolStripStatusLabelClientes.Text = "Clientes: " + standContainer.Clientes.Count();
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        /// Atualiza os dados quando muda de tab
        private void tabControl1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();
                    clientesListBox.SelectedIndex = -1;
                    IniciaFormClientes();
                    break;
                case 2:
                    listBoxClientesOficina.DataSource = standContainer.Clientes.ToList<Cliente>();
                    IniciaOficina();
                    break;
                case 3:
                    IniciaFormVendas();
                    listBoxClientesVendas.DataSource = standContainer.Clientes.ToList<Cliente>();
                    listBoxClientesVendas.SelectedIndex = -1;
                    break;
                case 4:
                    listBoxClientesAluguer.DataSource = standContainer.Clientes.ToList();
                    listBoxCarrosAluguer.DataSource = standContainer.Carros.OfType<CarroAluguer>().ToList();
                    ResetFormAluguer();
                    break;
                default:
                    break;
            }
        }
    }
 }
