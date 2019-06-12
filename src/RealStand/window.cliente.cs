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

        ///Limpa todos os inputs do cliente
        private void ClearDadosCliente()
        {
            nomeTextBox.Text = "";
            nIFMaskedTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoMaskedTextBox.Text = "";
        }

        ///Método para dar reset ao form/tab
        private void IniciaFormClientes()
        {
            ClearDadosCliente();
            DisableDataInsertion();
            textBoxClienteProcurarPor.Text = "";
            comboBoxCampoProcura.SelectedItem = null;
            buttonEditarCliente.Enabled = false;
            buttonApagarCliente.Enabled = false;
        }

        ///Altera a variavel booleana para que quando seja guardado um cliente, seja possivel saber se é um novo ou uma edição
        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            newclient = true;
            ClearDadosCliente();
            EnableDataInsertion();
            clientesListBox.SelectedIndex = -1;
            buttonEditarCliente.Enabled = false;
            buttonApagarCliente.Enabled = false;
        }

        ///Altera a variavel booleana para que quando seja guardado um servico, seja possivel saber se é um novo ou uma edição
        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            EnableDataInsertion();
            buttonEditarCliente.Enabled = false;
            buttonApagarCliente.Enabled = false;
        }

        ///Apaga um cliente que esteja selecionado
        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende apagar?" +
                "\nTodos os dados do cliente serão apagados.", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente selectedCliente = (Cliente)clientesListBox.SelectedItem;
                standContainer.Clientes.Remove(selectedCliente);
                standContainer.SaveChanges();
                clientesListBox.DataSource = standContainer.Clientes.ToList<Cliente>();
                clientesListBox.SelectedIndex = -1;
                buttonApagarCliente.Enabled = false;
                buttonEditarCliente.Enabled = false;
                DisableDataInsertion();
                ClearDadosCliente();
            }
        }

        ///Procura um cliente pelo campo selecionado
        private void buttonProcurarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            switch (comboBoxCampoProcura.SelectedIndex)
            {
                case 0:
                    clientes = Cliente.SearchClientByName(standContainer, textBoxClienteProcurarPor.Text);
                    break;
                case 1:
                    clientes = Cliente.SearchClientByNIF(standContainer, textBoxClienteProcurarPor.Text);
                    break;
                default:
                    MessageBox.Show("Têm de escolher um campo de procura!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            clientesListBox.DataSource = clientes;
            clientesListBox.SelectedIndex = -1;
            ClearDadosCliente();
        }

        ///Grava dos dados do cliente na base de dados
        private void buttonGravarCliente_Click(object sender, EventArgs e)
        {
            if (Cliente.CheckName(nomeTextBox.Text) &&
                Cliente.CheckMorada(moradaTextBox.Text))
            {
                if (newclient)
                {
                    if (!Cliente.CheckDuplicateNIF(standContainer, nIFMaskedTextBox.Text) &&
                        !Cliente.CheckDuplicatePhoneNumber(standContainer, contactoMaskedTextBox.Text))
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
                        MessageBox.Show("Campos incompletos ou repetidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
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
                clientesListBox.SelectedIndex = -1;
                buttonEditarCliente.Enabled = false;
                buttonApagarCliente.Enabled = false;
                DisableDataInsertion();
                ClearDadosCliente();
                newclient = false;
            }
            else
            {
                MessageBox.Show("Campos incompletos ou repetidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        ///Mostra os dados do cliente selecionado
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
            buttonGravarCliente.Visible = false;
            DisableDataInsertion();
        }

        ///Ativa as caixas de texto para poder adicionar um novo cliente
        private void EnableDataInsertion()
        {
            nomeTextBox.Enabled = true;
            nIFMaskedTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoMaskedTextBox.Enabled = true;
            buttonGravarCliente.Visible = true;
        }

        ///Bloqueia todos os inputs dos dados do cliente
        private void DisableDataInsertion()
        {
            nomeTextBox.Enabled = false;
            nIFMaskedTextBox.Enabled = false;
            moradaTextBox.Enabled = false;
            contactoMaskedTextBox.Enabled = false;
            buttonGravarCliente.Visible = false;
        }
    }
}
