namespace RealStand
{
    partial class window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label contactoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.buttonProcurarCliente = new System.Windows.Forms.Button();
            this.buttonCriarCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonApagarCliente = new System.Windows.Forms.Button();
            this.labelCampoDeProcura = new System.Windows.Forms.Label();
            this.labelProcurarPor = new System.Windows.Forms.Label();
            this.comboBoxCampoProcura = new System.Windows.Forms.ComboBox();
            this.textBoxClienteProcurarPor = new System.Windows.Forms.TextBox();
            this.groupBoxDadosClientes = new System.Windows.Forms.GroupBox();
            this.buttonGravarCliente = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realStandDataSet = new RealStand.realstandDataSet();
            this.nIFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.contactoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientesListBox = new System.Windows.Forms.ListBox();
            this.tabPageOficina = new System.Windows.Forms.TabPage();
            this.groupBoxParcelasOficina = new System.Windows.Forms.GroupBox();
            this.buttonRemoverParcelaOficina = new System.Windows.Forms.Button();
            this.groupBoxCriarParcelaOficina = new System.Windows.Forms.GroupBox();
            this.labelValorOficina = new System.Windows.Forms.Label();
            this.labelDescricaoOficina = new System.Windows.Forms.Label();
            this.buttonAdicionarParcelaOficina = new System.Windows.Forms.Button();
            this.maskedTextBoxValorParcelaOficina = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDescricaoParcelaOficina = new System.Windows.Forms.TextBox();
            this.listBoxParcelasOficina = new System.Windows.Forms.ListBox();
            this.groupBoxServicosOficina = new System.Windows.Forms.GroupBox();
            this.buttonRemoverServicoOficina = new System.Windows.Forms.Button();
            this.buttonCriarServicoOficina = new System.Windows.Forms.Button();
            this.buttonEditarServicoOficina = new System.Windows.Forms.Button();
            this.groupBoxCriarServicoOficina = new System.Windows.Forms.GroupBox();
            this.buttonGuardarServicoOficina = new System.Windows.Forms.Button();
            this.dateTimePickerDataSaidaOficina = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataEntregaOficina = new System.Windows.Forms.DateTimePicker();
            this.labelDataSaidaOficina = new System.Windows.Forms.Label();
            this.labelTipoServicoOficina = new System.Windows.Forms.Label();
            this.labelDataEntregaOficina = new System.Windows.Forms.Label();
            this.comboBoxTipoServicosOficina = new System.Windows.Forms.ComboBox();
            this.listBoxServicosOficina = new System.Windows.Forms.ListBox();
            this.groupBoxCarrosOficina = new System.Windows.Forms.GroupBox();
            this.buttonEditarCarroOficina = new System.Windows.Forms.Button();
            this.groupBoxCriarCarroOficina = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxChassiOficina = new System.Windows.Forms.MaskedTextBox();
            this.buttonGuardarCarroOficina = new System.Windows.Forms.Button();
            this.numericUpDownKMsOficina = new System.Windows.Forms.NumericUpDown();
            this.textBoxModeloOficina = new System.Windows.Forms.TextBox();
            this.textBoxMarcaOficina = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelOficina = new System.Windows.Forms.ComboBox();
            this.labelCombustivelOficina = new System.Windows.Forms.Label();
            this.labelModeloOficina = new System.Windows.Forms.Label();
            this.labelMarcaOficina = new System.Windows.Forms.Label();
            this.labelNChassisOficina = new System.Windows.Forms.Label();
            this.labelQuilometragemOficina = new System.Windows.Forms.Label();
            this.maskedTextBoxMatriculaOficina = new System.Windows.Forms.MaskedTextBox();
            this.labelMatriculaOficina = new System.Windows.Forms.Label();
            this.buttonRemoverCarroOficina = new System.Windows.Forms.Button();
            this.listBoxCarrosOficina = new System.Windows.Forms.ListBox();
            this.buttonCriarCarroOficina = new System.Windows.Forms.Button();
            this.groupBoxFichaClienteOficina = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalGastoOficina = new System.Windows.Forms.Label();
            this.labelTotalClienteOficina = new System.Windows.Forms.Label();
            this.labelNifClienteSelecionadoOficina = new System.Windows.Forms.Label();
            this.labelClienteSelecionadoOficina = new System.Windows.Forms.Label();
            this.labelNifOficina = new System.Windows.Forms.Label();
            this.labelNomeOficina = new System.Windows.Forms.Label();
            this.groupBoxClientesOficina = new System.Windows.Forms.GroupBox();
            this.labelProcurarPorOficina = new System.Windows.Forms.Label();
            this.labelTextoOficina = new System.Windows.Forms.Label();
            this.comboBoxCampoOficina = new System.Windows.Forms.ComboBox();
            this.textBoxProcurarPorOficina = new System.Windows.Forms.TextBox();
            this.listBoxClientesOficina = new System.Windows.Forms.ListBox();
            this.labelTituloOficina = new System.Windows.Forms.Label();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.groupBoxDetalhesVendaECarroVendas = new System.Windows.Forms.GroupBox();
            this.groupBoxDetalhesCarroVenda = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelNChassis = new System.Windows.Forms.Label();
            this.labelCombustivelVendas = new System.Windows.Forms.Label();
            this.textBoxExtrasVendas = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelVendas = new System.Windows.Forms.ComboBox();
            this.labelModeloVendas = new System.Windows.Forms.Label();
            this.labelExtrasVendas = new System.Windows.Forms.Label();
            this.textBoxModeloVendas = new System.Windows.Forms.TextBox();
            this.labelMarcaVendas = new System.Windows.Forms.Label();
            this.textBoxMarcaVendas = new System.Windows.Forms.TextBox();
            this.groupBoxDetalhesDaVenda = new System.Windows.Forms.GroupBox();
            this.labelDataVendaVendas = new System.Windows.Forms.Label();
            this.maskedTextBoxValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.labelValorVendas = new System.Windows.Forms.Label();
            this.labelEstadoVendas = new System.Windows.Forms.Label();
            this.dateTimePickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.textBoxEstadoVendas = new System.Windows.Forms.TextBox();
            this.buttonGuardarVendas = new System.Windows.Forms.Button();
            this.groupBoxVendasCliente = new System.Windows.Forms.GroupBox();
            this.buttonEditarVenda = new System.Windows.Forms.Button();
            this.buttonAnularVenda = new System.Windows.Forms.Button();
            this.buttonCriarVenda = new System.Windows.Forms.Button();
            this.listBoxVendasDoCliente = new System.Windows.Forms.ListBox();
            this.groupBoxListaClientesVendas = new System.Windows.Forms.GroupBox();
            this.buttonFiltarVendas = new System.Windows.Forms.Button();
            this.labelProcurarPorVendas = new System.Windows.Forms.Label();
            this.labelCampoVendas = new System.Windows.Forms.Label();
            this.comboBoxCampoVendas = new System.Windows.Forms.ComboBox();
            this.textBoxProcurarPorVendas = new System.Windows.Forms.TextBox();
            this.listBoxClientesVendas = new System.Windows.Forms.ListBox();
            this.labelTituloVendas = new System.Windows.Forms.Label();
            this.groupBoxFichaClienteVendas = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalVendas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalVendas = new System.Windows.Forms.Label();
            this.labelNifClienteSelecionadoVendas = new System.Windows.Forms.Label();
            this.labelNomeClienteSelecionadoVendas = new System.Windows.Forms.Label();
            this.labelNifVendas = new System.Windows.Forms.Label();
            this.labelNomeVendas = new System.Windows.Forms.Label();
            this.tabPageAluguer = new System.Windows.Forms.TabPage();
            this.groupBoxAluguerCarro = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxValorAluguer = new System.Windows.Forms.MaskedTextBox();
            this.textBoxQuilometragemAluguer = new System.Windows.Forms.TextBox();
            this.labelQuilometragemAluguer = new System.Windows.Forms.Label();
            this.labelValorAluguer = new System.Windows.Forms.Label();
            this.dateTimePickerDataFimAluguer = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicioAluguer = new System.Windows.Forms.DateTimePicker();
            this.labelDataFimAluguer = new System.Windows.Forms.Label();
            this.labelDataInicioAluguer = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxAdicionarCarroAluguer = new System.Windows.Forms.GroupBox();
            this.checkBoxEstadoAluguer = new System.Windows.Forms.CheckBox();
            this.textBoxModeloAluguer = new System.Windows.Forms.TextBox();
            this.textBoxMarcaAluguer = new System.Windows.Forms.TextBox();
            this.textBoxChassiAluguer = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelAluguer = new System.Windows.Forms.ComboBox();
            this.labelCombustivelAluguer = new System.Windows.Forms.Label();
            this.labelModeloAluguer = new System.Windows.Forms.Label();
            this.labelMarcaAluguer = new System.Windows.Forms.Label();
            this.labelNChassisAluguer = new System.Windows.Forms.Label();
            this.labelAlugadoAluguer = new System.Windows.Forms.Label();
            this.maskedTextBoxMatriculaAluguer = new System.Windows.Forms.MaskedTextBox();
            this.labelMatriculaAluguer = new System.Windows.Forms.Label();
            this.buttonAdicionarCarroAluguer = new System.Windows.Forms.Button();
            this.groupBoxCarrosAluguer = new System.Windows.Forms.GroupBox();
            this.buttonRemoverCarroAluguer = new System.Windows.Forms.Button();
            this.listBoxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCampoAluguer = new System.Windows.Forms.Label();
            this.labelProcurarPorAluguer = new System.Windows.Forms.Label();
            this.comboBoxCampoAluguer = new System.Windows.Forms.ComboBox();
            this.textBoxProcurarPorAluguer = new System.Windows.Forms.TextBox();
            this.listBoxClientesAluguer = new System.Windows.Forms.ListBox();
            this.labelTituloAluguer = new System.Windows.Forms.Label();
            this.groupBoxFichaClienteVenda = new System.Windows.Forms.GroupBox();
            this.labelNifClienteSelecionadoAluguer = new System.Windows.Forms.Label();
            this.labelClienteSelecionadoAluguer = new System.Windows.Forms.Label();
            this.labelNifAluguer = new System.Windows.Forms.Label();
            this.labelNomeAluguer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.clientesTableAdapter = new RealStand.realstandDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RealStand.realstandDataSetTableAdapters.TableAdapterManager();
            nomeLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageClientes.SuspendLayout();
            this.groupBoxDadosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realStandDataSet)).BeginInit();
            this.tabPageOficina.SuspendLayout();
            this.groupBoxParcelasOficina.SuspendLayout();
            this.groupBoxCriarParcelaOficina.SuspendLayout();
            this.groupBoxServicosOficina.SuspendLayout();
            this.groupBoxCriarServicoOficina.SuspendLayout();
            this.groupBoxCarrosOficina.SuspendLayout();
            this.groupBoxCriarCarroOficina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKMsOficina)).BeginInit();
            this.groupBoxFichaClienteOficina.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxClientesOficina.SuspendLayout();
            this.tabPageVendas.SuspendLayout();
            this.groupBoxDetalhesVendaECarroVendas.SuspendLayout();
            this.groupBoxDetalhesCarroVenda.SuspendLayout();
            this.groupBoxDetalhesDaVenda.SuspendLayout();
            this.groupBoxVendasCliente.SuspendLayout();
            this.groupBoxListaClientesVendas.SuspendLayout();
            this.groupBoxFichaClienteVendas.SuspendLayout();
            this.groupBoxTotalVendas.SuspendLayout();
            this.tabPageAluguer.SuspendLayout();
            this.groupBoxAluguerCarro.SuspendLayout();
            this.groupBoxAdicionarCarroAluguer.SuspendLayout();
            this.groupBoxCarrosAluguer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxFichaClienteVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(28, 20);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(43, 52);
            nIFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(33, 17);
            nIFLabel.TabIndex = 2;
            nIFLabel.Text = "NIF:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(8, 84);
            moradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(60, 17);
            moradaLabel.TabIndex = 4;
            moradaLabel.Text = "Morada:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(8, 116);
            contactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(68, 17);
            contactoLabel.TabIndex = 6;
            contactoLabel.Text = "Contacto:";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPageInicio);
            this.tabControl1.Controls.Add(this.tabPageClientes);
            this.tabControl1.Controls.Add(this.tabPageOficina);
            this.tabControl1.Controls.Add(this.tabPageVendas);
            this.tabControl1.Controls.Add(this.tabPageAluguer);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 160);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1443, 715);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.Color.Silver;
            this.tabPageInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageInicio.Controls.Add(this.pictureBox2);
            this.tabPageInicio.Controls.Add(this.label3);
            this.tabPageInicio.Controls.Add(this.label2);
            this.tabPageInicio.Controls.Add(this.label1);
            this.tabPageInicio.Controls.Add(this.pictureBox1);
            this.tabPageInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageInicio.Location = new System.Drawing.Point(166, 4);
            this.tabPageInicio.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Size = new System.Drawing.Size(1273, 707);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Início";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 596);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projeto de Desenvolvimento de Aplicações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Micael Rodrigues, nº 2180691";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maritm Silva, nº 2180686";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.BackColor = System.Drawing.Color.Silver;
            this.tabPageClientes.Controls.Add(this.buttonProcurarCliente);
            this.tabPageClientes.Controls.Add(this.buttonCriarCliente);
            this.tabPageClientes.Controls.Add(this.buttonEditarCliente);
            this.tabPageClientes.Controls.Add(this.buttonApagarCliente);
            this.tabPageClientes.Controls.Add(this.labelCampoDeProcura);
            this.tabPageClientes.Controls.Add(this.labelProcurarPor);
            this.tabPageClientes.Controls.Add(this.comboBoxCampoProcura);
            this.tabPageClientes.Controls.Add(this.textBoxClienteProcurarPor);
            this.tabPageClientes.Controls.Add(this.groupBoxDadosClientes);
            this.tabPageClientes.Controls.Add(this.clientesListBox);
            this.tabPageClientes.Location = new System.Drawing.Point(166, 4);
            this.tabPageClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageClientes.Size = new System.Drawing.Size(1273, 707);
            this.tabPageClientes.TabIndex = 1;
            this.tabPageClientes.Text = "Clientes";
            // 
            // buttonProcurarCliente
            // 
            this.buttonProcurarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonProcurarCliente.Image")));
            this.buttonProcurarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcurarCliente.Location = new System.Drawing.Point(476, 63);
            this.buttonProcurarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcurarCliente.Name = "buttonProcurarCliente";
            this.buttonProcurarCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonProcurarCliente.TabIndex = 12;
            this.buttonProcurarCliente.Text = "Procurar";
            this.buttonProcurarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProcurarCliente.UseVisualStyleBackColor = true;
            this.buttonProcurarCliente.Click += new System.EventHandler(this.buttonProcurarCliente_Click);
            // 
            // buttonCriarCliente
            // 
            this.buttonCriarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarCliente.Image")));
            this.buttonCriarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCriarCliente.Location = new System.Drawing.Point(8, 11);
            this.buttonCriarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriarCliente.Name = "buttonCriarCliente";
            this.buttonCriarCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonCriarCliente.TabIndex = 11;
            this.buttonCriarCliente.Text = "Criar";
            this.buttonCriarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCriarCliente.UseVisualStyleBackColor = true;
            this.buttonCriarCliente.Click += new System.EventHandler(this.buttonCriarCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.Enabled = false;
            this.buttonEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCliente.Image")));
            this.buttonEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCliente.Location = new System.Drawing.Point(116, 11);
            this.buttonEditarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonEditarCliente.TabIndex = 10;
            this.buttonEditarCliente.Text = "Editar";
            this.buttonEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // buttonApagarCliente
            // 
            this.buttonApagarCliente.Enabled = false;
            this.buttonApagarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagarCliente.Image")));
            this.buttonApagarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApagarCliente.Location = new System.Drawing.Point(224, 11);
            this.buttonApagarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonApagarCliente.TabIndex = 9;
            this.buttonApagarCliente.Text = "Apagar";
            this.buttonApagarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            this.buttonApagarCliente.Click += new System.EventHandler(this.buttonApagarCliente_Click);
            // 
            // labelCampoDeProcura
            // 
            this.labelCampoDeProcura.AutoSize = true;
            this.labelCampoDeProcura.Location = new System.Drawing.Point(305, 46);
            this.labelCampoDeProcura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampoDeProcura.Name = "labelCampoDeProcura";
            this.labelCampoDeProcura.Size = new System.Drawing.Size(56, 17);
            this.labelCampoDeProcura.TabIndex = 7;
            this.labelCampoDeProcura.Text = "Campo:";
            // 
            // labelProcurarPor
            // 
            this.labelProcurarPor.AutoSize = true;
            this.labelProcurarPor.Location = new System.Drawing.Point(4, 46);
            this.labelProcurarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcurarPor.Name = "labelProcurarPor";
            this.labelProcurarPor.Size = new System.Drawing.Size(92, 17);
            this.labelProcurarPor.TabIndex = 6;
            this.labelProcurarPor.Text = "Procurar por:";
            // 
            // comboBoxCampoProcura
            // 
            this.comboBoxCampoProcura.FormattingEnabled = true;
            this.comboBoxCampoProcura.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoProcura.Location = new System.Drawing.Point(309, 65);
            this.comboBoxCampoProcura.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampoProcura.Name = "comboBoxCampoProcura";
            this.comboBoxCampoProcura.Size = new System.Drawing.Size(157, 24);
            this.comboBoxCampoProcura.TabIndex = 5;
            // 
            // textBoxClienteProcurarPor
            // 
            this.textBoxClienteProcurarPor.Location = new System.Drawing.Point(4, 65);
            this.textBoxClienteProcurarPor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClienteProcurarPor.Name = "textBoxClienteProcurarPor";
            this.textBoxClienteProcurarPor.Size = new System.Drawing.Size(296, 22);
            this.textBoxClienteProcurarPor.TabIndex = 4;
            // 
            // groupBoxDadosClientes
            // 
            this.groupBoxDadosClientes.Controls.Add(this.buttonGravarCliente);
            this.groupBoxDadosClientes.Controls.Add(nomeLabel);
            this.groupBoxDadosClientes.Controls.Add(this.nomeTextBox);
            this.groupBoxDadosClientes.Controls.Add(nIFLabel);
            this.groupBoxDadosClientes.Controls.Add(this.nIFMaskedTextBox);
            this.groupBoxDadosClientes.Controls.Add(moradaLabel);
            this.groupBoxDadosClientes.Controls.Add(this.moradaTextBox);
            this.groupBoxDadosClientes.Controls.Add(contactoLabel);
            this.groupBoxDadosClientes.Controls.Add(this.contactoMaskedTextBox);
            this.groupBoxDadosClientes.Location = new System.Drawing.Point(584, 94);
            this.groupBoxDadosClientes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDadosClientes.Name = "groupBoxDadosClientes";
            this.groupBoxDadosClientes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDadosClientes.Size = new System.Drawing.Size(620, 185);
            this.groupBoxDadosClientes.TabIndex = 3;
            this.groupBoxDadosClientes.TabStop = false;
            this.groupBoxDadosClientes.Text = "Dados";
            // 
            // buttonGravarCliente
            // 
            this.buttonGravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravarCliente.Image")));
            this.buttonGravarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGravarCliente.Location = new System.Drawing.Point(512, 149);
            this.buttonGravarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGravarCliente.Name = "buttonGravarCliente";
            this.buttonGravarCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonGravarCliente.TabIndex = 8;
            this.buttonGravarCliente.Text = "Gravar";
            this.buttonGravarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGravarCliente.UseVisualStyleBackColor = true;
            this.buttonGravarCliente.Visible = false;
            this.buttonGravarCliente.Click += new System.EventHandler(this.buttonGravarCliente_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(87, 16);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(524, 22);
            this.nomeTextBox.TabIndex = 1;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.realStandDataSet;
            // 
            // realStandDataSet
            // 
            this.realStandDataSet.DataSetName = "RealStandDataSet";
            this.realStandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nIFMaskedTextBox
            // 
            this.nIFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "NIF", true));
            this.nIFMaskedTextBox.Enabled = false;
            this.nIFMaskedTextBox.Location = new System.Drawing.Point(87, 48);
            this.nIFMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nIFMaskedTextBox.Mask = "000000000";
            this.nIFMaskedTextBox.Name = "nIFMaskedTextBox";
            this.nIFMaskedTextBox.Size = new System.Drawing.Size(92, 22);
            this.nIFMaskedTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Morada", true));
            this.moradaTextBox.Enabled = false;
            this.moradaTextBox.Location = new System.Drawing.Point(87, 80);
            this.moradaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(524, 22);
            this.moradaTextBox.TabIndex = 5;
            // 
            // contactoMaskedTextBox
            // 
            this.contactoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Contacto", true));
            this.contactoMaskedTextBox.Enabled = false;
            this.contactoMaskedTextBox.Location = new System.Drawing.Point(87, 112);
            this.contactoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactoMaskedTextBox.Mask = "000000000";
            this.contactoMaskedTextBox.Name = "contactoMaskedTextBox";
            this.contactoMaskedTextBox.Size = new System.Drawing.Size(92, 22);
            this.contactoMaskedTextBox.TabIndex = 7;
            // 
            // clientesListBox
            // 
            this.clientesListBox.FormattingEnabled = true;
            this.clientesListBox.ItemHeight = 16;
            this.clientesListBox.Location = new System.Drawing.Point(4, 94);
            this.clientesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(571, 596);
            this.clientesListBox.TabIndex = 0;
            this.clientesListBox.Click += new System.EventHandler(this.clientesListBox_Click);
            // 
            // tabPageOficina
            // 
            this.tabPageOficina.BackColor = System.Drawing.Color.Silver;
            this.tabPageOficina.Controls.Add(this.groupBoxParcelasOficina);
            this.tabPageOficina.Controls.Add(this.groupBoxServicosOficina);
            this.tabPageOficina.Controls.Add(this.groupBoxCarrosOficina);
            this.tabPageOficina.Controls.Add(this.groupBoxFichaClienteOficina);
            this.tabPageOficina.Controls.Add(this.groupBoxClientesOficina);
            this.tabPageOficina.Controls.Add(this.labelTituloOficina);
            this.tabPageOficina.Location = new System.Drawing.Point(166, 4);
            this.tabPageOficina.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOficina.Name = "tabPageOficina";
            this.tabPageOficina.Size = new System.Drawing.Size(1273, 707);
            this.tabPageOficina.TabIndex = 2;
            this.tabPageOficina.Text = "Oficina";
            // 
            // groupBoxParcelasOficina
            // 
            this.groupBoxParcelasOficina.Controls.Add(this.buttonRemoverParcelaOficina);
            this.groupBoxParcelasOficina.Controls.Add(this.groupBoxCriarParcelaOficina);
            this.groupBoxParcelasOficina.Controls.Add(this.listBoxParcelasOficina);
            this.groupBoxParcelasOficina.Location = new System.Drawing.Point(867, 140);
            this.groupBoxParcelasOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParcelasOficina.Name = "groupBoxParcelasOficina";
            this.groupBoxParcelasOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParcelasOficina.Size = new System.Drawing.Size(333, 561);
            this.groupBoxParcelasOficina.TabIndex = 4;
            this.groupBoxParcelasOficina.TabStop = false;
            this.groupBoxParcelasOficina.Text = "Parcelas";
            // 
            // buttonRemoverParcelaOficina
            // 
            this.buttonRemoverParcelaOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverParcelaOficina.Image")));
            this.buttonRemoverParcelaOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverParcelaOficina.Location = new System.Drawing.Point(9, 21);
            this.buttonRemoverParcelaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoverParcelaOficina.Name = "buttonRemoverParcelaOficina";
            this.buttonRemoverParcelaOficina.Size = new System.Drawing.Size(316, 28);
            this.buttonRemoverParcelaOficina.TabIndex = 23;
            this.buttonRemoverParcelaOficina.Text = "Remover Parcela";
            this.buttonRemoverParcelaOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverParcelaOficina.Click += new System.EventHandler(this.buttonRemoverParcelaOficina_Click);
            // 
            // groupBoxCriarParcelaOficina
            // 
            this.groupBoxCriarParcelaOficina.Controls.Add(this.labelValorOficina);
            this.groupBoxCriarParcelaOficina.Controls.Add(this.labelDescricaoOficina);
            this.groupBoxCriarParcelaOficina.Controls.Add(this.buttonAdicionarParcelaOficina);
            this.groupBoxCriarParcelaOficina.Controls.Add(this.maskedTextBoxValorParcelaOficina);
            this.groupBoxCriarParcelaOficina.Controls.Add(this.textBoxDescricaoParcelaOficina);
            this.groupBoxCriarParcelaOficina.Location = new System.Drawing.Point(0, 433);
            this.groupBoxCriarParcelaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarParcelaOficina.Name = "groupBoxCriarParcelaOficina";
            this.groupBoxCriarParcelaOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarParcelaOficina.Size = new System.Drawing.Size(333, 128);
            this.groupBoxCriarParcelaOficina.TabIndex = 1;
            this.groupBoxCriarParcelaOficina.TabStop = false;
            this.groupBoxCriarParcelaOficina.Text = "Adicionar Nova Parcela";
            // 
            // labelValorOficina
            // 
            this.labelValorOficina.AutoSize = true;
            this.labelValorOficina.Location = new System.Drawing.Point(8, 65);
            this.labelValorOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorOficina.Name = "labelValorOficina";
            this.labelValorOficina.Size = new System.Drawing.Size(45, 17);
            this.labelValorOficina.TabIndex = 15;
            this.labelValorOficina.Text = "Valor:";
            // 
            // labelDescricaoOficina
            // 
            this.labelDescricaoOficina.AutoSize = true;
            this.labelDescricaoOficina.Location = new System.Drawing.Point(8, 32);
            this.labelDescricaoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricaoOficina.Name = "labelDescricaoOficina";
            this.labelDescricaoOficina.Size = new System.Drawing.Size(75, 17);
            this.labelDescricaoOficina.TabIndex = 14;
            this.labelDescricaoOficina.Text = "Descrição:";
            // 
            // buttonAdicionarParcelaOficina
            // 
            this.buttonAdicionarParcelaOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarParcelaOficina.Image")));
            this.buttonAdicionarParcelaOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarParcelaOficina.Location = new System.Drawing.Point(9, 91);
            this.buttonAdicionarParcelaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarParcelaOficina.Name = "buttonAdicionarParcelaOficina";
            this.buttonAdicionarParcelaOficina.Size = new System.Drawing.Size(316, 28);
            this.buttonAdicionarParcelaOficina.TabIndex = 22;
            this.buttonAdicionarParcelaOficina.Text = "Adicionar Parcela";
            this.buttonAdicionarParcelaOficina.UseVisualStyleBackColor = true;
            this.buttonAdicionarParcelaOficina.Click += new System.EventHandler(this.buttonAdicionarParcelaOficina_Click);
            // 
            // maskedTextBoxValorParcelaOficina
            // 
            this.maskedTextBoxValorParcelaOficina.Location = new System.Drawing.Point(61, 62);
            this.maskedTextBoxValorParcelaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxValorParcelaOficina.Mask = "€000000.00";
            this.maskedTextBoxValorParcelaOficina.Name = "maskedTextBoxValorParcelaOficina";
            this.maskedTextBoxValorParcelaOficina.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxValorParcelaOficina.TabIndex = 21;
            this.maskedTextBoxValorParcelaOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescricaoParcelaOficina
            // 
            this.textBoxDescricaoParcelaOficina.Location = new System.Drawing.Point(93, 28);
            this.textBoxDescricaoParcelaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricaoParcelaOficina.Multiline = true;
            this.textBoxDescricaoParcelaOficina.Name = "textBoxDescricaoParcelaOficina";
            this.textBoxDescricaoParcelaOficina.Size = new System.Drawing.Size(232, 24);
            this.textBoxDescricaoParcelaOficina.TabIndex = 20;
            // 
            // listBoxParcelasOficina
            // 
            this.listBoxParcelasOficina.FormattingEnabled = true;
            this.listBoxParcelasOficina.ItemHeight = 16;
            this.listBoxParcelasOficina.Location = new System.Drawing.Point(9, 57);
            this.listBoxParcelasOficina.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParcelasOficina.Name = "listBoxParcelasOficina";
            this.listBoxParcelasOficina.Size = new System.Drawing.Size(315, 372);
            this.listBoxParcelasOficina.TabIndex = 19;
            this.listBoxParcelasOficina.Click += new System.EventHandler(this.listBoxParcelasOficina_Click);
            // 
            // groupBoxServicosOficina
            // 
            this.groupBoxServicosOficina.Controls.Add(this.buttonRemoverServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.buttonCriarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.buttonEditarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.groupBoxCriarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.listBoxServicosOficina);
            this.groupBoxServicosOficina.Location = new System.Drawing.Point(560, 140);
            this.groupBoxServicosOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxServicosOficina.Name = "groupBoxServicosOficina";
            this.groupBoxServicosOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxServicosOficina.Size = new System.Drawing.Size(299, 561);
            this.groupBoxServicosOficina.TabIndex = 3;
            this.groupBoxServicosOficina.TabStop = false;
            this.groupBoxServicosOficina.Text = "Serviços";
            // 
            // buttonRemoverServicoOficina
            // 
            this.buttonRemoverServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverServicoOficina.Image")));
            this.buttonRemoverServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverServicoOficina.Location = new System.Drawing.Point(12, 92);
            this.buttonRemoverServicoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoverServicoOficina.Name = "buttonRemoverServicoOficina";
            this.buttonRemoverServicoOficina.Size = new System.Drawing.Size(277, 28);
            this.buttonRemoverServicoOficina.TabIndex = 14;
            this.buttonRemoverServicoOficina.Text = "Apagar";
            this.buttonRemoverServicoOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverServicoOficina.Click += new System.EventHandler(this.buttonRemoverServicoOficina_Click_1);
            // 
            // buttonCriarServicoOficina
            // 
            this.buttonCriarServicoOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCriarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarServicoOficina.Image")));
            this.buttonCriarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCriarServicoOficina.Location = new System.Drawing.Point(12, 21);
            this.buttonCriarServicoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriarServicoOficina.Name = "buttonCriarServicoOficina";
            this.buttonCriarServicoOficina.Size = new System.Drawing.Size(277, 28);
            this.buttonCriarServicoOficina.TabIndex = 14;
            this.buttonCriarServicoOficina.Text = "Criar";
            this.buttonCriarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonCriarServicoOficina.Click += new System.EventHandler(this.buttonCriarServicoOficina_Click);
            // 
            // buttonEditarServicoOficina
            // 
            this.buttonEditarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarServicoOficina.Image")));
            this.buttonEditarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarServicoOficina.Location = new System.Drawing.Point(12, 57);
            this.buttonEditarServicoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarServicoOficina.Name = "buttonEditarServicoOficina";
            this.buttonEditarServicoOficina.Size = new System.Drawing.Size(277, 28);
            this.buttonEditarServicoOficina.TabIndex = 14;
            this.buttonEditarServicoOficina.Text = "Editar";
            this.buttonEditarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonEditarServicoOficina.Click += new System.EventHandler(this.buttonEditarServicoOficina_Click);
            // 
            // groupBoxCriarServicoOficina
            // 
            this.groupBoxCriarServicoOficina.Controls.Add(this.buttonGuardarServicoOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.dateTimePickerDataSaidaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.dateTimePickerDataEntregaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelDataSaidaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelTipoServicoOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelDataEntregaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.comboBoxTipoServicosOficina);
            this.groupBoxCriarServicoOficina.Location = new System.Drawing.Point(0, 395);
            this.groupBoxCriarServicoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarServicoOficina.Name = "groupBoxCriarServicoOficina";
            this.groupBoxCriarServicoOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarServicoOficina.Size = new System.Drawing.Size(299, 166);
            this.groupBoxCriarServicoOficina.TabIndex = 1;
            this.groupBoxCriarServicoOficina.TabStop = false;
            this.groupBoxCriarServicoOficina.Text = "Criar / Editar Serviço";
            // 
            // buttonGuardarServicoOficina
            // 
            this.buttonGuardarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarServicoOficina.Image")));
            this.buttonGuardarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarServicoOficina.Location = new System.Drawing.Point(9, 129);
            this.buttonGuardarServicoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarServicoOficina.Name = "buttonGuardarServicoOficina";
            this.buttonGuardarServicoOficina.Size = new System.Drawing.Size(280, 28);
            this.buttonGuardarServicoOficina.TabIndex = 15;
            this.buttonGuardarServicoOficina.Text = "Guardar";
            this.buttonGuardarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonGuardarServicoOficina.Click += new System.EventHandler(this.buttonGuardarServicoOficina_Click);
            // 
            // dateTimePickerDataSaidaOficina
            // 
            this.dateTimePickerDataSaidaOficina.Location = new System.Drawing.Point(129, 94);
            this.dateTimePickerDataSaidaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataSaidaOficina.Name = "dateTimePickerDataSaidaOficina";
            this.dateTimePickerDataSaidaOficina.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerDataSaidaOficina.TabIndex = 16;
            // 
            // dateTimePickerDataEntregaOficina
            // 
            this.dateTimePickerDataEntregaOficina.Location = new System.Drawing.Point(129, 27);
            this.dateTimePickerDataEntregaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataEntregaOficina.Name = "dateTimePickerDataEntregaOficina";
            this.dateTimePickerDataEntregaOficina.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerDataEntregaOficina.TabIndex = 14;
            // 
            // labelDataSaidaOficina
            // 
            this.labelDataSaidaOficina.AutoSize = true;
            this.labelDataSaidaOficina.Location = new System.Drawing.Point(8, 96);
            this.labelDataSaidaOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataSaidaOficina.Name = "labelDataSaidaOficina";
            this.labelDataSaidaOficina.Size = new System.Drawing.Size(102, 17);
            this.labelDataSaidaOficina.TabIndex = 16;
            this.labelDataSaidaOficina.Text = "Data de Saída:";
            // 
            // labelTipoServicoOficina
            // 
            this.labelTipoServicoOficina.AutoSize = true;
            this.labelTipoServicoOficina.Location = new System.Drawing.Point(8, 64);
            this.labelTipoServicoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoServicoOficina.Name = "labelTipoServicoOficina";
            this.labelTipoServicoOficina.Size = new System.Drawing.Size(111, 17);
            this.labelTipoServicoOficina.TabIndex = 15;
            this.labelTipoServicoOficina.Text = "Tipo de Serviço:";
            // 
            // labelDataEntregaOficina
            // 
            this.labelDataEntregaOficina.AutoSize = true;
            this.labelDataEntregaOficina.Location = new System.Drawing.Point(8, 32);
            this.labelDataEntregaOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataEntregaOficina.Name = "labelDataEntregaOficina";
            this.labelDataEntregaOficina.Size = new System.Drawing.Size(116, 17);
            this.labelDataEntregaOficina.TabIndex = 14;
            this.labelDataEntregaOficina.Text = "Data de Entrega:";
            // 
            // comboBoxTipoServicosOficina
            // 
            this.comboBoxTipoServicosOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoServicosOficina.FormattingEnabled = true;
            this.comboBoxTipoServicosOficina.Items.AddRange(new object[] {
            "Manutenção",
            "Tipo 2",
            "Tipo 3"});
            this.comboBoxTipoServicosOficina.Location = new System.Drawing.Point(129, 59);
            this.comboBoxTipoServicosOficina.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoServicosOficina.Name = "comboBoxTipoServicosOficina";
            this.comboBoxTipoServicosOficina.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipoServicosOficina.TabIndex = 15;
            // 
            // listBoxServicosOficina
            // 
            this.listBoxServicosOficina.FormattingEnabled = true;
            this.listBoxServicosOficina.ItemHeight = 16;
            this.listBoxServicosOficina.Location = new System.Drawing.Point(12, 127);
            this.listBoxServicosOficina.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxServicosOficina.Name = "listBoxServicosOficina";
            this.listBoxServicosOficina.Size = new System.Drawing.Size(276, 260);
            this.listBoxServicosOficina.TabIndex = 13;
            this.listBoxServicosOficina.Click += new System.EventHandler(this.listBoxServicosOficina_Click);
            // 
            // groupBoxCarrosOficina
            // 
            this.groupBoxCarrosOficina.Controls.Add(this.buttonEditarCarroOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.groupBoxCriarCarroOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.buttonRemoverCarroOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.listBoxCarrosOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.buttonCriarCarroOficina);
            this.groupBoxCarrosOficina.Location = new System.Drawing.Point(292, 140);
            this.groupBoxCarrosOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrosOficina.Name = "groupBoxCarrosOficina";
            this.groupBoxCarrosOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrosOficina.Size = new System.Drawing.Size(260, 561);
            this.groupBoxCarrosOficina.TabIndex = 2;
            this.groupBoxCarrosOficina.TabStop = false;
            this.groupBoxCarrosOficina.Text = "Carros";
            // 
            // buttonEditarCarroOficina
            // 
            this.buttonEditarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCarroOficina.Image")));
            this.buttonEditarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCarroOficina.Location = new System.Drawing.Point(7, 57);
            this.buttonEditarCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarCarroOficina.Name = "buttonEditarCarroOficina";
            this.buttonEditarCarroOficina.Size = new System.Drawing.Size(244, 28);
            this.buttonEditarCarroOficina.TabIndex = 13;
            this.buttonEditarCarroOficina.Text = "Editar";
            this.buttonEditarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonEditarCarroOficina.Click += new System.EventHandler(this.buttonEditarCarroOficina_Click);
            // 
            // groupBoxCriarCarroOficina
            // 
            this.groupBoxCriarCarroOficina.Controls.Add(this.maskedTextBoxChassiOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.buttonGuardarCarroOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.numericUpDownKMsOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxModeloOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxMarcaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.comboBoxCombustivelOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelCombustivelOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelModeloOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelMarcaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelNChassisOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelQuilometragemOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.maskedTextBoxMatriculaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelMatriculaOficina);
            this.groupBoxCriarCarroOficina.Location = new System.Drawing.Point(0, 311);
            this.groupBoxCriarCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarCarroOficina.Name = "groupBoxCriarCarroOficina";
            this.groupBoxCriarCarroOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCriarCarroOficina.Size = new System.Drawing.Size(260, 250);
            this.groupBoxCriarCarroOficina.TabIndex = 3;
            this.groupBoxCriarCarroOficina.TabStop = false;
            this.groupBoxCriarCarroOficina.Text = "Criar / Editar Carro";
            // 
            // maskedTextBoxChassiOficina
            // 
            this.maskedTextBoxChassiOficina.Location = new System.Drawing.Point(88, 87);
            this.maskedTextBoxChassiOficina.Mask = "00000000000000000";
            this.maskedTextBoxChassiOficina.Name = "maskedTextBoxChassiOficina";
            this.maskedTextBoxChassiOficina.Size = new System.Drawing.Size(162, 22);
            this.maskedTextBoxChassiOficina.TabIndex = 15;
            this.maskedTextBoxChassiOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuardarCarroOficina
            // 
            this.buttonGuardarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarCarroOficina.Image")));
            this.buttonGuardarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarCarroOficina.Location = new System.Drawing.Point(8, 213);
            this.buttonGuardarCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarCarroOficina.Name = "buttonGuardarCarroOficina";
            this.buttonGuardarCarroOficina.Size = new System.Drawing.Size(244, 28);
            this.buttonGuardarCarroOficina.TabIndex = 14;
            this.buttonGuardarCarroOficina.Text = "Guardar";
            this.buttonGuardarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonGuardarCarroOficina.Click += new System.EventHandler(this.buttonGuardarCarroOficina_Click);
            // 
            // numericUpDownKMsOficina
            // 
            this.numericUpDownKMsOficina.Location = new System.Drawing.Point(127, 54);
            this.numericUpDownKMsOficina.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKMsOficina.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDownKMsOficina.Name = "numericUpDownKMsOficina";
            this.numericUpDownKMsOficina.Size = new System.Drawing.Size(124, 22);
            this.numericUpDownKMsOficina.TabIndex = 12;
            // 
            // textBoxModeloOficina
            // 
            this.textBoxModeloOficina.Location = new System.Drawing.Point(76, 150);
            this.textBoxModeloOficina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModeloOficina.Name = "textBoxModeloOficina";
            this.textBoxModeloOficina.Size = new System.Drawing.Size(175, 22);
            this.textBoxModeloOficina.TabIndex = 9;
            // 
            // textBoxMarcaOficina
            // 
            this.textBoxMarcaOficina.Location = new System.Drawing.Point(69, 118);
            this.textBoxMarcaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarcaOficina.Name = "textBoxMarcaOficina";
            this.textBoxMarcaOficina.Size = new System.Drawing.Size(181, 22);
            this.textBoxMarcaOficina.TabIndex = 8;
            // 
            // comboBoxCombustivelOficina
            // 
            this.comboBoxCombustivelOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivelOficina.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCombustivelOficina.FormattingEnabled = true;
            this.comboBoxCombustivelOficina.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Diesel",
            "Gás",
            "Híbrido"});
            this.comboBoxCombustivelOficina.Location = new System.Drawing.Point(109, 182);
            this.comboBoxCombustivelOficina.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCombustivelOficina.Name = "comboBoxCombustivelOficina";
            this.comboBoxCombustivelOficina.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCombustivelOficina.TabIndex = 10;
            // 
            // labelCombustivelOficina
            // 
            this.labelCombustivelOficina.AutoSize = true;
            this.labelCombustivelOficina.Location = new System.Drawing.Point(9, 186);
            this.labelCombustivelOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCombustivelOficina.Name = "labelCombustivelOficina";
            this.labelCombustivelOficina.Size = new System.Drawing.Size(88, 17);
            this.labelCombustivelOficina.TabIndex = 9;
            this.labelCombustivelOficina.Text = "Combustível:";
            // 
            // labelModeloOficina
            // 
            this.labelModeloOficina.AutoSize = true;
            this.labelModeloOficina.Location = new System.Drawing.Point(8, 154);
            this.labelModeloOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModeloOficina.Name = "labelModeloOficina";
            this.labelModeloOficina.Size = new System.Drawing.Size(58, 17);
            this.labelModeloOficina.TabIndex = 8;
            this.labelModeloOficina.Text = "Modelo:";
            // 
            // labelMarcaOficina
            // 
            this.labelMarcaOficina.AutoSize = true;
            this.labelMarcaOficina.Location = new System.Drawing.Point(8, 122);
            this.labelMarcaOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarcaOficina.Name = "labelMarcaOficina";
            this.labelMarcaOficina.Size = new System.Drawing.Size(51, 17);
            this.labelMarcaOficina.TabIndex = 7;
            this.labelMarcaOficina.Text = "Marca:";
            // 
            // labelNChassisOficina
            // 
            this.labelNChassisOficina.AutoSize = true;
            this.labelNChassisOficina.Location = new System.Drawing.Point(8, 90);
            this.labelNChassisOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNChassisOficina.Name = "labelNChassisOficina";
            this.labelNChassisOficina.Size = new System.Drawing.Size(73, 17);
            this.labelNChassisOficina.TabIndex = 6;
            this.labelNChassisOficina.Text = "Nº Chassi:";
            // 
            // labelQuilometragemOficina
            // 
            this.labelQuilometragemOficina.AutoSize = true;
            this.labelQuilometragemOficina.Location = new System.Drawing.Point(8, 58);
            this.labelQuilometragemOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuilometragemOficina.Name = "labelQuilometragemOficina";
            this.labelQuilometragemOficina.Size = new System.Drawing.Size(112, 17);
            this.labelQuilometragemOficina.TabIndex = 4;
            this.labelQuilometragemOficina.Text = "Quilometragem: ";
            // 
            // maskedTextBoxMatriculaOficina
            // 
            this.maskedTextBoxMatriculaOficina.Location = new System.Drawing.Point(93, 22);
            this.maskedTextBoxMatriculaOficina.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMatriculaOficina.Mask = "AA-AA-AA";
            this.maskedTextBoxMatriculaOficina.Name = "maskedTextBoxMatriculaOficina";
            this.maskedTextBoxMatriculaOficina.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxMatriculaOficina.TabIndex = 5;
            // 
            // labelMatriculaOficina
            // 
            this.labelMatriculaOficina.AutoSize = true;
            this.labelMatriculaOficina.Location = new System.Drawing.Point(9, 26);
            this.labelMatriculaOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatriculaOficina.Name = "labelMatriculaOficina";
            this.labelMatriculaOficina.Size = new System.Drawing.Size(69, 17);
            this.labelMatriculaOficina.TabIndex = 2;
            this.labelMatriculaOficina.Text = "Matrícula:";
            // 
            // buttonRemoverCarroOficina
            // 
            this.buttonRemoverCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverCarroOficina.Image")));
            this.buttonRemoverCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverCarroOficina.Location = new System.Drawing.Point(7, 92);
            this.buttonRemoverCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoverCarroOficina.Name = "buttonRemoverCarroOficina";
            this.buttonRemoverCarroOficina.Size = new System.Drawing.Size(244, 28);
            this.buttonRemoverCarroOficina.TabIndex = 12;
            this.buttonRemoverCarroOficina.Text = "Apagar";
            this.buttonRemoverCarroOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverCarroOficina.Click += new System.EventHandler(this.buttonRemoverCarroOficina_Click);
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.ItemHeight = 16;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(8, 128);
            this.listBoxCarrosOficina.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.ScrollAlwaysVisible = true;
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(243, 180);
            this.listBoxCarrosOficina.TabIndex = 4;
            this.listBoxCarrosOficina.Click += new System.EventHandler(this.listBoxCarrosOficina_Click);
            // 
            // buttonCriarCarroOficina
            // 
            this.buttonCriarCarroOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCriarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarCarroOficina.Image")));
            this.buttonCriarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCriarCarroOficina.Location = new System.Drawing.Point(7, 21);
            this.buttonCriarCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriarCarroOficina.Name = "buttonCriarCarroOficina";
            this.buttonCriarCarroOficina.Size = new System.Drawing.Size(244, 28);
            this.buttonCriarCarroOficina.TabIndex = 11;
            this.buttonCriarCarroOficina.Text = "Criar";
            this.buttonCriarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonCriarCarroOficina.Click += new System.EventHandler(this.buttonAdicionarCarroOficina_Click);
            // 
            // groupBoxFichaClienteOficina
            // 
            this.groupBoxFichaClienteOficina.Controls.Add(this.groupBox1);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNifClienteSelecionadoOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelClienteSelecionadoOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNifOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNomeOficina);
            this.groupBoxFichaClienteOficina.Location = new System.Drawing.Point(292, 10);
            this.groupBoxFichaClienteOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteOficina.Name = "groupBoxFichaClienteOficina";
            this.groupBoxFichaClienteOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteOficina.Size = new System.Drawing.Size(908, 123);
            this.groupBoxFichaClienteOficina.TabIndex = 2;
            this.groupBoxFichaClienteOficina.TabStop = false;
            this.groupBoxFichaClienteOficina.Text = "Ficha do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalGastoOficina);
            this.groupBox1.Controls.Add(this.labelTotalClienteOficina);
            this.groupBox1.Location = new System.Drawing.Point(737, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalGastoOficina
            // 
            this.labelTotalGastoOficina.AutoSize = true;
            this.labelTotalGastoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGastoOficina.Location = new System.Drawing.Point(56, 36);
            this.labelTotalGastoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalGastoOficina.Name = "labelTotalGastoOficina";
            this.labelTotalGastoOficina.Size = new System.Drawing.Size(109, 24);
            this.labelTotalGastoOficina.TabIndex = 4;
            this.labelTotalGastoOficina.Text = "Total Gasto:";
            // 
            // labelTotalClienteOficina
            // 
            this.labelTotalClienteOficina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalClienteOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelTotalClienteOficina.ForeColor = System.Drawing.Color.Brown;
            this.labelTotalClienteOficina.Location = new System.Drawing.Point(10, 74);
            this.labelTotalClienteOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalClienteOficina.Name = "labelTotalClienteOficina";
            this.labelTotalClienteOficina.Size = new System.Drawing.Size(155, 24);
            this.labelTotalClienteOficina.TabIndex = 5;
            this.labelTotalClienteOficina.Text = "000,00€";
            this.labelTotalClienteOficina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNifClienteSelecionadoOficina
            // 
            this.labelNifClienteSelecionadoOficina.AutoSize = true;
            this.labelNifClienteSelecionadoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoOficina.Location = new System.Drawing.Point(68, 74);
            this.labelNifClienteSelecionadoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifClienteSelecionadoOficina.Name = "labelNifClienteSelecionadoOficina";
            this.labelNifClienteSelecionadoOficina.Size = new System.Drawing.Size(103, 29);
            this.labelNifClienteSelecionadoOficina.TabIndex = 3;
            this.labelNifClienteSelecionadoOficina.Text = "*********";
            // 
            // labelClienteSelecionadoOficina
            // 
            this.labelClienteSelecionadoOficina.AutoSize = true;
            this.labelClienteSelecionadoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionadoOficina.Location = new System.Drawing.Point(89, 27);
            this.labelClienteSelecionadoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionadoOficina.Name = "labelClienteSelecionadoOficina";
            this.labelClienteSelecionadoOficina.Size = new System.Drawing.Size(319, 29);
            this.labelClienteSelecionadoOficina.TabIndex = 2;
            this.labelClienteSelecionadoOficina.Text = "Nenhum cliente selecionado";
            // 
            // labelNifOficina
            // 
            this.labelNifOficina.AutoSize = true;
            this.labelNifOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifOficina.Location = new System.Drawing.Point(8, 74);
            this.labelNifOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifOficina.Name = "labelNifOficina";
            this.labelNifOficina.Size = new System.Drawing.Size(49, 25);
            this.labelNifOficina.TabIndex = 1;
            this.labelNifOficina.Text = "NIF:";
            // 
            // labelNomeOficina
            // 
            this.labelNomeOficina.AutoSize = true;
            this.labelNomeOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeOficina.Location = new System.Drawing.Point(8, 27);
            this.labelNomeOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeOficina.Name = "labelNomeOficina";
            this.labelNomeOficina.Size = new System.Drawing.Size(70, 25);
            this.labelNomeOficina.TabIndex = 0;
            this.labelNomeOficina.Text = "Nome:";
            // 
            // groupBoxClientesOficina
            // 
            this.groupBoxClientesOficina.Controls.Add(this.labelProcurarPorOficina);
            this.groupBoxClientesOficina.Controls.Add(this.labelTextoOficina);
            this.groupBoxClientesOficina.Controls.Add(this.comboBoxCampoOficina);
            this.groupBoxClientesOficina.Controls.Add(this.textBoxProcurarPorOficina);
            this.groupBoxClientesOficina.Controls.Add(this.listBoxClientesOficina);
            this.groupBoxClientesOficina.Location = new System.Drawing.Point(12, 59);
            this.groupBoxClientesOficina.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClientesOficina.Name = "groupBoxClientesOficina";
            this.groupBoxClientesOficina.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClientesOficina.Size = new System.Drawing.Size(272, 642);
            this.groupBoxClientesOficina.TabIndex = 1;
            this.groupBoxClientesOficina.TabStop = false;
            this.groupBoxClientesOficina.Text = "Lista de Clientes";
            // 
            // labelProcurarPorOficina
            // 
            this.labelProcurarPorOficina.AutoSize = true;
            this.labelProcurarPorOficina.Location = new System.Drawing.Point(8, 30);
            this.labelProcurarPorOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcurarPorOficina.Name = "labelProcurarPorOficina";
            this.labelProcurarPorOficina.Size = new System.Drawing.Size(92, 17);
            this.labelProcurarPorOficina.TabIndex = 4;
            this.labelProcurarPorOficina.Text = "Procurar por:";
            // 
            // labelTextoOficina
            // 
            this.labelTextoOficina.AutoSize = true;
            this.labelTextoOficina.Location = new System.Drawing.Point(161, 28);
            this.labelTextoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextoOficina.Name = "labelTextoOficina";
            this.labelTextoOficina.Size = new System.Drawing.Size(56, 17);
            this.labelTextoOficina.TabIndex = 3;
            this.labelTextoOficina.Text = "Campo:";
            // 
            // comboBoxCampoOficina
            // 
            this.comboBoxCampoOficina.FormattingEnabled = true;
            this.comboBoxCampoOficina.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoOficina.Location = new System.Drawing.Point(164, 48);
            this.comboBoxCampoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampoOficina.Name = "comboBoxCampoOficina";
            this.comboBoxCampoOficina.Size = new System.Drawing.Size(99, 24);
            this.comboBoxCampoOficina.TabIndex = 2;
            // 
            // textBoxProcurarPorOficina
            // 
            this.textBoxProcurarPorOficina.Location = new System.Drawing.Point(9, 49);
            this.textBoxProcurarPorOficina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProcurarPorOficina.Name = "textBoxProcurarPorOficina";
            this.textBoxProcurarPorOficina.Size = new System.Drawing.Size(143, 22);
            this.textBoxProcurarPorOficina.TabIndex = 1;
            // 
            // listBoxClientesOficina
            // 
            this.listBoxClientesOficina.FormattingEnabled = true;
            this.listBoxClientesOficina.ItemHeight = 16;
            this.listBoxClientesOficina.Location = new System.Drawing.Point(9, 85);
            this.listBoxClientesOficina.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientesOficina.Name = "listBoxClientesOficina";
            this.listBoxClientesOficina.ScrollAlwaysVisible = true;
            this.listBoxClientesOficina.Size = new System.Drawing.Size(253, 548);
            this.listBoxClientesOficina.TabIndex = 3;
            this.listBoxClientesOficina.Click += new System.EventHandler(this.listBoxClientesOficina_Click);
            // 
            // labelTituloOficina
            // 
            this.labelTituloOficina.AutoSize = true;
            this.labelTituloOficina.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloOficina.ForeColor = System.Drawing.Color.Brown;
            this.labelTituloOficina.Location = new System.Drawing.Point(13, 10);
            this.labelTituloOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloOficina.Name = "labelTituloOficina";
            this.labelTituloOficina.Size = new System.Drawing.Size(134, 39);
            this.labelTituloOficina.TabIndex = 0;
            this.labelTituloOficina.Text = "Oficina";
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.Color.Silver;
            this.tabPageVendas.Controls.Add(this.groupBoxDetalhesVendaECarroVendas);
            this.tabPageVendas.Controls.Add(this.groupBoxVendasCliente);
            this.tabPageVendas.Controls.Add(this.groupBoxListaClientesVendas);
            this.tabPageVendas.Controls.Add(this.labelTituloVendas);
            this.tabPageVendas.Controls.Add(this.groupBoxFichaClienteVendas);
            this.tabPageVendas.Location = new System.Drawing.Point(166, 4);
            this.tabPageVendas.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Size = new System.Drawing.Size(1273, 707);
            this.tabPageVendas.TabIndex = 3;
            this.tabPageVendas.Text = "Vendas";
            // 
            // groupBoxDetalhesVendaECarroVendas
            // 
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.groupBoxDetalhesCarroVenda);
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.groupBoxDetalhesDaVenda);
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.buttonGuardarVendas);
            this.groupBoxDetalhesVendaECarroVendas.Location = new System.Drawing.Point(896, 140);
            this.groupBoxDetalhesVendaECarroVendas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesVendaECarroVendas.Name = "groupBoxDetalhesVendaECarroVendas";
            this.groupBoxDetalhesVendaECarroVendas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesVendaECarroVendas.Size = new System.Drawing.Size(304, 561);
            this.groupBoxDetalhesVendaECarroVendas.TabIndex = 36;
            this.groupBoxDetalhesVendaECarroVendas.TabStop = false;
            this.groupBoxDetalhesVendaECarroVendas.Text = "Detalhes";
            // 
            // groupBoxDetalhesCarroVenda
            // 
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.maskedTextBox1);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.labelNChassis);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.labelCombustivelVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.textBoxExtrasVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.comboBoxCombustivelVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.labelModeloVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.labelExtrasVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.textBoxModeloVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.labelMarcaVendas);
            this.groupBoxDetalhesCarroVenda.Controls.Add(this.textBoxMarcaVendas);
            this.groupBoxDetalhesCarroVenda.Location = new System.Drawing.Point(8, 23);
            this.groupBoxDetalhesCarroVenda.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesCarroVenda.Name = "groupBoxDetalhesCarroVenda";
            this.groupBoxDetalhesCarroVenda.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesCarroVenda.Size = new System.Drawing.Size(288, 266);
            this.groupBoxDetalhesCarroVenda.TabIndex = 30;
            this.groupBoxDetalhesCarroVenda.TabStop = false;
            this.groupBoxDetalhesCarroVenda.Text = "Detalhes do carro";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 40);
            this.maskedTextBox1.Mask = "00000000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNChassis
            // 
            this.labelNChassis.AutoSize = true;
            this.labelNChassis.Location = new System.Drawing.Point(8, 43);
            this.labelNChassis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNChassis.Name = "labelNChassis";
            this.labelNChassis.Size = new System.Drawing.Size(73, 17);
            this.labelNChassis.TabIndex = 6;
            this.labelNChassis.Text = "Nº Chassi:";
            // 
            // labelCombustivelVendas
            // 
            this.labelCombustivelVendas.AutoSize = true;
            this.labelCombustivelVendas.Location = new System.Drawing.Point(8, 178);
            this.labelCombustivelVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCombustivelVendas.Name = "labelCombustivelVendas";
            this.labelCombustivelVendas.Size = new System.Drawing.Size(88, 17);
            this.labelCombustivelVendas.TabIndex = 9;
            this.labelCombustivelVendas.Text = "Combustível:";
            // 
            // textBoxExtrasVendas
            // 
            this.textBoxExtrasVendas.Location = new System.Drawing.Point(64, 224);
            this.textBoxExtrasVendas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExtrasVendas.Multiline = true;
            this.textBoxExtrasVendas.Name = "textBoxExtrasVendas";
            this.textBoxExtrasVendas.Size = new System.Drawing.Size(213, 24);
            this.textBoxExtrasVendas.TabIndex = 15;
            // 
            // comboBoxCombustivelVendas
            // 
            this.comboBoxCombustivelVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivelVendas.FormattingEnabled = true;
            this.comboBoxCombustivelVendas.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Diesel",
            "Gás",
            "Híbrido"});
            this.comboBoxCombustivelVendas.Location = new System.Drawing.Point(108, 178);
            this.comboBoxCombustivelVendas.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCombustivelVendas.Name = "comboBoxCombustivelVendas";
            this.comboBoxCombustivelVendas.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCombustivelVendas.TabIndex = 10;
            // 
            // labelModeloVendas
            // 
            this.labelModeloVendas.AutoSize = true;
            this.labelModeloVendas.Location = new System.Drawing.Point(8, 137);
            this.labelModeloVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModeloVendas.Name = "labelModeloVendas";
            this.labelModeloVendas.Size = new System.Drawing.Size(58, 17);
            this.labelModeloVendas.TabIndex = 8;
            this.labelModeloVendas.Text = "Modelo:";
            // 
            // labelExtrasVendas
            // 
            this.labelExtrasVendas.AutoSize = true;
            this.labelExtrasVendas.Location = new System.Drawing.Point(8, 228);
            this.labelExtrasVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtrasVendas.Name = "labelExtrasVendas";
            this.labelExtrasVendas.Size = new System.Drawing.Size(46, 17);
            this.labelExtrasVendas.TabIndex = 14;
            this.labelExtrasVendas.Text = "Extas:";
            // 
            // textBoxModeloVendas
            // 
            this.textBoxModeloVendas.Location = new System.Drawing.Point(77, 133);
            this.textBoxModeloVendas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModeloVendas.Name = "textBoxModeloVendas";
            this.textBoxModeloVendas.Size = new System.Drawing.Size(201, 22);
            this.textBoxModeloVendas.TabIndex = 13;
            // 
            // labelMarcaVendas
            // 
            this.labelMarcaVendas.AutoSize = true;
            this.labelMarcaVendas.Location = new System.Drawing.Point(8, 87);
            this.labelMarcaVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarcaVendas.Name = "labelMarcaVendas";
            this.labelMarcaVendas.Size = new System.Drawing.Size(51, 17);
            this.labelMarcaVendas.TabIndex = 7;
            this.labelMarcaVendas.Text = "Marca:";
            // 
            // textBoxMarcaVendas
            // 
            this.textBoxMarcaVendas.Location = new System.Drawing.Point(71, 84);
            this.textBoxMarcaVendas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarcaVendas.Name = "textBoxMarcaVendas";
            this.textBoxMarcaVendas.Size = new System.Drawing.Size(205, 22);
            this.textBoxMarcaVendas.TabIndex = 12;
            // 
            // groupBoxDetalhesDaVenda
            // 
            this.groupBoxDetalhesDaVenda.Controls.Add(this.labelDataVendaVendas);
            this.groupBoxDetalhesDaVenda.Controls.Add(this.maskedTextBoxValorVenda);
            this.groupBoxDetalhesDaVenda.Controls.Add(this.labelValorVendas);
            this.groupBoxDetalhesDaVenda.Controls.Add(this.labelEstadoVendas);
            this.groupBoxDetalhesDaVenda.Controls.Add(this.dateTimePickerDataVenda);
            this.groupBoxDetalhesDaVenda.Controls.Add(this.textBoxEstadoVendas);
            this.groupBoxDetalhesDaVenda.Location = new System.Drawing.Point(8, 308);
            this.groupBoxDetalhesDaVenda.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesDaVenda.Name = "groupBoxDetalhesDaVenda";
            this.groupBoxDetalhesDaVenda.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalhesDaVenda.Size = new System.Drawing.Size(288, 170);
            this.groupBoxDetalhesDaVenda.TabIndex = 29;
            this.groupBoxDetalhesDaVenda.TabStop = false;
            this.groupBoxDetalhesDaVenda.Text = "Detalhes de venda";
            // 
            // labelDataVendaVendas
            // 
            this.labelDataVendaVendas.AutoSize = true;
            this.labelDataVendaVendas.Location = new System.Drawing.Point(8, 37);
            this.labelDataVendaVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataVendaVendas.Name = "labelDataVendaVendas";
            this.labelDataVendaVendas.Size = new System.Drawing.Size(107, 17);
            this.labelDataVendaVendas.TabIndex = 20;
            this.labelDataVendaVendas.Text = "Data de Venda:";
            // 
            // maskedTextBoxValorVenda
            // 
            this.maskedTextBoxValorVenda.Location = new System.Drawing.Point(152, 122);
            this.maskedTextBoxValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxValorVenda.Mask = "€0000000.00";
            this.maskedTextBoxValorVenda.Name = "maskedTextBoxValorVenda";
            this.maskedTextBoxValorVenda.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBoxValorVenda.TabIndex = 28;
            this.maskedTextBoxValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelValorVendas
            // 
            this.labelValorVendas.AutoSize = true;
            this.labelValorVendas.Location = new System.Drawing.Point(8, 126);
            this.labelValorVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorVendas.Name = "labelValorVendas";
            this.labelValorVendas.Size = new System.Drawing.Size(110, 17);
            this.labelValorVendas.TabIndex = 25;
            this.labelValorVendas.Text = "Valor da Venda:";
            // 
            // labelEstadoVendas
            // 
            this.labelEstadoVendas.AutoSize = true;
            this.labelEstadoVendas.Location = new System.Drawing.Point(8, 84);
            this.labelEstadoVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoVendas.Name = "labelEstadoVendas";
            this.labelEstadoVendas.Size = new System.Drawing.Size(60, 17);
            this.labelEstadoVendas.TabIndex = 26;
            this.labelEstadoVendas.Text = "Estado: ";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(125, 28);
            this.dateTimePickerDataVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(151, 22);
            this.dateTimePickerDataVenda.TabIndex = 23;
            // 
            // textBoxEstadoVendas
            // 
            this.textBoxEstadoVendas.Location = new System.Drawing.Point(96, 79);
            this.textBoxEstadoVendas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEstadoVendas.Name = "textBoxEstadoVendas";
            this.textBoxEstadoVendas.Size = new System.Drawing.Size(183, 22);
            this.textBoxEstadoVendas.TabIndex = 27;
            // 
            // buttonGuardarVendas
            // 
            this.buttonGuardarVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarVendas.Image")));
            this.buttonGuardarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarVendas.Location = new System.Drawing.Point(8, 495);
            this.buttonGuardarVendas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarVendas.Name = "buttonGuardarVendas";
            this.buttonGuardarVendas.Size = new System.Drawing.Size(288, 57);
            this.buttonGuardarVendas.TabIndex = 16;
            this.buttonGuardarVendas.Text = "Guardar";
            this.buttonGuardarVendas.UseVisualStyleBackColor = true;
            this.buttonGuardarVendas.Click += new System.EventHandler(this.buttonGuardarVendas_Click);
            // 
            // groupBoxVendasCliente
            // 
            this.groupBoxVendasCliente.Controls.Add(this.buttonEditarVenda);
            this.groupBoxVendasCliente.Controls.Add(this.buttonAnularVenda);
            this.groupBoxVendasCliente.Controls.Add(this.buttonCriarVenda);
            this.groupBoxVendasCliente.Controls.Add(this.listBoxVendasDoCliente);
            this.groupBoxVendasCliente.Location = new System.Drawing.Point(489, 140);
            this.groupBoxVendasCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVendasCliente.Name = "groupBoxVendasCliente";
            this.groupBoxVendasCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVendasCliente.Size = new System.Drawing.Size(352, 561);
            this.groupBoxVendasCliente.TabIndex = 35;
            this.groupBoxVendasCliente.TabStop = false;
            this.groupBoxVendasCliente.Text = "Vendas do cliente";
            // 
            // buttonEditarVenda
            // 
            this.buttonEditarVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarVenda.Image")));
            this.buttonEditarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarVenda.Location = new System.Drawing.Point(8, 63);
            this.buttonEditarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarVenda.Name = "buttonEditarVenda";
            this.buttonEditarVenda.Size = new System.Drawing.Size(336, 32);
            this.buttonEditarVenda.TabIndex = 30;
            this.buttonEditarVenda.Text = "Editar venda";
            this.buttonEditarVenda.UseVisualStyleBackColor = true;
            this.buttonEditarVenda.Click += new System.EventHandler(this.buttonEditarVenda_Click);
            // 
            // buttonAnularVenda
            // 
            this.buttonAnularVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnularVenda.Image")));
            this.buttonAnularVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnularVenda.Location = new System.Drawing.Point(8, 102);
            this.buttonAnularVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnularVenda.Name = "buttonAnularVenda";
            this.buttonAnularVenda.Size = new System.Drawing.Size(336, 32);
            this.buttonAnularVenda.TabIndex = 1;
            this.buttonAnularVenda.Text = "Anular venda";
            this.buttonAnularVenda.UseVisualStyleBackColor = true;
            this.buttonAnularVenda.Click += new System.EventHandler(this.buttonAnularVenda_Click);
            // 
            // buttonCriarVenda
            // 
            this.buttonCriarVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarVenda.Image")));
            this.buttonCriarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCriarVenda.Location = new System.Drawing.Point(8, 23);
            this.buttonCriarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriarVenda.Name = "buttonCriarVenda";
            this.buttonCriarVenda.Size = new System.Drawing.Size(336, 32);
            this.buttonCriarVenda.TabIndex = 17;
            this.buttonCriarVenda.Text = "Criar venda";
            this.buttonCriarVenda.UseVisualStyleBackColor = true;
            this.buttonCriarVenda.Click += new System.EventHandler(this.buttonCriarVenda_Click);
            // 
            // listBoxVendasDoCliente
            // 
            this.listBoxVendasDoCliente.FormattingEnabled = true;
            this.listBoxVendasDoCliente.ItemHeight = 16;
            this.listBoxVendasDoCliente.Location = new System.Drawing.Point(8, 148);
            this.listBoxVendasDoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVendasDoCliente.Name = "listBoxVendasDoCliente";
            this.listBoxVendasDoCliente.ScrollAlwaysVisible = true;
            this.listBoxVendasDoCliente.Size = new System.Drawing.Size(335, 404);
            this.listBoxVendasDoCliente.TabIndex = 0;
            this.listBoxVendasDoCliente.Click += new System.EventHandler(this.listBoxVendasDoCliente_Click);
            // 
            // groupBoxListaClientesVendas
            // 
            this.groupBoxListaClientesVendas.Controls.Add(this.buttonFiltarVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.labelProcurarPorVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.labelCampoVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.comboBoxCampoVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.textBoxProcurarPorVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.listBoxClientesVendas);
            this.groupBoxListaClientesVendas.Location = new System.Drawing.Point(12, 59);
            this.groupBoxListaClientesVendas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListaClientesVendas.Name = "groupBoxListaClientesVendas";
            this.groupBoxListaClientesVendas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListaClientesVendas.Size = new System.Drawing.Size(423, 642);
            this.groupBoxListaClientesVendas.TabIndex = 34;
            this.groupBoxListaClientesVendas.TabStop = false;
            this.groupBoxListaClientesVendas.Text = "Lista de Clientes";
            // 
            // buttonFiltarVendas
            // 
            this.buttonFiltarVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltarVendas.Image")));
            this.buttonFiltarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltarVendas.Location = new System.Drawing.Point(328, 47);
            this.buttonFiltarVendas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltarVendas.Name = "buttonFiltarVendas";
            this.buttonFiltarVendas.Size = new System.Drawing.Size(87, 28);
            this.buttonFiltarVendas.TabIndex = 5;
            this.buttonFiltarVendas.Text = "Filtrar";
            this.buttonFiltarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFiltarVendas.UseVisualStyleBackColor = true;
            // 
            // labelProcurarPorVendas
            // 
            this.labelProcurarPorVendas.AutoSize = true;
            this.labelProcurarPorVendas.Location = new System.Drawing.Point(8, 30);
            this.labelProcurarPorVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcurarPorVendas.Name = "labelProcurarPorVendas";
            this.labelProcurarPorVendas.Size = new System.Drawing.Size(92, 17);
            this.labelProcurarPorVendas.TabIndex = 4;
            this.labelProcurarPorVendas.Text = "Procurar por:";
            // 
            // labelCampoVendas
            // 
            this.labelCampoVendas.AutoSize = true;
            this.labelCampoVendas.Location = new System.Drawing.Point(216, 28);
            this.labelCampoVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampoVendas.Name = "labelCampoVendas";
            this.labelCampoVendas.Size = new System.Drawing.Size(56, 17);
            this.labelCampoVendas.TabIndex = 3;
            this.labelCampoVendas.Text = "Campo:";
            // 
            // comboBoxCampoVendas
            // 
            this.comboBoxCampoVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampoVendas.FormattingEnabled = true;
            this.comboBoxCampoVendas.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoVendas.Location = new System.Drawing.Point(220, 48);
            this.comboBoxCampoVendas.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampoVendas.Name = "comboBoxCampoVendas";
            this.comboBoxCampoVendas.Size = new System.Drawing.Size(99, 24);
            this.comboBoxCampoVendas.TabIndex = 2;
            // 
            // textBoxProcurarPorVendas
            // 
            this.textBoxProcurarPorVendas.Location = new System.Drawing.Point(9, 49);
            this.textBoxProcurarPorVendas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProcurarPorVendas.Name = "textBoxProcurarPorVendas";
            this.textBoxProcurarPorVendas.Size = new System.Drawing.Size(201, 22);
            this.textBoxProcurarPorVendas.TabIndex = 1;
            // 
            // listBoxClientesVendas
            // 
            this.listBoxClientesVendas.FormattingEnabled = true;
            this.listBoxClientesVendas.ItemHeight = 16;
            this.listBoxClientesVendas.Location = new System.Drawing.Point(9, 85);
            this.listBoxClientesVendas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientesVendas.Name = "listBoxClientesVendas";
            this.listBoxClientesVendas.ScrollAlwaysVisible = true;
            this.listBoxClientesVendas.Size = new System.Drawing.Size(404, 548);
            this.listBoxClientesVendas.TabIndex = 3;
            this.listBoxClientesVendas.Click += new System.EventHandler(this.listBoxClientesVendas_Click);
            // 
            // labelTituloVendas
            // 
            this.labelTituloVendas.AutoSize = true;
            this.labelTituloVendas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloVendas.ForeColor = System.Drawing.Color.Chocolate;
            this.labelTituloVendas.Location = new System.Drawing.Point(13, 10);
            this.labelTituloVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloVendas.Name = "labelTituloVendas";
            this.labelTituloVendas.Size = new System.Drawing.Size(140, 39);
            this.labelTituloVendas.TabIndex = 33;
            this.labelTituloVendas.Text = "Vendas";
            // 
            // groupBoxFichaClienteVendas
            // 
            this.groupBoxFichaClienteVendas.Controls.Add(this.groupBoxTotalVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNifClienteSelecionadoVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNomeClienteSelecionadoVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNifVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNomeVendas);
            this.groupBoxFichaClienteVendas.Location = new System.Drawing.Point(443, 10);
            this.groupBoxFichaClienteVendas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteVendas.Name = "groupBoxFichaClienteVendas";
            this.groupBoxFichaClienteVendas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteVendas.Size = new System.Drawing.Size(757, 123);
            this.groupBoxFichaClienteVendas.TabIndex = 32;
            this.groupBoxFichaClienteVendas.TabStop = false;
            this.groupBoxFichaClienteVendas.Text = "Ficha do Cliente";
            // 
            // groupBoxTotalVendas
            // 
            this.groupBoxTotalVendas.Controls.Add(this.label5);
            this.groupBoxTotalVendas.Controls.Add(this.labelTotalVendas);
            this.groupBoxTotalVendas.Location = new System.Drawing.Point(586, 0);
            this.groupBoxTotalVendas.Name = "groupBoxTotalVendas";
            this.groupBoxTotalVendas.Size = new System.Drawing.Size(171, 123);
            this.groupBoxTotalVendas.TabIndex = 7;
            this.groupBoxTotalVendas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total em Vendas:";
            // 
            // labelTotalVendas
            // 
            this.labelTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVendas.ForeColor = System.Drawing.Color.Chocolate;
            this.labelTotalVendas.Location = new System.Drawing.Point(6, 74);
            this.labelTotalVendas.Name = "labelTotalVendas";
            this.labelTotalVendas.Size = new System.Drawing.Size(159, 25);
            this.labelTotalVendas.TabIndex = 4;
            this.labelTotalVendas.Text = "00 000 000,00€";
            this.labelTotalVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNifClienteSelecionadoVendas
            // 
            this.labelNifClienteSelecionadoVendas.AutoSize = true;
            this.labelNifClienteSelecionadoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoVendas.Location = new System.Drawing.Point(68, 74);
            this.labelNifClienteSelecionadoVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifClienteSelecionadoVendas.Name = "labelNifClienteSelecionadoVendas";
            this.labelNifClienteSelecionadoVendas.Size = new System.Drawing.Size(103, 29);
            this.labelNifClienteSelecionadoVendas.TabIndex = 3;
            this.labelNifClienteSelecionadoVendas.Text = "*********";
            // 
            // labelNomeClienteSelecionadoVendas
            // 
            this.labelNomeClienteSelecionadoVendas.AutoSize = true;
            this.labelNomeClienteSelecionadoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeClienteSelecionadoVendas.Location = new System.Drawing.Point(89, 27);
            this.labelNomeClienteSelecionadoVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeClienteSelecionadoVendas.Name = "labelNomeClienteSelecionadoVendas";
            this.labelNomeClienteSelecionadoVendas.Size = new System.Drawing.Size(319, 29);
            this.labelNomeClienteSelecionadoVendas.TabIndex = 2;
            this.labelNomeClienteSelecionadoVendas.Text = "Nenhum cliente selecionado";
            // 
            // labelNifVendas
            // 
            this.labelNifVendas.AutoSize = true;
            this.labelNifVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifVendas.Location = new System.Drawing.Point(8, 74);
            this.labelNifVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifVendas.Name = "labelNifVendas";
            this.labelNifVendas.Size = new System.Drawing.Size(49, 25);
            this.labelNifVendas.TabIndex = 1;
            this.labelNifVendas.Text = "NIF:";
            // 
            // labelNomeVendas
            // 
            this.labelNomeVendas.AutoSize = true;
            this.labelNomeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeVendas.Location = new System.Drawing.Point(8, 27);
            this.labelNomeVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeVendas.Name = "labelNomeVendas";
            this.labelNomeVendas.Size = new System.Drawing.Size(70, 25);
            this.labelNomeVendas.TabIndex = 0;
            this.labelNomeVendas.Text = "Nome:";
            // 
            // tabPageAluguer
            // 
            this.tabPageAluguer.BackColor = System.Drawing.Color.Silver;
            this.tabPageAluguer.Controls.Add(this.groupBoxAluguerCarro);
            this.tabPageAluguer.Controls.Add(this.groupBoxAdicionarCarroAluguer);
            this.tabPageAluguer.Controls.Add(this.groupBoxCarrosAluguer);
            this.tabPageAluguer.Controls.Add(this.groupBox2);
            this.tabPageAluguer.Controls.Add(this.labelTituloAluguer);
            this.tabPageAluguer.Controls.Add(this.groupBoxFichaClienteVenda);
            this.tabPageAluguer.Location = new System.Drawing.Point(166, 4);
            this.tabPageAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAluguer.Name = "tabPageAluguer";
            this.tabPageAluguer.Size = new System.Drawing.Size(1273, 707);
            this.tabPageAluguer.TabIndex = 4;
            this.tabPageAluguer.Text = "Aluguer";
            // 
            // groupBoxAluguerCarro
            // 
            this.groupBoxAluguerCarro.Controls.Add(this.maskedTextBoxValorAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.textBoxQuilometragemAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.labelQuilometragemAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.labelValorAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.dateTimePickerDataFimAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.dateTimePickerDataInicioAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.labelDataFimAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.labelDataInicioAluguer);
            this.groupBoxAluguerCarro.Controls.Add(this.button3);
            this.groupBoxAluguerCarro.Location = new System.Drawing.Point(940, 465);
            this.groupBoxAluguerCarro.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAluguerCarro.Name = "groupBoxAluguerCarro";
            this.groupBoxAluguerCarro.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAluguerCarro.Size = new System.Drawing.Size(260, 236);
            this.groupBoxAluguerCarro.TabIndex = 15;
            this.groupBoxAluguerCarro.TabStop = false;
            this.groupBoxAluguerCarro.Text = "Alugar Carro";
            // 
            // maskedTextBoxValorAluguer
            // 
            this.maskedTextBoxValorAluguer.Location = new System.Drawing.Point(135, 133);
            this.maskedTextBoxValorAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxValorAluguer.Mask = "€00000.00";
            this.maskedTextBoxValorAluguer.Name = "maskedTextBoxValorAluguer";
            this.maskedTextBoxValorAluguer.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxValorAluguer.TabIndex = 28;
            // 
            // textBoxQuilometragemAluguer
            // 
            this.textBoxQuilometragemAluguer.Location = new System.Drawing.Point(128, 98);
            this.textBoxQuilometragemAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuilometragemAluguer.Name = "textBoxQuilometragemAluguer";
            this.textBoxQuilometragemAluguer.Size = new System.Drawing.Size(124, 22);
            this.textBoxQuilometragemAluguer.TabIndex = 27;
            // 
            // labelQuilometragemAluguer
            // 
            this.labelQuilometragemAluguer.AutoSize = true;
            this.labelQuilometragemAluguer.Location = new System.Drawing.Point(9, 102);
            this.labelQuilometragemAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuilometragemAluguer.Name = "labelQuilometragemAluguer";
            this.labelQuilometragemAluguer.Size = new System.Drawing.Size(112, 17);
            this.labelQuilometragemAluguer.TabIndex = 26;
            this.labelQuilometragemAluguer.Text = "Quilometragem: ";
            // 
            // labelValorAluguer
            // 
            this.labelValorAluguer.AutoSize = true;
            this.labelValorAluguer.Location = new System.Drawing.Point(9, 137);
            this.labelValorAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorAluguer.Name = "labelValorAluguer";
            this.labelValorAluguer.Size = new System.Drawing.Size(118, 17);
            this.labelValorAluguer.TabIndex = 25;
            this.labelValorAluguer.Text = "Valor do Aluguer:";
            // 
            // dateTimePickerDataFimAluguer
            // 
            this.dateTimePickerDataFimAluguer.Location = new System.Drawing.Point(107, 64);
            this.dateTimePickerDataFimAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataFimAluguer.Name = "dateTimePickerDataFimAluguer";
            this.dateTimePickerDataFimAluguer.Size = new System.Drawing.Size(144, 22);
            this.dateTimePickerDataFimAluguer.TabIndex = 24;
            // 
            // dateTimePickerDataInicioAluguer
            // 
            this.dateTimePickerDataInicioAluguer.Location = new System.Drawing.Point(121, 25);
            this.dateTimePickerDataInicioAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataInicioAluguer.Name = "dateTimePickerDataInicioAluguer";
            this.dateTimePickerDataInicioAluguer.Size = new System.Drawing.Size(129, 22);
            this.dateTimePickerDataInicioAluguer.TabIndex = 23;
            // 
            // labelDataFimAluguer
            // 
            this.labelDataFimAluguer.AutoSize = true;
            this.labelDataFimAluguer.Location = new System.Drawing.Point(9, 68);
            this.labelDataFimAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataFimAluguer.Name = "labelDataFimAluguer";
            this.labelDataFimAluguer.Size = new System.Drawing.Size(88, 17);
            this.labelDataFimAluguer.TabIndex = 22;
            this.labelDataFimAluguer.Text = "Data de Fim:";
            // 
            // labelDataInicioAluguer
            // 
            this.labelDataInicioAluguer.AutoSize = true;
            this.labelDataInicioAluguer.Location = new System.Drawing.Point(9, 32);
            this.labelDataInicioAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataInicioAluguer.Name = "labelDataInicioAluguer";
            this.labelDataInicioAluguer.Size = new System.Drawing.Size(98, 17);
            this.labelDataInicioAluguer.TabIndex = 20;
            this.labelDataInicioAluguer.Text = "Data de Início:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "Alugar Carro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdicionarCarroAluguer
            // 
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.checkBoxEstadoAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.textBoxModeloAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.textBoxMarcaAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.textBoxChassiAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.comboBoxCombustivelAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelCombustivelAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelModeloAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelMarcaAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelNChassisAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelAlugadoAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.maskedTextBoxMatriculaAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.labelMatriculaAluguer);
            this.groupBoxAdicionarCarroAluguer.Controls.Add(this.buttonAdicionarCarroAluguer);
            this.groupBoxAdicionarCarroAluguer.Location = new System.Drawing.Point(940, 140);
            this.groupBoxAdicionarCarroAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarroAluguer.Name = "groupBoxAdicionarCarroAluguer";
            this.groupBoxAdicionarCarroAluguer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarroAluguer.Size = new System.Drawing.Size(260, 298);
            this.groupBoxAdicionarCarroAluguer.TabIndex = 3;
            this.groupBoxAdicionarCarroAluguer.TabStop = false;
            this.groupBoxAdicionarCarroAluguer.Text = "Adicionar Novo Carro de Aluguer";
            // 
            // checkBoxEstadoAluguer
            // 
            this.checkBoxEstadoAluguer.AutoSize = true;
            this.checkBoxEstadoAluguer.Location = new System.Drawing.Point(76, 28);
            this.checkBoxEstadoAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEstadoAluguer.Name = "checkBoxEstadoAluguer";
            this.checkBoxEstadoAluguer.Size = new System.Drawing.Size(18, 17);
            this.checkBoxEstadoAluguer.TabIndex = 14;
            this.checkBoxEstadoAluguer.UseVisualStyleBackColor = true;
            // 
            // textBoxModeloAluguer
            // 
            this.textBoxModeloAluguer.Location = new System.Drawing.Point(77, 160);
            this.textBoxModeloAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModeloAluguer.Name = "textBoxModeloAluguer";
            this.textBoxModeloAluguer.Size = new System.Drawing.Size(173, 22);
            this.textBoxModeloAluguer.TabIndex = 13;
            // 
            // textBoxMarcaAluguer
            // 
            this.textBoxMarcaAluguer.Location = new System.Drawing.Point(71, 127);
            this.textBoxMarcaAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarcaAluguer.Name = "textBoxMarcaAluguer";
            this.textBoxMarcaAluguer.Size = new System.Drawing.Size(180, 22);
            this.textBoxMarcaAluguer.TabIndex = 12;
            // 
            // textBoxChassiAluguer
            // 
            this.textBoxChassiAluguer.Location = new System.Drawing.Point(97, 90);
            this.textBoxChassiAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxChassiAluguer.Name = "textBoxChassiAluguer";
            this.textBoxChassiAluguer.Size = new System.Drawing.Size(153, 22);
            this.textBoxChassiAluguer.TabIndex = 11;
            // 
            // comboBoxCombustivelAluguer
            // 
            this.comboBoxCombustivelAluguer.FormattingEnabled = true;
            this.comboBoxCombustivelAluguer.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Diesel",
            "Gás",
            "Híbrido"});
            this.comboBoxCombustivelAluguer.Location = new System.Drawing.Point(109, 196);
            this.comboBoxCombustivelAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCombustivelAluguer.Name = "comboBoxCombustivelAluguer";
            this.comboBoxCombustivelAluguer.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCombustivelAluguer.TabIndex = 10;
            // 
            // labelCombustivelAluguer
            // 
            this.labelCombustivelAluguer.AutoSize = true;
            this.labelCombustivelAluguer.Location = new System.Drawing.Point(9, 199);
            this.labelCombustivelAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCombustivelAluguer.Name = "labelCombustivelAluguer";
            this.labelCombustivelAluguer.Size = new System.Drawing.Size(88, 17);
            this.labelCombustivelAluguer.TabIndex = 9;
            this.labelCombustivelAluguer.Text = "Combustível:";
            // 
            // labelModeloAluguer
            // 
            this.labelModeloAluguer.AutoSize = true;
            this.labelModeloAluguer.Location = new System.Drawing.Point(9, 164);
            this.labelModeloAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModeloAluguer.Name = "labelModeloAluguer";
            this.labelModeloAluguer.Size = new System.Drawing.Size(58, 17);
            this.labelModeloAluguer.TabIndex = 8;
            this.labelModeloAluguer.Text = "Modelo:";
            // 
            // labelMarcaAluguer
            // 
            this.labelMarcaAluguer.AutoSize = true;
            this.labelMarcaAluguer.Location = new System.Drawing.Point(9, 130);
            this.labelMarcaAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarcaAluguer.Name = "labelMarcaAluguer";
            this.labelMarcaAluguer.Size = new System.Drawing.Size(51, 17);
            this.labelMarcaAluguer.TabIndex = 7;
            this.labelMarcaAluguer.Text = "Marca:";
            // 
            // labelNChassisAluguer
            // 
            this.labelNChassisAluguer.AutoSize = true;
            this.labelNChassisAluguer.Location = new System.Drawing.Point(9, 94);
            this.labelNChassisAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNChassisAluguer.Name = "labelNChassisAluguer";
            this.labelNChassisAluguer.Size = new System.Drawing.Size(80, 17);
            this.labelNChassisAluguer.TabIndex = 6;
            this.labelNChassisAluguer.Text = "Nº Chassis:";
            // 
            // labelAlugadoAluguer
            // 
            this.labelAlugadoAluguer.AutoSize = true;
            this.labelAlugadoAluguer.Location = new System.Drawing.Point(9, 27);
            this.labelAlugadoAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlugadoAluguer.Name = "labelAlugadoAluguer";
            this.labelAlugadoAluguer.Size = new System.Drawing.Size(64, 17);
            this.labelAlugadoAluguer.TabIndex = 4;
            this.labelAlugadoAluguer.Text = "Alugado:";
            // 
            // maskedTextBoxMatriculaAluguer
            // 
            this.maskedTextBoxMatriculaAluguer.Location = new System.Drawing.Point(93, 54);
            this.maskedTextBoxMatriculaAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxMatriculaAluguer.Mask = "AA-AA-AA";
            this.maskedTextBoxMatriculaAluguer.Name = "maskedTextBoxMatriculaAluguer";
            this.maskedTextBoxMatriculaAluguer.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxMatriculaAluguer.TabIndex = 3;
            // 
            // labelMatriculaAluguer
            // 
            this.labelMatriculaAluguer.AutoSize = true;
            this.labelMatriculaAluguer.Location = new System.Drawing.Point(9, 58);
            this.labelMatriculaAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatriculaAluguer.Name = "labelMatriculaAluguer";
            this.labelMatriculaAluguer.Size = new System.Drawing.Size(69, 17);
            this.labelMatriculaAluguer.TabIndex = 2;
            this.labelMatriculaAluguer.Text = "Matrícula:";
            // 
            // buttonAdicionarCarroAluguer
            // 
            this.buttonAdicionarCarroAluguer.Location = new System.Drawing.Point(8, 240);
            this.buttonAdicionarCarroAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarCarroAluguer.Name = "buttonAdicionarCarroAluguer";
            this.buttonAdicionarCarroAluguer.Size = new System.Drawing.Size(244, 50);
            this.buttonAdicionarCarroAluguer.TabIndex = 1;
            this.buttonAdicionarCarroAluguer.Text = "Adicionar Carro";
            this.buttonAdicionarCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarrosAluguer
            // 
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonRemoverCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.listBoxCarrosAluguer);
            this.groupBoxCarrosAluguer.Location = new System.Drawing.Point(453, 140);
            this.groupBoxCarrosAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrosAluguer.Name = "groupBoxCarrosAluguer";
            this.groupBoxCarrosAluguer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCarrosAluguer.Size = new System.Drawing.Size(479, 561);
            this.groupBoxCarrosAluguer.TabIndex = 8;
            this.groupBoxCarrosAluguer.TabStop = false;
            this.groupBoxCarrosAluguer.Text = "Carros para Aluguer";
            // 
            // buttonRemoverCarroAluguer
            // 
            this.buttonRemoverCarroAluguer.Location = new System.Drawing.Point(8, 23);
            this.buttonRemoverCarroAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoverCarroAluguer.Name = "buttonRemoverCarroAluguer";
            this.buttonRemoverCarroAluguer.Size = new System.Drawing.Size(463, 37);
            this.buttonRemoverCarroAluguer.TabIndex = 2;
            this.buttonRemoverCarroAluguer.Text = "Remover Carro da Lista de Aluguer";
            this.buttonRemoverCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosAluguer
            // 
            this.listBoxCarrosAluguer.FormattingEnabled = true;
            this.listBoxCarrosAluguer.ItemHeight = 16;
            this.listBoxCarrosAluguer.Location = new System.Drawing.Point(8, 68);
            this.listBoxCarrosAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCarrosAluguer.Name = "listBoxCarrosAluguer";
            this.listBoxCarrosAluguer.ScrollAlwaysVisible = true;
            this.listBoxCarrosAluguer.Size = new System.Drawing.Size(461, 484);
            this.listBoxCarrosAluguer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCampoAluguer);
            this.groupBox2.Controls.Add(this.labelProcurarPorAluguer);
            this.groupBox2.Controls.Add(this.comboBoxCampoAluguer);
            this.groupBox2.Controls.Add(this.textBoxProcurarPorAluguer);
            this.groupBox2.Controls.Add(this.listBoxClientesAluguer);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(433, 642);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // labelCampoAluguer
            // 
            this.labelCampoAluguer.AutoSize = true;
            this.labelCampoAluguer.Location = new System.Drawing.Point(323, 26);
            this.labelCampoAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCampoAluguer.Name = "labelCampoAluguer";
            this.labelCampoAluguer.Size = new System.Drawing.Size(56, 17);
            this.labelCampoAluguer.TabIndex = 4;
            this.labelCampoAluguer.Text = "Campo:";
            // 
            // labelProcurarPorAluguer
            // 
            this.labelProcurarPorAluguer.AutoSize = true;
            this.labelProcurarPorAluguer.Location = new System.Drawing.Point(5, 26);
            this.labelProcurarPorAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcurarPorAluguer.Name = "labelProcurarPorAluguer";
            this.labelProcurarPorAluguer.Size = new System.Drawing.Size(92, 17);
            this.labelProcurarPorAluguer.TabIndex = 3;
            this.labelProcurarPorAluguer.Text = "Procurar por:";
            // 
            // comboBoxCampoAluguer
            // 
            this.comboBoxCampoAluguer.FormattingEnabled = true;
            this.comboBoxCampoAluguer.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoAluguer.Location = new System.Drawing.Point(325, 48);
            this.comboBoxCampoAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampoAluguer.Name = "comboBoxCampoAluguer";
            this.comboBoxCampoAluguer.Size = new System.Drawing.Size(99, 24);
            this.comboBoxCampoAluguer.TabIndex = 2;
            // 
            // textBoxProcurarPorAluguer
            // 
            this.textBoxProcurarPorAluguer.Location = new System.Drawing.Point(9, 49);
            this.textBoxProcurarPorAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProcurarPorAluguer.Name = "textBoxProcurarPorAluguer";
            this.textBoxProcurarPorAluguer.Size = new System.Drawing.Size(307, 22);
            this.textBoxProcurarPorAluguer.TabIndex = 1;
            // 
            // listBoxClientesAluguer
            // 
            this.listBoxClientesAluguer.FormattingEnabled = true;
            this.listBoxClientesAluguer.ItemHeight = 16;
            this.listBoxClientesAluguer.Location = new System.Drawing.Point(9, 85);
            this.listBoxClientesAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientesAluguer.Name = "listBoxClientesAluguer";
            this.listBoxClientesAluguer.ScrollAlwaysVisible = true;
            this.listBoxClientesAluguer.Size = new System.Drawing.Size(415, 548);
            this.listBoxClientesAluguer.TabIndex = 0;
            // 
            // labelTituloAluguer
            // 
            this.labelTituloAluguer.AutoSize = true;
            this.labelTituloAluguer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloAluguer.ForeColor = System.Drawing.Color.Brown;
            this.labelTituloAluguer.Location = new System.Drawing.Point(13, 10);
            this.labelTituloAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloAluguer.Name = "labelTituloAluguer";
            this.labelTituloAluguer.Size = new System.Drawing.Size(148, 39);
            this.labelTituloAluguer.TabIndex = 6;
            this.labelTituloAluguer.Text = "Aluguer";
            // 
            // groupBoxFichaClienteVenda
            // 
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNifClienteSelecionadoAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelClienteSelecionadoAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNifAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNomeAluguer);
            this.groupBoxFichaClienteVenda.Location = new System.Drawing.Point(453, 10);
            this.groupBoxFichaClienteVenda.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteVenda.Name = "groupBoxFichaClienteVenda";
            this.groupBoxFichaClienteVenda.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFichaClienteVenda.Size = new System.Drawing.Size(747, 123);
            this.groupBoxFichaClienteVenda.TabIndex = 3;
            this.groupBoxFichaClienteVenda.TabStop = false;
            this.groupBoxFichaClienteVenda.Text = "Ficha do Cliente";
            // 
            // labelNifClienteSelecionadoAluguer
            // 
            this.labelNifClienteSelecionadoAluguer.AutoSize = true;
            this.labelNifClienteSelecionadoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoAluguer.Location = new System.Drawing.Point(68, 74);
            this.labelNifClienteSelecionadoAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifClienteSelecionadoAluguer.Name = "labelNifClienteSelecionadoAluguer";
            this.labelNifClienteSelecionadoAluguer.Size = new System.Drawing.Size(103, 29);
            this.labelNifClienteSelecionadoAluguer.TabIndex = 3;
            this.labelNifClienteSelecionadoAluguer.Text = "*********";
            // 
            // labelClienteSelecionadoAluguer
            // 
            this.labelClienteSelecionadoAluguer.AutoSize = true;
            this.labelClienteSelecionadoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionadoAluguer.Location = new System.Drawing.Point(89, 27);
            this.labelClienteSelecionadoAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionadoAluguer.Name = "labelClienteSelecionadoAluguer";
            this.labelClienteSelecionadoAluguer.Size = new System.Drawing.Size(319, 29);
            this.labelClienteSelecionadoAluguer.TabIndex = 2;
            this.labelClienteSelecionadoAluguer.Text = "Nenhum cliente selecionado";
            // 
            // labelNifAluguer
            // 
            this.labelNifAluguer.AutoSize = true;
            this.labelNifAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifAluguer.Location = new System.Drawing.Point(8, 74);
            this.labelNifAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNifAluguer.Name = "labelNifAluguer";
            this.labelNifAluguer.Size = new System.Drawing.Size(49, 25);
            this.labelNifAluguer.TabIndex = 1;
            this.labelNifAluguer.Text = "NIF:";
            // 
            // labelNomeAluguer
            // 
            this.labelNomeAluguer.AutoSize = true;
            this.labelNomeAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAluguer.Location = new System.Drawing.Point(8, 27);
            this.labelNomeAluguer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeAluguer.Name = "labelNomeAluguer";
            this.labelNomeAluguer.Size = new System.Drawing.Size(70, 25);
            this.labelNomeAluguer.TabIndex = 0;
            this.labelNomeAluguer.Text = "Nome:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1441, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Carros_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.Carros_CarroOficinaTableAdapter = null;
            this.tableAdapterManager.Carros_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarrosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ParcelasTableAdapter = null;
            this.tableAdapterManager.ServicosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RealStand.realstandDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "window";
            this.Text = "RealStand";
            this.Load += new System.EventHandler(this.window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPageInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageClientes.ResumeLayout(false);
            this.tabPageClientes.PerformLayout();
            this.groupBoxDadosClientes.ResumeLayout(false);
            this.groupBoxDadosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realStandDataSet)).EndInit();
            this.tabPageOficina.ResumeLayout(false);
            this.tabPageOficina.PerformLayout();
            this.groupBoxParcelasOficina.ResumeLayout(false);
            this.groupBoxCriarParcelaOficina.ResumeLayout(false);
            this.groupBoxCriarParcelaOficina.PerformLayout();
            this.groupBoxServicosOficina.ResumeLayout(false);
            this.groupBoxCriarServicoOficina.ResumeLayout(false);
            this.groupBoxCriarServicoOficina.PerformLayout();
            this.groupBoxCarrosOficina.ResumeLayout(false);
            this.groupBoxCriarCarroOficina.ResumeLayout(false);
            this.groupBoxCriarCarroOficina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKMsOficina)).EndInit();
            this.groupBoxFichaClienteOficina.ResumeLayout(false);
            this.groupBoxFichaClienteOficina.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxClientesOficina.ResumeLayout(false);
            this.groupBoxClientesOficina.PerformLayout();
            this.tabPageVendas.ResumeLayout(false);
            this.tabPageVendas.PerformLayout();
            this.groupBoxDetalhesVendaECarroVendas.ResumeLayout(false);
            this.groupBoxDetalhesCarroVenda.ResumeLayout(false);
            this.groupBoxDetalhesCarroVenda.PerformLayout();
            this.groupBoxDetalhesDaVenda.ResumeLayout(false);
            this.groupBoxDetalhesDaVenda.PerformLayout();
            this.groupBoxVendasCliente.ResumeLayout(false);
            this.groupBoxListaClientesVendas.ResumeLayout(false);
            this.groupBoxListaClientesVendas.PerformLayout();
            this.groupBoxFichaClienteVendas.ResumeLayout(false);
            this.groupBoxFichaClienteVendas.PerformLayout();
            this.groupBoxTotalVendas.ResumeLayout(false);
            this.groupBoxTotalVendas.PerformLayout();
            this.tabPageAluguer.ResumeLayout(false);
            this.tabPageAluguer.PerformLayout();
            this.groupBoxAluguerCarro.ResumeLayout(false);
            this.groupBoxAluguerCarro.PerformLayout();
            this.groupBoxAdicionarCarroAluguer.ResumeLayout(false);
            this.groupBoxAdicionarCarroAluguer.PerformLayout();
            this.groupBoxCarrosAluguer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxFichaClienteVenda.ResumeLayout(false);
            this.groupBoxFichaClienteVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageOficina;
        private System.Windows.Forms.Label labelTituloOficina;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.TabPage tabPageAluguer;
        private realstandDataSet realStandDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private realstandDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private realstandDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxDadosClientes;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox nIFMaskedTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.MaskedTextBox contactoMaskedTextBox;
        private System.Windows.Forms.ListBox clientesListBox;
        private System.Windows.Forms.Label labelCampoDeProcura;
        private System.Windows.Forms.Label labelProcurarPor;
        private System.Windows.Forms.ComboBox comboBoxCampoProcura;
        private System.Windows.Forms.TextBox textBoxClienteProcurarPor;
        private System.Windows.Forms.Button buttonGravarCliente;
        private System.Windows.Forms.GroupBox groupBoxParcelasOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarParcelaOficina;
        private System.Windows.Forms.Button buttonAdicionarParcelaOficina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorParcelaOficina;
        private System.Windows.Forms.TextBox textBoxDescricaoParcelaOficina;
        private System.Windows.Forms.ListBox listBoxParcelasOficina;
        private System.Windows.Forms.GroupBox groupBoxServicosOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarServicoOficina;
        private System.Windows.Forms.ComboBox comboBoxTipoServicosOficina;
        private System.Windows.Forms.ListBox listBoxServicosOficina;
        private System.Windows.Forms.GroupBox groupBoxCarrosOficina;
        private System.Windows.Forms.Button buttonCriarCarroOficina;
        private System.Windows.Forms.ListBox listBoxCarrosOficina;
        private System.Windows.Forms.GroupBox groupBoxFichaClienteOficina;
        private System.Windows.Forms.Label labelTotalClienteOficina;
        private System.Windows.Forms.Label labelTotalGastoOficina;
        private System.Windows.Forms.Label labelNifClienteSelecionadoOficina;
        private System.Windows.Forms.Label labelClienteSelecionadoOficina;
        private System.Windows.Forms.Label labelNifOficina;
        private System.Windows.Forms.Label labelNomeOficina;
        private System.Windows.Forms.GroupBox groupBoxClientesOficina;
        private System.Windows.Forms.ListBox listBoxClientesOficina;
        private System.Windows.Forms.Label labelProcurarPorOficina;
        private System.Windows.Forms.Label labelTextoOficina;
        private System.Windows.Forms.ComboBox comboBoxCampoOficina;
        private System.Windows.Forms.TextBox textBoxProcurarPorOficina;
        private System.Windows.Forms.Button buttonRemoverParcelaOficina;
        private System.Windows.Forms.Button buttonRemoverCarroOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarCarroOficina;
        private System.Windows.Forms.Label labelQuilometragemOficina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatriculaOficina;
        private System.Windows.Forms.Label labelMatriculaOficina;
        private System.Windows.Forms.Label labelModeloOficina;
        private System.Windows.Forms.Label labelMarcaOficina;
        private System.Windows.Forms.Label labelNChassisOficina;
        private System.Windows.Forms.ComboBox comboBoxCombustivelOficina;
        private System.Windows.Forms.Label labelCombustivelOficina;
        private System.Windows.Forms.TextBox textBoxModeloOficina;
        private System.Windows.Forms.TextBox textBoxMarcaOficina;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSaidaOficina;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntregaOficina;
        private System.Windows.Forms.Label labelDataSaidaOficina;
        private System.Windows.Forms.Label labelTipoServicoOficina;
        private System.Windows.Forms.Label labelDataEntregaOficina;
        private System.Windows.Forms.Label labelValorOficina;
        private System.Windows.Forms.Label labelDescricaoOficina;
        private System.Windows.Forms.GroupBox groupBoxFichaClienteVenda;
        private System.Windows.Forms.Label labelNifClienteSelecionadoAluguer;
        private System.Windows.Forms.Label labelClienteSelecionadoAluguer;
        private System.Windows.Forms.Label labelNifAluguer;
        private System.Windows.Forms.Label labelNomeAluguer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCampoAluguer;
        private System.Windows.Forms.Label labelProcurarPorAluguer;
        private System.Windows.Forms.ComboBox comboBoxCampoAluguer;
        private System.Windows.Forms.TextBox textBoxProcurarPorAluguer;
        private System.Windows.Forms.ListBox listBoxClientesAluguer;
        private System.Windows.Forms.Label labelTituloAluguer;
        private System.Windows.Forms.GroupBox groupBoxCarrosAluguer;
        private System.Windows.Forms.GroupBox groupBoxAdicionarCarroAluguer;
        private System.Windows.Forms.TextBox textBoxModeloAluguer;
        private System.Windows.Forms.TextBox textBoxMarcaAluguer;
        private System.Windows.Forms.TextBox textBoxChassiAluguer;
        private System.Windows.Forms.ComboBox comboBoxCombustivelAluguer;
        private System.Windows.Forms.Label labelCombustivelAluguer;
        private System.Windows.Forms.Label labelModeloAluguer;
        private System.Windows.Forms.Label labelMarcaAluguer;
        private System.Windows.Forms.Label labelNChassisAluguer;
        private System.Windows.Forms.Label labelAlugadoAluguer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatriculaAluguer;
        private System.Windows.Forms.Label labelMatriculaAluguer;
        private System.Windows.Forms.Button buttonAdicionarCarroAluguer;
        private System.Windows.Forms.Button buttonRemoverCarroAluguer;
        private System.Windows.Forms.ListBox listBoxCarrosAluguer;
        private System.Windows.Forms.CheckBox checkBoxEstadoAluguer;
        private System.Windows.Forms.GroupBox groupBoxAluguerCarro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFimAluguer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicioAluguer;
        private System.Windows.Forms.Label labelDataFimAluguer;
        private System.Windows.Forms.Label labelDataInicioAluguer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelValorAluguer;
        private System.Windows.Forms.TextBox textBoxQuilometragemAluguer;
        private System.Windows.Forms.Label labelQuilometragemAluguer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorAluguer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonApagarCliente;
        private System.Windows.Forms.Button buttonProcurarCliente;
        private System.Windows.Forms.Button buttonCriarCliente;
        private System.Windows.Forms.Button buttonEditarCliente;
        private System.Windows.Forms.NumericUpDown numericUpDownKMsOficina;
        private System.Windows.Forms.Button buttonEditarCarroOficina;
        private System.Windows.Forms.Button buttonGuardarCarroOficina;
        private System.Windows.Forms.Button buttonRemoverServicoOficina;
        private System.Windows.Forms.Button buttonCriarServicoOficina;
        private System.Windows.Forms.Button buttonEditarServicoOficina;
        private System.Windows.Forms.Button buttonGuardarServicoOficina;
        private System.Windows.Forms.GroupBox groupBoxDetalhesVendaECarroVendas;
        private System.Windows.Forms.GroupBox groupBoxDetalhesCarroVenda;
        private System.Windows.Forms.Label labelNChassis;
        private System.Windows.Forms.Label labelCombustivelVendas;
        private System.Windows.Forms.TextBox textBoxExtrasVendas;
        private System.Windows.Forms.ComboBox comboBoxCombustivelVendas;
        private System.Windows.Forms.Label labelModeloVendas;
        private System.Windows.Forms.Label labelExtrasVendas;
        private System.Windows.Forms.TextBox textBoxModeloVendas;
        private System.Windows.Forms.Label labelMarcaVendas;
        private System.Windows.Forms.TextBox textBoxMarcaVendas;
        private System.Windows.Forms.GroupBox groupBoxDetalhesDaVenda;
        private System.Windows.Forms.Label labelDataVendaVendas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorVenda;
        private System.Windows.Forms.Label labelValorVendas;
        private System.Windows.Forms.Label labelEstadoVendas;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVenda;
        private System.Windows.Forms.TextBox textBoxEstadoVendas;
        private System.Windows.Forms.Button buttonGuardarVendas;
        private System.Windows.Forms.GroupBox groupBoxVendasCliente;
        private System.Windows.Forms.Button buttonEditarVenda;
        private System.Windows.Forms.Button buttonAnularVenda;
        private System.Windows.Forms.Button buttonCriarVenda;
        private System.Windows.Forms.ListBox listBoxVendasDoCliente;
        private System.Windows.Forms.GroupBox groupBoxListaClientesVendas;
        private System.Windows.Forms.Button buttonFiltarVendas;
        private System.Windows.Forms.Label labelProcurarPorVendas;
        private System.Windows.Forms.Label labelCampoVendas;
        private System.Windows.Forms.ComboBox comboBoxCampoVendas;
        private System.Windows.Forms.TextBox textBoxProcurarPorVendas;
        private System.Windows.Forms.ListBox listBoxClientesVendas;
        private System.Windows.Forms.Label labelTituloVendas;
        private System.Windows.Forms.GroupBox groupBoxFichaClienteVendas;
        private System.Windows.Forms.Label labelNifClienteSelecionadoVendas;
        private System.Windows.Forms.Label labelNomeClienteSelecionadoVendas;
        private System.Windows.Forms.Label labelNifVendas;
        private System.Windows.Forms.Label labelNomeVendas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxChassiOficina;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelTotalVendas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxTotalVendas;
    }
}

