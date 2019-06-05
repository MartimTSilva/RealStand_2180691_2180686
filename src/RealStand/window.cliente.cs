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
        private bool newclient = false;

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            newclient = true;

            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";

            EnableDataInsertion();
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
                !Cliente.CheckDuplicatePhoneNumber(standContainer, contactoMaskedTextBox.Text))
            {
                if (newclient)
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
    }
}
