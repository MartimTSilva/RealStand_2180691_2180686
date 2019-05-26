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
            this.labelCampoDeProcura = new System.Windows.Forms.Label();
            this.labelProcurarPor = new System.Windows.Forms.Label();
            this.comboBoxCampoProcura = new System.Windows.Forms.ComboBox();
            this.textBoxProcurarPor = new System.Windows.Forms.TextBox();
            this.groupBoxDadosClientes = new System.Windows.Forms.GroupBox();
            this.buttonGravarCliente = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realStandDataSet = new RealStand.realstandDataSet();
            this.nIFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.contactoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
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
            this.groupBoxCriarServicoOficina = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDataSaidaOficina = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataEntregaOficina = new System.Windows.Forms.DateTimePicker();
            this.labelDataSaidaOficina = new System.Windows.Forms.Label();
            this.labelTipoServicoOficina = new System.Windows.Forms.Label();
            this.labelDataEntregaOficina = new System.Windows.Forms.Label();
            this.buttonAdicionarServicoOficina = new System.Windows.Forms.Button();
            this.comboBoxTipoServicosOficina = new System.Windows.Forms.ComboBox();
            this.listBoxServicosOficina = new System.Windows.Forms.ListBox();
            this.groupBoxCarrosOficina = new System.Windows.Forms.GroupBox();
            this.groupBoxCriarCarroOficina = new System.Windows.Forms.GroupBox();
            this.textBoxModeloOficina = new System.Windows.Forms.TextBox();
            this.textBoxMarcaOficina = new System.Windows.Forms.TextBox();
            this.textBoxChassiOficina = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelOficina = new System.Windows.Forms.ComboBox();
            this.labelCombustivelOficina = new System.Windows.Forms.Label();
            this.labelModeloOficina = new System.Windows.Forms.Label();
            this.labelMarcaOficina = new System.Windows.Forms.Label();
            this.labelNChassisOficina = new System.Windows.Forms.Label();
            this.textBoxKMsOficina = new System.Windows.Forms.TextBox();
            this.labelQuilometragemOficina = new System.Windows.Forms.Label();
            this.maskedTextBoxMatriculaOficina = new System.Windows.Forms.MaskedTextBox();
            this.labelMatriculaOficina = new System.Windows.Forms.Label();
            this.buttonAdicionarCarroOficina = new System.Windows.Forms.Button();
            this.buttonRemoverCarroOficina = new System.Windows.Forms.Button();
            this.listBoxCarrosOficina = new System.Windows.Forms.ListBox();
            this.groupBoxFichaClienteOficina = new System.Windows.Forms.GroupBox();
            this.labelTotalClienteOficina = new System.Windows.Forms.Label();
            this.labelTotalGastoOficina = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEstadoVendas = new System.Windows.Forms.TextBox();
            this.labelEstadoVendas = new System.Windows.Forms.Label();
            this.labelValorVendas = new System.Windows.Forms.Label();
            this.dateTimePickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.labelDataVendaVendas = new System.Windows.Forms.Label();
            this.buttonVenderCarro = new System.Windows.Forms.Button();
            this.groupBoxAdicionarNovoCarroVendas = new System.Windows.Forms.GroupBox();
            this.textBoxExtrasVendas = new System.Windows.Forms.TextBox();
            this.labelExtrasVendas = new System.Windows.Forms.Label();
            this.textBoxModeloVendas = new System.Windows.Forms.TextBox();
            this.textBoxMarcaVendas = new System.Windows.Forms.TextBox();
            this.textBoxChassiVendas = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelVendas = new System.Windows.Forms.ComboBox();
            this.labelCombustivelVendas = new System.Windows.Forms.Label();
            this.labelModeloVendas = new System.Windows.Forms.Label();
            this.labelMarcaVendas = new System.Windows.Forms.Label();
            this.labelNChassis = new System.Windows.Forms.Label();
            this.buttonAdicionarCarroVendas = new System.Windows.Forms.Button();
            this.groupBoxCarrosVenda = new System.Windows.Forms.GroupBox();
            this.buttonRemoverCarrosVendas = new System.Windows.Forms.Button();
            this.listBoxCarrosVendas = new System.Windows.Forms.ListBox();
            this.groupBoxListaClientesVendas = new System.Windows.Forms.GroupBox();
            this.labelCampoVendas = new System.Windows.Forms.Label();
            this.labelProcurarPorVendas = new System.Windows.Forms.Label();
            this.comboBoxCampoVendas = new System.Windows.Forms.ComboBox();
            this.textBoxProcurarPorVendas = new System.Windows.Forms.TextBox();
            this.listBoxClientesVendas = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxFichaClienteVendas = new System.Windows.Forms.GroupBox();
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
            this.clientesTableAdapter = new RealStand.realstandDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RealStand.realstandDataSetTableAdapters.TableAdapterManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.tabPageOficina.SuspendLayout();
            this.groupBoxParcelasOficina.SuspendLayout();
            this.groupBoxCriarParcelaOficina.SuspendLayout();
            this.groupBoxServicosOficina.SuspendLayout();
            this.groupBoxCriarServicoOficina.SuspendLayout();
            this.groupBoxCarrosOficina.SuspendLayout();
            this.groupBoxCriarCarroOficina.SuspendLayout();
            this.groupBoxFichaClienteOficina.SuspendLayout();
            this.groupBoxClientesOficina.SuspendLayout();
            this.tabPageVendas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAdicionarNovoCarroVendas.SuspendLayout();
            this.groupBoxCarrosVenda.SuspendLayout();
            this.groupBoxListaClientesVendas.SuspendLayout();
            this.groupBoxFichaClienteVendas.SuspendLayout();
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
            nomeLabel.Location = new System.Drawing.Point(21, 16);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(32, 42);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 2;
            nIFLabel.Text = "NIF:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(6, 68);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 4;
            moradaLabel.Text = "Morada:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(6, 94);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(20);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 581);
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
            this.tabPageInicio.Size = new System.Drawing.Size(912, 573);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Início";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 484);
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
            this.label3.Location = new System.Drawing.Point(283, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projeto de Desenvolvimento de Aplicações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Micael Rodrigues, nº 2180691";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maritm Silva, nº 2180686";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.BackColor = System.Drawing.Color.Silver;
            this.tabPageClientes.Controls.Add(this.labelCampoDeProcura);
            this.tabPageClientes.Controls.Add(this.labelProcurarPor);
            this.tabPageClientes.Controls.Add(this.comboBoxCampoProcura);
            this.tabPageClientes.Controls.Add(this.textBoxProcurarPor);
            this.tabPageClientes.Controls.Add(this.groupBoxDadosClientes);
            this.tabPageClientes.Controls.Add(this.clientesBindingNavigator);
            this.tabPageClientes.Controls.Add(this.clientesListBox);
            this.tabPageClientes.Location = new System.Drawing.Point(166, 4);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientes.Size = new System.Drawing.Size(912, 573);
            this.tabPageClientes.TabIndex = 1;
            this.tabPageClientes.Text = "Clientes";
            // 
            // labelCampoDeProcura
            // 
            this.labelCampoDeProcura.AutoSize = true;
            this.labelCampoDeProcura.Location = new System.Drawing.Point(229, 37);
            this.labelCampoDeProcura.Name = "labelCampoDeProcura";
            this.labelCampoDeProcura.Size = new System.Drawing.Size(43, 13);
            this.labelCampoDeProcura.TabIndex = 7;
            this.labelCampoDeProcura.Text = "Campo:";
            // 
            // labelProcurarPor
            // 
            this.labelProcurarPor.AutoSize = true;
            this.labelProcurarPor.Location = new System.Drawing.Point(3, 37);
            this.labelProcurarPor.Name = "labelProcurarPor";
            this.labelProcurarPor.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPor.TabIndex = 6;
            this.labelProcurarPor.Text = "Procurar por:";
            // 
            // comboBoxCampoProcura
            // 
            this.comboBoxCampoProcura.FormattingEnabled = true;
            this.comboBoxCampoProcura.Location = new System.Drawing.Point(232, 53);
            this.comboBoxCampoProcura.Name = "comboBoxCampoProcura";
            this.comboBoxCampoProcura.Size = new System.Drawing.Size(149, 21);
            this.comboBoxCampoProcura.TabIndex = 5;
            // 
            // textBoxProcurarPor
            // 
            this.textBoxProcurarPor.Location = new System.Drawing.Point(3, 53);
            this.textBoxProcurarPor.Name = "textBoxProcurarPor";
            this.textBoxProcurarPor.Size = new System.Drawing.Size(223, 20);
            this.textBoxProcurarPor.TabIndex = 4;
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
            this.groupBoxDadosClientes.Location = new System.Drawing.Point(387, 37);
            this.groupBoxDadosClientes.Name = "groupBoxDadosClientes";
            this.groupBoxDadosClientes.Size = new System.Drawing.Size(516, 535);
            this.groupBoxDadosClientes.TabIndex = 3;
            this.groupBoxDadosClientes.TabStop = false;
            this.groupBoxDadosClientes.Text = "Dados";
            // 
            // buttonGravarCliente
            // 
            this.buttonGravarCliente.Location = new System.Drawing.Point(435, 506);
            this.buttonGravarCliente.Name = "buttonGravarCliente";
            this.buttonGravarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarCliente.TabIndex = 8;
            this.buttonGravarCliente.Text = "Gravar";
            this.buttonGravarCliente.UseVisualStyleBackColor = true;
            this.buttonGravarCliente.Visible = false;
            this.buttonGravarCliente.Click += new System.EventHandler(this.buttonGravarCliente_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(65, 13);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(445, 20);
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
            this.nIFMaskedTextBox.Location = new System.Drawing.Point(65, 39);
            this.nIFMaskedTextBox.Mask = "000000000";
            this.nIFMaskedTextBox.Name = "nIFMaskedTextBox";
            this.nIFMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.nIFMaskedTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Morada", true));
            this.moradaTextBox.Enabled = false;
            this.moradaTextBox.Location = new System.Drawing.Point(65, 65);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(445, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // contactoMaskedTextBox
            // 
            this.contactoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Contacto", true));
            this.contactoMaskedTextBox.Enabled = false;
            this.contactoMaskedTextBox.Location = new System.Drawing.Point(65, 91);
            this.contactoMaskedTextBox.Mask = "(99) 0000000";
            this.contactoMaskedTextBox.Name = "contactoMaskedTextBox";
            this.contactoMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.contactoMaskedTextBox.TabIndex = 7;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = null;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = null;
            this.clientesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(906, 25);
            this.clientesBindingNavigator.TabIndex = 2;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            this.clientesBindingNavigator.Click += new System.EventHandler(this.clientesBindingNavigator_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // clientesListBox
            // 
            this.clientesListBox.FormattingEnabled = true;
            this.clientesListBox.Location = new System.Drawing.Point(3, 76);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(378, 498);
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
            this.tabPageOficina.Name = "tabPageOficina";
            this.tabPageOficina.Size = new System.Drawing.Size(912, 573);
            this.tabPageOficina.TabIndex = 2;
            this.tabPageOficina.Text = "Oficina";
            // 
            // groupBoxParcelasOficina
            // 
            this.groupBoxParcelasOficina.Controls.Add(this.buttonRemoverParcelaOficina);
            this.groupBoxParcelasOficina.Controls.Add(this.groupBoxCriarParcelaOficina);
            this.groupBoxParcelasOficina.Controls.Add(this.listBoxParcelasOficina);
            this.groupBoxParcelasOficina.Location = new System.Drawing.Point(650, 114);
            this.groupBoxParcelasOficina.Name = "groupBoxParcelasOficina";
            this.groupBoxParcelasOficina.Size = new System.Drawing.Size(250, 456);
            this.groupBoxParcelasOficina.TabIndex = 4;
            this.groupBoxParcelasOficina.TabStop = false;
            this.groupBoxParcelasOficina.Text = "Parcelas";
            // 
            // buttonRemoverParcelaOficina
            // 
            this.buttonRemoverParcelaOficina.Location = new System.Drawing.Point(7, 17);
            this.buttonRemoverParcelaOficina.Name = "buttonRemoverParcelaOficina";
            this.buttonRemoverParcelaOficina.Size = new System.Drawing.Size(237, 23);
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
            this.groupBoxCriarParcelaOficina.Location = new System.Drawing.Point(0, 352);
            this.groupBoxCriarParcelaOficina.Name = "groupBoxCriarParcelaOficina";
            this.groupBoxCriarParcelaOficina.Size = new System.Drawing.Size(250, 104);
            this.groupBoxCriarParcelaOficina.TabIndex = 1;
            this.groupBoxCriarParcelaOficina.TabStop = false;
            this.groupBoxCriarParcelaOficina.Text = "Adicionar Nova Parcela";
            // 
            // labelValorOficina
            // 
            this.labelValorOficina.AutoSize = true;
            this.labelValorOficina.Location = new System.Drawing.Point(6, 53);
            this.labelValorOficina.Name = "labelValorOficina";
            this.labelValorOficina.Size = new System.Drawing.Size(34, 13);
            this.labelValorOficina.TabIndex = 15;
            this.labelValorOficina.Text = "Valor:";
            // 
            // labelDescricaoOficina
            // 
            this.labelDescricaoOficina.AutoSize = true;
            this.labelDescricaoOficina.Location = new System.Drawing.Point(6, 26);
            this.labelDescricaoOficina.Name = "labelDescricaoOficina";
            this.labelDescricaoOficina.Size = new System.Drawing.Size(58, 13);
            this.labelDescricaoOficina.TabIndex = 14;
            this.labelDescricaoOficina.Text = "Descrição:";
            // 
            // buttonAdicionarParcelaOficina
            // 
            this.buttonAdicionarParcelaOficina.Location = new System.Drawing.Point(7, 74);
            this.buttonAdicionarParcelaOficina.Name = "buttonAdicionarParcelaOficina";
            this.buttonAdicionarParcelaOficina.Size = new System.Drawing.Size(237, 23);
            this.buttonAdicionarParcelaOficina.TabIndex = 22;
            this.buttonAdicionarParcelaOficina.Text = "Adicionar Parcela";
            this.buttonAdicionarParcelaOficina.UseVisualStyleBackColor = true;
            this.buttonAdicionarParcelaOficina.Click += new System.EventHandler(this.buttonAdicionarParcelaOficina_Click);
            // 
            // maskedTextBoxValorParcelaOficina
            // 
            this.maskedTextBoxValorParcelaOficina.Location = new System.Drawing.Point(46, 50);
            this.maskedTextBoxValorParcelaOficina.Mask = "€00000.00";
            this.maskedTextBoxValorParcelaOficina.Name = "maskedTextBoxValorParcelaOficina";
            this.maskedTextBoxValorParcelaOficina.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorParcelaOficina.TabIndex = 21;
            // 
            // textBoxDescricaoParcelaOficina
            // 
            this.textBoxDescricaoParcelaOficina.Location = new System.Drawing.Point(70, 23);
            this.textBoxDescricaoParcelaOficina.Multiline = true;
            this.textBoxDescricaoParcelaOficina.Name = "textBoxDescricaoParcelaOficina";
            this.textBoxDescricaoParcelaOficina.Size = new System.Drawing.Size(175, 20);
            this.textBoxDescricaoParcelaOficina.TabIndex = 20;
            // 
            // listBoxParcelasOficina
            // 
            this.listBoxParcelasOficina.FormattingEnabled = true;
            this.listBoxParcelasOficina.Location = new System.Drawing.Point(7, 46);
            this.listBoxParcelasOficina.Name = "listBoxParcelasOficina";
            this.listBoxParcelasOficina.Size = new System.Drawing.Size(237, 303);
            this.listBoxParcelasOficina.TabIndex = 19;
            // 
            // groupBoxServicosOficina
            // 
            this.groupBoxServicosOficina.Controls.Add(this.buttonRemoverServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.groupBoxCriarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.listBoxServicosOficina);
            this.groupBoxServicosOficina.Location = new System.Drawing.Point(420, 114);
            this.groupBoxServicosOficina.Name = "groupBoxServicosOficina";
            this.groupBoxServicosOficina.Size = new System.Drawing.Size(224, 456);
            this.groupBoxServicosOficina.TabIndex = 3;
            this.groupBoxServicosOficina.TabStop = false;
            this.groupBoxServicosOficina.Text = "Serviços";
            // 
            // buttonRemoverServicoOficina
            // 
            this.buttonRemoverServicoOficina.Location = new System.Drawing.Point(6, 17);
            this.buttonRemoverServicoOficina.Name = "buttonRemoverServicoOficina";
            this.buttonRemoverServicoOficina.Size = new System.Drawing.Size(212, 23);
            this.buttonRemoverServicoOficina.TabIndex = 18;
            this.buttonRemoverServicoOficina.Text = "Remover Serviço";
            this.buttonRemoverServicoOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverServicoOficina.Click += new System.EventHandler(this.buttonRemoverServicoOficina_Click);
            // 
            // groupBoxCriarServicoOficina
            // 
            this.groupBoxCriarServicoOficina.Controls.Add(this.dateTimePickerDataSaidaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.dateTimePickerDataEntregaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelDataSaidaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelTipoServicoOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.labelDataEntregaOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.buttonAdicionarServicoOficina);
            this.groupBoxCriarServicoOficina.Controls.Add(this.comboBoxTipoServicosOficina);
            this.groupBoxCriarServicoOficina.Location = new System.Drawing.Point(0, 326);
            this.groupBoxCriarServicoOficina.Name = "groupBoxCriarServicoOficina";
            this.groupBoxCriarServicoOficina.Size = new System.Drawing.Size(224, 130);
            this.groupBoxCriarServicoOficina.TabIndex = 1;
            this.groupBoxCriarServicoOficina.TabStop = false;
            this.groupBoxCriarServicoOficina.Text = "Adicionar Novo Serviço";
            // 
            // dateTimePickerDataSaidaOficina
            // 
            this.dateTimePickerDataSaidaOficina.Location = new System.Drawing.Point(97, 76);
            this.dateTimePickerDataSaidaOficina.Name = "dateTimePickerDataSaidaOficina";
            this.dateTimePickerDataSaidaOficina.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataSaidaOficina.TabIndex = 16;
            // 
            // dateTimePickerDataEntregaOficina
            // 
            this.dateTimePickerDataEntregaOficina.Location = new System.Drawing.Point(97, 22);
            this.dateTimePickerDataEntregaOficina.Name = "dateTimePickerDataEntregaOficina";
            this.dateTimePickerDataEntregaOficina.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataEntregaOficina.TabIndex = 14;
            // 
            // labelDataSaidaOficina
            // 
            this.labelDataSaidaOficina.AutoSize = true;
            this.labelDataSaidaOficina.Location = new System.Drawing.Point(6, 78);
            this.labelDataSaidaOficina.Name = "labelDataSaidaOficina";
            this.labelDataSaidaOficina.Size = new System.Drawing.Size(80, 13);
            this.labelDataSaidaOficina.TabIndex = 16;
            this.labelDataSaidaOficina.Text = "Data de Saída:";
            // 
            // labelTipoServicoOficina
            // 
            this.labelTipoServicoOficina.AutoSize = true;
            this.labelTipoServicoOficina.Location = new System.Drawing.Point(6, 52);
            this.labelTipoServicoOficina.Name = "labelTipoServicoOficina";
            this.labelTipoServicoOficina.Size = new System.Drawing.Size(85, 13);
            this.labelTipoServicoOficina.TabIndex = 15;
            this.labelTipoServicoOficina.Text = "Tipo de Serviço:";
            // 
            // labelDataEntregaOficina
            // 
            this.labelDataEntregaOficina.AutoSize = true;
            this.labelDataEntregaOficina.Location = new System.Drawing.Point(6, 26);
            this.labelDataEntregaOficina.Name = "labelDataEntregaOficina";
            this.labelDataEntregaOficina.Size = new System.Drawing.Size(88, 13);
            this.labelDataEntregaOficina.TabIndex = 14;
            this.labelDataEntregaOficina.Text = "Data de Entrega:";
            // 
            // buttonAdicionarServicoOficina
            // 
            this.buttonAdicionarServicoOficina.Location = new System.Drawing.Point(7, 100);
            this.buttonAdicionarServicoOficina.Name = "buttonAdicionarServicoOficina";
            this.buttonAdicionarServicoOficina.Size = new System.Drawing.Size(211, 23);
            this.buttonAdicionarServicoOficina.TabIndex = 17;
            this.buttonAdicionarServicoOficina.Text = "Adicionar Serviço";
            this.buttonAdicionarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonAdicionarServicoOficina.Click += new System.EventHandler(this.buttonAdicionarServicoOficina_Click);
            // 
            // comboBoxTipoServicosOficina
            // 
            this.comboBoxTipoServicosOficina.FormattingEnabled = true;
            this.comboBoxTipoServicosOficina.Items.AddRange(new object[] {
            "Manutenção",
            "Tipo 2",
            "Tipo 3"});
            this.comboBoxTipoServicosOficina.Location = new System.Drawing.Point(97, 48);
            this.comboBoxTipoServicosOficina.Name = "comboBoxTipoServicosOficina";
            this.comboBoxTipoServicosOficina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoServicosOficina.TabIndex = 15;
            // 
            // listBoxServicosOficina
            // 
            this.listBoxServicosOficina.FormattingEnabled = true;
            this.listBoxServicosOficina.Location = new System.Drawing.Point(7, 46);
            this.listBoxServicosOficina.Name = "listBoxServicosOficina";
            this.listBoxServicosOficina.Size = new System.Drawing.Size(211, 277);
            this.listBoxServicosOficina.TabIndex = 13;
            this.listBoxServicosOficina.Click += new System.EventHandler(this.listBoxServicosOficina_Click);
            // 
            // groupBoxCarrosOficina
            // 
            this.groupBoxCarrosOficina.Controls.Add(this.groupBoxCriarCarroOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.buttonRemoverCarroOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.listBoxCarrosOficina);
            this.groupBoxCarrosOficina.Location = new System.Drawing.Point(219, 114);
            this.groupBoxCarrosOficina.Name = "groupBoxCarrosOficina";
            this.groupBoxCarrosOficina.Size = new System.Drawing.Size(195, 456);
            this.groupBoxCarrosOficina.TabIndex = 2;
            this.groupBoxCarrosOficina.TabStop = false;
            this.groupBoxCarrosOficina.Text = "Carros";
            // 
            // groupBoxCriarCarroOficina
            // 
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxModeloOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxMarcaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxChassiOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.comboBoxCombustivelOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelCombustivelOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelModeloOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelMarcaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelNChassisOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.textBoxKMsOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelQuilometragemOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.maskedTextBoxMatriculaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.labelMatriculaOficina);
            this.groupBoxCriarCarroOficina.Controls.Add(this.buttonAdicionarCarroOficina);
            this.groupBoxCriarCarroOficina.Location = new System.Drawing.Point(0, 253);
            this.groupBoxCriarCarroOficina.Name = "groupBoxCriarCarroOficina";
            this.groupBoxCriarCarroOficina.Size = new System.Drawing.Size(195, 203);
            this.groupBoxCriarCarroOficina.TabIndex = 3;
            this.groupBoxCriarCarroOficina.TabStop = false;
            this.groupBoxCriarCarroOficina.Text = "Adicionar Novo Carro";
            // 
            // textBoxModeloOficina
            // 
            this.textBoxModeloOficina.Location = new System.Drawing.Point(57, 122);
            this.textBoxModeloOficina.Name = "textBoxModeloOficina";
            this.textBoxModeloOficina.Size = new System.Drawing.Size(132, 20);
            this.textBoxModeloOficina.TabIndex = 9;
            // 
            // textBoxMarcaOficina
            // 
            this.textBoxMarcaOficina.Location = new System.Drawing.Point(52, 96);
            this.textBoxMarcaOficina.Name = "textBoxMarcaOficina";
            this.textBoxMarcaOficina.Size = new System.Drawing.Size(137, 20);
            this.textBoxMarcaOficina.TabIndex = 8;
            // 
            // textBoxChassiOficina
            // 
            this.textBoxChassiOficina.Location = new System.Drawing.Point(72, 70);
            this.textBoxChassiOficina.Name = "textBoxChassiOficina";
            this.textBoxChassiOficina.Size = new System.Drawing.Size(117, 20);
            this.textBoxChassiOficina.TabIndex = 7;
            // 
            // comboBoxCombustivelOficina
            // 
            this.comboBoxCombustivelOficina.FormattingEnabled = true;
            this.comboBoxCombustivelOficina.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Diesel",
            "Gás",
            "Híbrido"});
            this.comboBoxCombustivelOficina.Location = new System.Drawing.Point(82, 148);
            this.comboBoxCombustivelOficina.Name = "comboBoxCombustivelOficina";
            this.comboBoxCombustivelOficina.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCombustivelOficina.TabIndex = 10;
            // 
            // labelCombustivelOficina
            // 
            this.labelCombustivelOficina.AutoSize = true;
            this.labelCombustivelOficina.Location = new System.Drawing.Point(7, 151);
            this.labelCombustivelOficina.Name = "labelCombustivelOficina";
            this.labelCombustivelOficina.Size = new System.Drawing.Size(69, 13);
            this.labelCombustivelOficina.TabIndex = 9;
            this.labelCombustivelOficina.Text = "Combustível:";
            // 
            // labelModeloOficina
            // 
            this.labelModeloOficina.AutoSize = true;
            this.labelModeloOficina.Location = new System.Drawing.Point(6, 125);
            this.labelModeloOficina.Name = "labelModeloOficina";
            this.labelModeloOficina.Size = new System.Drawing.Size(45, 13);
            this.labelModeloOficina.TabIndex = 8;
            this.labelModeloOficina.Text = "Modelo:";
            // 
            // labelMarcaOficina
            // 
            this.labelMarcaOficina.AutoSize = true;
            this.labelMarcaOficina.Location = new System.Drawing.Point(6, 99);
            this.labelMarcaOficina.Name = "labelMarcaOficina";
            this.labelMarcaOficina.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaOficina.TabIndex = 7;
            this.labelMarcaOficina.Text = "Marca:";
            // 
            // labelNChassisOficina
            // 
            this.labelNChassisOficina.AutoSize = true;
            this.labelNChassisOficina.Location = new System.Drawing.Point(6, 73);
            this.labelNChassisOficina.Name = "labelNChassisOficina";
            this.labelNChassisOficina.Size = new System.Drawing.Size(61, 13);
            this.labelNChassisOficina.TabIndex = 6;
            this.labelNChassisOficina.Text = "Nº Chassis:";
            // 
            // textBoxKMsOficina
            // 
            this.textBoxKMsOficina.Location = new System.Drawing.Point(95, 44);
            this.textBoxKMsOficina.Name = "textBoxKMsOficina";
            this.textBoxKMsOficina.Size = new System.Drawing.Size(94, 20);
            this.textBoxKMsOficina.TabIndex = 6;
            // 
            // labelQuilometragemOficina
            // 
            this.labelQuilometragemOficina.AutoSize = true;
            this.labelQuilometragemOficina.Location = new System.Drawing.Point(6, 47);
            this.labelQuilometragemOficina.Name = "labelQuilometragemOficina";
            this.labelQuilometragemOficina.Size = new System.Drawing.Size(83, 13);
            this.labelQuilometragemOficina.TabIndex = 4;
            this.labelQuilometragemOficina.Text = "Quilometragem: ";
            // 
            // maskedTextBoxMatriculaOficina
            // 
            this.maskedTextBoxMatriculaOficina.Location = new System.Drawing.Point(70, 18);
            this.maskedTextBoxMatriculaOficina.Mask = "AA-AA-AA";
            this.maskedTextBoxMatriculaOficina.Name = "maskedTextBoxMatriculaOficina";
            this.maskedTextBoxMatriculaOficina.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxMatriculaOficina.TabIndex = 5;
            // 
            // labelMatriculaOficina
            // 
            this.labelMatriculaOficina.AutoSize = true;
            this.labelMatriculaOficina.Location = new System.Drawing.Point(7, 21);
            this.labelMatriculaOficina.Name = "labelMatriculaOficina";
            this.labelMatriculaOficina.Size = new System.Drawing.Size(55, 13);
            this.labelMatriculaOficina.TabIndex = 2;
            this.labelMatriculaOficina.Text = "Matrícula:";
            // 
            // buttonAdicionarCarroOficina
            // 
            this.buttonAdicionarCarroOficina.Location = new System.Drawing.Point(6, 173);
            this.buttonAdicionarCarroOficina.Name = "buttonAdicionarCarroOficina";
            this.buttonAdicionarCarroOficina.Size = new System.Drawing.Size(183, 23);
            this.buttonAdicionarCarroOficina.TabIndex = 11;
            this.buttonAdicionarCarroOficina.Text = "Adicionar Carro";
            this.buttonAdicionarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarroOficina.Click += new System.EventHandler(this.buttonAdicionarCarroOficina_Click);
            // 
            // buttonRemoverCarroOficina
            // 
            this.buttonRemoverCarroOficina.Location = new System.Drawing.Point(6, 17);
            this.buttonRemoverCarroOficina.Name = "buttonRemoverCarroOficina";
            this.buttonRemoverCarroOficina.Size = new System.Drawing.Size(183, 23);
            this.buttonRemoverCarroOficina.TabIndex = 12;
            this.buttonRemoverCarroOficina.Text = "Remover Carro";
            this.buttonRemoverCarroOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverCarroOficina.Click += new System.EventHandler(this.buttonRemoverCarroOficina_Click);
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(6, 46);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.ScrollAlwaysVisible = true;
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(183, 199);
            this.listBoxCarrosOficina.TabIndex = 4;
            this.listBoxCarrosOficina.Click += new System.EventHandler(this.listBoxCarrosOficina_Click);
            // 
            // groupBoxFichaClienteOficina
            // 
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelTotalClienteOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelTotalGastoOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNifClienteSelecionadoOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelClienteSelecionadoOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNifOficina);
            this.groupBoxFichaClienteOficina.Controls.Add(this.labelNomeOficina);
            this.groupBoxFichaClienteOficina.Location = new System.Drawing.Point(219, 8);
            this.groupBoxFichaClienteOficina.Name = "groupBoxFichaClienteOficina";
            this.groupBoxFichaClienteOficina.Size = new System.Drawing.Size(681, 100);
            this.groupBoxFichaClienteOficina.TabIndex = 2;
            this.groupBoxFichaClienteOficina.TabStop = false;
            this.groupBoxFichaClienteOficina.Text = "Ficha do Cliente";
            // 
            // labelTotalClienteOficina
            // 
            this.labelTotalClienteOficina.AutoSize = true;
            this.labelTotalClienteOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClienteOficina.Location = new System.Drawing.Point(552, 54);
            this.labelTotalClienteOficina.Name = "labelTotalClienteOficina";
            this.labelTotalClienteOficina.Size = new System.Drawing.Size(55, 24);
            this.labelTotalClienteOficina.TabIndex = 5;
            this.labelTotalClienteOficina.Text = "0.00€";
            // 
            // labelTotalGastoOficina
            // 
            this.labelTotalGastoOficina.AutoSize = true;
            this.labelTotalGastoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGastoOficina.Location = new System.Drawing.Point(551, 22);
            this.labelTotalGastoOficina.Name = "labelTotalGastoOficina";
            this.labelTotalGastoOficina.Size = new System.Drawing.Size(96, 20);
            this.labelTotalGastoOficina.TabIndex = 4;
            this.labelTotalGastoOficina.Text = "Total Gasto:";
            // 
            // labelNifClienteSelecionadoOficina
            // 
            this.labelNifClienteSelecionadoOficina.AutoSize = true;
            this.labelNifClienteSelecionadoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoOficina.Location = new System.Drawing.Point(51, 60);
            this.labelNifClienteSelecionadoOficina.Name = "labelNifClienteSelecionadoOficina";
            this.labelNifClienteSelecionadoOficina.Size = new System.Drawing.Size(73, 24);
            this.labelNifClienteSelecionadoOficina.TabIndex = 3;
            this.labelNifClienteSelecionadoOficina.Text = "*********";
            // 
            // labelClienteSelecionadoOficina
            // 
            this.labelClienteSelecionadoOficina.AutoSize = true;
            this.labelClienteSelecionadoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionadoOficina.Location = new System.Drawing.Point(67, 22);
            this.labelClienteSelecionadoOficina.Name = "labelClienteSelecionadoOficina";
            this.labelClienteSelecionadoOficina.Size = new System.Drawing.Size(252, 24);
            this.labelClienteSelecionadoOficina.TabIndex = 2;
            this.labelClienteSelecionadoOficina.Text = "Nenhum cliente selecionado";
            // 
            // labelNifOficina
            // 
            this.labelNifOficina.AutoSize = true;
            this.labelNifOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifOficina.Location = new System.Drawing.Point(6, 60);
            this.labelNifOficina.Name = "labelNifOficina";
            this.labelNifOficina.Size = new System.Drawing.Size(39, 20);
            this.labelNifOficina.TabIndex = 1;
            this.labelNifOficina.Text = "NIF:";
            // 
            // labelNomeOficina
            // 
            this.labelNomeOficina.AutoSize = true;
            this.labelNomeOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeOficina.Location = new System.Drawing.Point(6, 22);
            this.labelNomeOficina.Name = "labelNomeOficina";
            this.labelNomeOficina.Size = new System.Drawing.Size(55, 20);
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
            this.groupBoxClientesOficina.Location = new System.Drawing.Point(9, 48);
            this.groupBoxClientesOficina.Name = "groupBoxClientesOficina";
            this.groupBoxClientesOficina.Size = new System.Drawing.Size(204, 522);
            this.groupBoxClientesOficina.TabIndex = 1;
            this.groupBoxClientesOficina.TabStop = false;
            this.groupBoxClientesOficina.Text = "Lista de Clientes";
            // 
            // labelProcurarPorOficina
            // 
            this.labelProcurarPorOficina.AutoSize = true;
            this.labelProcurarPorOficina.Location = new System.Drawing.Point(6, 24);
            this.labelProcurarPorOficina.Name = "labelProcurarPorOficina";
            this.labelProcurarPorOficina.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPorOficina.TabIndex = 4;
            this.labelProcurarPorOficina.Text = "Procurar por:";
            // 
            // labelTextoOficina
            // 
            this.labelTextoOficina.AutoSize = true;
            this.labelTextoOficina.Location = new System.Drawing.Point(121, 23);
            this.labelTextoOficina.Name = "labelTextoOficina";
            this.labelTextoOficina.Size = new System.Drawing.Size(43, 13);
            this.labelTextoOficina.TabIndex = 3;
            this.labelTextoOficina.Text = "Campo:";
            // 
            // comboBoxCampoOficina
            // 
            this.comboBoxCampoOficina.FormattingEnabled = true;
            this.comboBoxCampoOficina.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoOficina.Location = new System.Drawing.Point(123, 39);
            this.comboBoxCampoOficina.Name = "comboBoxCampoOficina";
            this.comboBoxCampoOficina.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCampoOficina.TabIndex = 2;
            // 
            // textBoxProcurarPorOficina
            // 
            this.textBoxProcurarPorOficina.Location = new System.Drawing.Point(7, 40);
            this.textBoxProcurarPorOficina.Name = "textBoxProcurarPorOficina";
            this.textBoxProcurarPorOficina.Size = new System.Drawing.Size(108, 20);
            this.textBoxProcurarPorOficina.TabIndex = 1;
            // 
            // listBoxClientesOficina
            // 
            this.listBoxClientesOficina.FormattingEnabled = true;
            this.listBoxClientesOficina.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesOficina.Name = "listBoxClientesOficina";
            this.listBoxClientesOficina.ScrollAlwaysVisible = true;
            this.listBoxClientesOficina.Size = new System.Drawing.Size(191, 446);
            this.listBoxClientesOficina.TabIndex = 3;
            this.listBoxClientesOficina.Click += new System.EventHandler(this.listBoxClientesOficina_Click);
            // 
            // labelTituloOficina
            // 
            this.labelTituloOficina.AutoSize = true;
            this.labelTituloOficina.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloOficina.ForeColor = System.Drawing.Color.Brown;
            this.labelTituloOficina.Location = new System.Drawing.Point(10, 8);
            this.labelTituloOficina.Name = "labelTituloOficina";
            this.labelTituloOficina.Size = new System.Drawing.Size(107, 32);
            this.labelTituloOficina.TabIndex = 0;
            this.labelTituloOficina.Text = "Oficina";
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.Color.Silver;
            this.tabPageVendas.Controls.Add(this.groupBox1);
            this.tabPageVendas.Controls.Add(this.groupBoxAdicionarNovoCarroVendas);
            this.tabPageVendas.Controls.Add(this.groupBoxCarrosVenda);
            this.tabPageVendas.Controls.Add(this.groupBoxListaClientesVendas);
            this.tabPageVendas.Controls.Add(this.label14);
            this.tabPageVendas.Controls.Add(this.groupBoxFichaClienteVendas);
            this.tabPageVendas.Location = new System.Drawing.Point(166, 4);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Size = new System.Drawing.Size(912, 573);
            this.tabPageVendas.TabIndex = 3;
            this.tabPageVendas.Text = "Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxValorVenda);
            this.groupBox1.Controls.Add(this.textBoxEstadoVendas);
            this.groupBox1.Controls.Add(this.labelEstadoVendas);
            this.groupBox1.Controls.Add(this.labelValorVendas);
            this.groupBox1.Controls.Add(this.dateTimePickerDataVenda);
            this.groupBox1.Controls.Add(this.labelDataVendaVendas);
            this.groupBox1.Controls.Add(this.buttonVenderCarro);
            this.groupBox1.Location = new System.Drawing.Point(705, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 192);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vender Carro";
            // 
            // maskedTextBoxValorVenda
            // 
            this.maskedTextBoxValorVenda.Location = new System.Drawing.Point(95, 78);
            this.maskedTextBoxValorVenda.Mask = "€00000.00";
            this.maskedTextBoxValorVenda.Name = "maskedTextBoxValorVenda";
            this.maskedTextBoxValorVenda.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorVenda.TabIndex = 28;
            // 
            // textBoxEstadoVendas
            // 
            this.textBoxEstadoVendas.Location = new System.Drawing.Point(52, 50);
            this.textBoxEstadoVendas.Name = "textBoxEstadoVendas";
            this.textBoxEstadoVendas.Size = new System.Drawing.Size(136, 20);
            this.textBoxEstadoVendas.TabIndex = 27;
            // 
            // labelEstadoVendas
            // 
            this.labelEstadoVendas.AutoSize = true;
            this.labelEstadoVendas.Location = new System.Drawing.Point(6, 53);
            this.labelEstadoVendas.Name = "labelEstadoVendas";
            this.labelEstadoVendas.Size = new System.Drawing.Size(46, 13);
            this.labelEstadoVendas.TabIndex = 26;
            this.labelEstadoVendas.Text = "Estado: ";
            // 
            // labelValorVendas
            // 
            this.labelValorVendas.AutoSize = true;
            this.labelValorVendas.Location = new System.Drawing.Point(6, 81);
            this.labelValorVendas.Name = "labelValorVendas";
            this.labelValorVendas.Size = new System.Drawing.Size(83, 13);
            this.labelValorVendas.TabIndex = 25;
            this.labelValorVendas.Text = "Valor da Venda:";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(91, 20);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDataVenda.TabIndex = 23;
            // 
            // labelDataVendaVendas
            // 
            this.labelDataVendaVendas.AutoSize = true;
            this.labelDataVendaVendas.Location = new System.Drawing.Point(7, 26);
            this.labelDataVendaVendas.Name = "labelDataVendaVendas";
            this.labelDataVendaVendas.Size = new System.Drawing.Size(82, 13);
            this.labelDataVendaVendas.TabIndex = 20;
            this.labelDataVendaVendas.Text = "Data de Venda:";
            // 
            // buttonVenderCarro
            // 
            this.buttonVenderCarro.Location = new System.Drawing.Point(6, 143);
            this.buttonVenderCarro.Name = "buttonVenderCarro";
            this.buttonVenderCarro.Size = new System.Drawing.Size(183, 43);
            this.buttonVenderCarro.TabIndex = 1;
            this.buttonVenderCarro.Text = "Vender Carro";
            this.buttonVenderCarro.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdicionarNovoCarroVendas
            // 
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.textBoxExtrasVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.labelExtrasVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.textBoxModeloVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.textBoxMarcaVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.textBoxChassiVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.comboBoxCombustivelVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.labelCombustivelVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.labelModeloVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.labelMarcaVendas);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.labelNChassis);
            this.groupBoxAdicionarNovoCarroVendas.Controls.Add(this.buttonAdicionarCarroVendas);
            this.groupBoxAdicionarNovoCarroVendas.Location = new System.Drawing.Point(705, 114);
            this.groupBoxAdicionarNovoCarroVendas.Name = "groupBoxAdicionarNovoCarroVendas";
            this.groupBoxAdicionarNovoCarroVendas.Size = new System.Drawing.Size(195, 242);
            this.groupBoxAdicionarNovoCarroVendas.TabIndex = 16;
            this.groupBoxAdicionarNovoCarroVendas.TabStop = false;
            this.groupBoxAdicionarNovoCarroVendas.Text = "Adicionar Novo Carro de Venda";
            // 
            // textBoxExtrasVendas
            // 
            this.textBoxExtrasVendas.Location = new System.Drawing.Point(48, 138);
            this.textBoxExtrasVendas.Multiline = true;
            this.textBoxExtrasVendas.Name = "textBoxExtrasVendas";
            this.textBoxExtrasVendas.Size = new System.Drawing.Size(140, 20);
            this.textBoxExtrasVendas.TabIndex = 15;
            // 
            // labelExtrasVendas
            // 
            this.labelExtrasVendas.AutoSize = true;
            this.labelExtrasVendas.Location = new System.Drawing.Point(6, 141);
            this.labelExtrasVendas.Name = "labelExtrasVendas";
            this.labelExtrasVendas.Size = new System.Drawing.Size(36, 13);
            this.labelExtrasVendas.TabIndex = 14;
            this.labelExtrasVendas.Text = "Extas:";
            // 
            // textBoxModeloVendas
            // 
            this.textBoxModeloVendas.Location = new System.Drawing.Point(57, 82);
            this.textBoxModeloVendas.Name = "textBoxModeloVendas";
            this.textBoxModeloVendas.Size = new System.Drawing.Size(131, 20);
            this.textBoxModeloVendas.TabIndex = 13;
            // 
            // textBoxMarcaVendas
            // 
            this.textBoxMarcaVendas.Location = new System.Drawing.Point(52, 55);
            this.textBoxMarcaVendas.Name = "textBoxMarcaVendas";
            this.textBoxMarcaVendas.Size = new System.Drawing.Size(136, 20);
            this.textBoxMarcaVendas.TabIndex = 12;
            // 
            // textBoxChassiVendas
            // 
            this.textBoxChassiVendas.Location = new System.Drawing.Point(72, 25);
            this.textBoxChassiVendas.Name = "textBoxChassiVendas";
            this.textBoxChassiVendas.Size = new System.Drawing.Size(116, 20);
            this.textBoxChassiVendas.TabIndex = 11;
            // 
            // comboBoxCombustivelVendas
            // 
            this.comboBoxCombustivelVendas.FormattingEnabled = true;
            this.comboBoxCombustivelVendas.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Diesel",
            "Gás",
            "Híbrido"});
            this.comboBoxCombustivelVendas.Location = new System.Drawing.Point(81, 111);
            this.comboBoxCombustivelVendas.Name = "comboBoxCombustivelVendas";
            this.comboBoxCombustivelVendas.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCombustivelVendas.TabIndex = 10;
            // 
            // labelCombustivelVendas
            // 
            this.labelCombustivelVendas.AutoSize = true;
            this.labelCombustivelVendas.Location = new System.Drawing.Point(6, 114);
            this.labelCombustivelVendas.Name = "labelCombustivelVendas";
            this.labelCombustivelVendas.Size = new System.Drawing.Size(69, 13);
            this.labelCombustivelVendas.TabIndex = 9;
            this.labelCombustivelVendas.Text = "Combustível:";
            // 
            // labelModeloVendas
            // 
            this.labelModeloVendas.AutoSize = true;
            this.labelModeloVendas.Location = new System.Drawing.Point(6, 85);
            this.labelModeloVendas.Name = "labelModeloVendas";
            this.labelModeloVendas.Size = new System.Drawing.Size(45, 13);
            this.labelModeloVendas.TabIndex = 8;
            this.labelModeloVendas.Text = "Modelo:";
            // 
            // labelMarcaVendas
            // 
            this.labelMarcaVendas.AutoSize = true;
            this.labelMarcaVendas.Location = new System.Drawing.Point(6, 58);
            this.labelMarcaVendas.Name = "labelMarcaVendas";
            this.labelMarcaVendas.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaVendas.TabIndex = 7;
            this.labelMarcaVendas.Text = "Marca:";
            // 
            // labelNChassis
            // 
            this.labelNChassis.AutoSize = true;
            this.labelNChassis.Location = new System.Drawing.Point(6, 28);
            this.labelNChassis.Name = "labelNChassis";
            this.labelNChassis.Size = new System.Drawing.Size(61, 13);
            this.labelNChassis.TabIndex = 6;
            this.labelNChassis.Text = "Nº Chassis:";
            // 
            // buttonAdicionarCarroVendas
            // 
            this.buttonAdicionarCarroVendas.Location = new System.Drawing.Point(6, 195);
            this.buttonAdicionarCarroVendas.Name = "buttonAdicionarCarroVendas";
            this.buttonAdicionarCarroVendas.Size = new System.Drawing.Size(183, 41);
            this.buttonAdicionarCarroVendas.TabIndex = 1;
            this.buttonAdicionarCarroVendas.Text = "Adicionar Carro";
            this.buttonAdicionarCarroVendas.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarrosVenda
            // 
            this.groupBoxCarrosVenda.Controls.Add(this.buttonRemoverCarrosVendas);
            this.groupBoxCarrosVenda.Controls.Add(this.listBoxCarrosVendas);
            this.groupBoxCarrosVenda.Location = new System.Drawing.Point(340, 114);
            this.groupBoxCarrosVenda.Name = "groupBoxCarrosVenda";
            this.groupBoxCarrosVenda.Size = new System.Drawing.Size(359, 456);
            this.groupBoxCarrosVenda.TabIndex = 20;
            this.groupBoxCarrosVenda.TabStop = false;
            this.groupBoxCarrosVenda.Text = "Carros para Vender";
            // 
            // buttonRemoverCarrosVendas
            // 
            this.buttonRemoverCarrosVendas.Location = new System.Drawing.Point(6, 19);
            this.buttonRemoverCarrosVendas.Name = "buttonRemoverCarrosVendas";
            this.buttonRemoverCarrosVendas.Size = new System.Drawing.Size(347, 30);
            this.buttonRemoverCarrosVendas.TabIndex = 2;
            this.buttonRemoverCarrosVendas.Text = "Remover Carro da Lista de Venda";
            this.buttonRemoverCarrosVendas.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosVendas
            // 
            this.listBoxCarrosVendas.FormattingEnabled = true;
            this.listBoxCarrosVendas.Location = new System.Drawing.Point(6, 55);
            this.listBoxCarrosVendas.Name = "listBoxCarrosVendas";
            this.listBoxCarrosVendas.ScrollAlwaysVisible = true;
            this.listBoxCarrosVendas.Size = new System.Drawing.Size(347, 394);
            this.listBoxCarrosVendas.TabIndex = 0;
            // 
            // groupBoxListaClientesVendas
            // 
            this.groupBoxListaClientesVendas.Controls.Add(this.labelCampoVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.labelProcurarPorVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.comboBoxCampoVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.textBoxProcurarPorVendas);
            this.groupBoxListaClientesVendas.Controls.Add(this.listBoxClientesVendas);
            this.groupBoxListaClientesVendas.Location = new System.Drawing.Point(9, 48);
            this.groupBoxListaClientesVendas.Name = "groupBoxListaClientesVendas";
            this.groupBoxListaClientesVendas.Size = new System.Drawing.Size(325, 522);
            this.groupBoxListaClientesVendas.TabIndex = 19;
            this.groupBoxListaClientesVendas.TabStop = false;
            this.groupBoxListaClientesVendas.Text = "Lista de Clientes";
            // 
            // labelCampoVendas
            // 
            this.labelCampoVendas.AutoSize = true;
            this.labelCampoVendas.Location = new System.Drawing.Point(242, 21);
            this.labelCampoVendas.Name = "labelCampoVendas";
            this.labelCampoVendas.Size = new System.Drawing.Size(43, 13);
            this.labelCampoVendas.TabIndex = 4;
            this.labelCampoVendas.Text = "Campo:";
            // 
            // labelProcurarPorVendas
            // 
            this.labelProcurarPorVendas.AutoSize = true;
            this.labelProcurarPorVendas.Location = new System.Drawing.Point(4, 21);
            this.labelProcurarPorVendas.Name = "labelProcurarPorVendas";
            this.labelProcurarPorVendas.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPorVendas.TabIndex = 3;
            this.labelProcurarPorVendas.Text = "Procurar por:";
            // 
            // comboBoxCampoVendas
            // 
            this.comboBoxCampoVendas.FormattingEnabled = true;
            this.comboBoxCampoVendas.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoVendas.Location = new System.Drawing.Point(244, 39);
            this.comboBoxCampoVendas.Name = "comboBoxCampoVendas";
            this.comboBoxCampoVendas.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCampoVendas.TabIndex = 2;
            // 
            // textBoxProcurarPorVendas
            // 
            this.textBoxProcurarPorVendas.Location = new System.Drawing.Point(7, 40);
            this.textBoxProcurarPorVendas.Name = "textBoxProcurarPorVendas";
            this.textBoxProcurarPorVendas.Size = new System.Drawing.Size(231, 20);
            this.textBoxProcurarPorVendas.TabIndex = 1;
            // 
            // listBoxClientesVendas
            // 
            this.listBoxClientesVendas.FormattingEnabled = true;
            this.listBoxClientesVendas.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesVendas.Name = "listBoxClientesVendas";
            this.listBoxClientesVendas.ScrollAlwaysVisible = true;
            this.listBoxClientesVendas.Size = new System.Drawing.Size(312, 446);
            this.listBoxClientesVendas.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Brown;
            this.label14.Location = new System.Drawing.Point(10, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 32);
            this.label14.TabIndex = 18;
            this.label14.Text = "Vendas";
            // 
            // groupBoxFichaClienteVendas
            // 
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNifClienteSelecionadoVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNomeClienteSelecionadoVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNifVendas);
            this.groupBoxFichaClienteVendas.Controls.Add(this.labelNomeVendas);
            this.groupBoxFichaClienteVendas.Location = new System.Drawing.Point(340, 8);
            this.groupBoxFichaClienteVendas.Name = "groupBoxFichaClienteVendas";
            this.groupBoxFichaClienteVendas.Size = new System.Drawing.Size(560, 100);
            this.groupBoxFichaClienteVendas.TabIndex = 17;
            this.groupBoxFichaClienteVendas.TabStop = false;
            this.groupBoxFichaClienteVendas.Text = "Ficha do Cliente";
            // 
            // labelNifClienteSelecionadoVendas
            // 
            this.labelNifClienteSelecionadoVendas.AutoSize = true;
            this.labelNifClienteSelecionadoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoVendas.Location = new System.Drawing.Point(51, 60);
            this.labelNifClienteSelecionadoVendas.Name = "labelNifClienteSelecionadoVendas";
            this.labelNifClienteSelecionadoVendas.Size = new System.Drawing.Size(73, 24);
            this.labelNifClienteSelecionadoVendas.TabIndex = 3;
            this.labelNifClienteSelecionadoVendas.Text = "*********";
            // 
            // labelNomeClienteSelecionadoVendas
            // 
            this.labelNomeClienteSelecionadoVendas.AutoSize = true;
            this.labelNomeClienteSelecionadoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeClienteSelecionadoVendas.Location = new System.Drawing.Point(67, 22);
            this.labelNomeClienteSelecionadoVendas.Name = "labelNomeClienteSelecionadoVendas";
            this.labelNomeClienteSelecionadoVendas.Size = new System.Drawing.Size(252, 24);
            this.labelNomeClienteSelecionadoVendas.TabIndex = 2;
            this.labelNomeClienteSelecionadoVendas.Text = "Nenhum cliente selecionado";
            // 
            // labelNifVendas
            // 
            this.labelNifVendas.AutoSize = true;
            this.labelNifVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifVendas.Location = new System.Drawing.Point(6, 60);
            this.labelNifVendas.Name = "labelNifVendas";
            this.labelNifVendas.Size = new System.Drawing.Size(39, 20);
            this.labelNifVendas.TabIndex = 1;
            this.labelNifVendas.Text = "NIF:";
            // 
            // labelNomeVendas
            // 
            this.labelNomeVendas.AutoSize = true;
            this.labelNomeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeVendas.Location = new System.Drawing.Point(6, 22);
            this.labelNomeVendas.Name = "labelNomeVendas";
            this.labelNomeVendas.Size = new System.Drawing.Size(55, 20);
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
            this.tabPageAluguer.Name = "tabPageAluguer";
            this.tabPageAluguer.Size = new System.Drawing.Size(912, 573);
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
            this.groupBoxAluguerCarro.Location = new System.Drawing.Point(705, 378);
            this.groupBoxAluguerCarro.Name = "groupBoxAluguerCarro";
            this.groupBoxAluguerCarro.Size = new System.Drawing.Size(195, 192);
            this.groupBoxAluguerCarro.TabIndex = 15;
            this.groupBoxAluguerCarro.TabStop = false;
            this.groupBoxAluguerCarro.Text = "Alugar Carro";
            // 
            // maskedTextBoxValorAluguer
            // 
            this.maskedTextBoxValorAluguer.Location = new System.Drawing.Point(101, 108);
            this.maskedTextBoxValorAluguer.Mask = "€00000.00";
            this.maskedTextBoxValorAluguer.Name = "maskedTextBoxValorAluguer";
            this.maskedTextBoxValorAluguer.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorAluguer.TabIndex = 28;
            // 
            // textBoxQuilometragemAluguer
            // 
            this.textBoxQuilometragemAluguer.Location = new System.Drawing.Point(96, 80);
            this.textBoxQuilometragemAluguer.Name = "textBoxQuilometragemAluguer";
            this.textBoxQuilometragemAluguer.Size = new System.Drawing.Size(94, 20);
            this.textBoxQuilometragemAluguer.TabIndex = 27;
            // 
            // labelQuilometragemAluguer
            // 
            this.labelQuilometragemAluguer.AutoSize = true;
            this.labelQuilometragemAluguer.Location = new System.Drawing.Point(7, 83);
            this.labelQuilometragemAluguer.Name = "labelQuilometragemAluguer";
            this.labelQuilometragemAluguer.Size = new System.Drawing.Size(83, 13);
            this.labelQuilometragemAluguer.TabIndex = 26;
            this.labelQuilometragemAluguer.Text = "Quilometragem: ";
            // 
            // labelValorAluguer
            // 
            this.labelValorAluguer.AutoSize = true;
            this.labelValorAluguer.Location = new System.Drawing.Point(7, 111);
            this.labelValorAluguer.Name = "labelValorAluguer";
            this.labelValorAluguer.Size = new System.Drawing.Size(88, 13);
            this.labelValorAluguer.TabIndex = 25;
            this.labelValorAluguer.Text = "Valor do Aluguer:";
            // 
            // dateTimePickerDataFimAluguer
            // 
            this.dateTimePickerDataFimAluguer.Location = new System.Drawing.Point(80, 52);
            this.dateTimePickerDataFimAluguer.Name = "dateTimePickerDataFimAluguer";
            this.dateTimePickerDataFimAluguer.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerDataFimAluguer.TabIndex = 24;
            // 
            // dateTimePickerDataInicioAluguer
            // 
            this.dateTimePickerDataInicioAluguer.Location = new System.Drawing.Point(91, 20);
            this.dateTimePickerDataInicioAluguer.Name = "dateTimePickerDataInicioAluguer";
            this.dateTimePickerDataInicioAluguer.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDataInicioAluguer.TabIndex = 23;
            // 
            // labelDataFimAluguer
            // 
            this.labelDataFimAluguer.AutoSize = true;
            this.labelDataFimAluguer.Location = new System.Drawing.Point(7, 55);
            this.labelDataFimAluguer.Name = "labelDataFimAluguer";
            this.labelDataFimAluguer.Size = new System.Drawing.Size(67, 13);
            this.labelDataFimAluguer.TabIndex = 22;
            this.labelDataFimAluguer.Text = "Data de Fim:";
            // 
            // labelDataInicioAluguer
            // 
            this.labelDataInicioAluguer.AutoSize = true;
            this.labelDataInicioAluguer.Location = new System.Drawing.Point(7, 26);
            this.labelDataInicioAluguer.Name = "labelDataInicioAluguer";
            this.labelDataInicioAluguer.Size = new System.Drawing.Size(78, 13);
            this.labelDataInicioAluguer.TabIndex = 20;
            this.labelDataInicioAluguer.Text = "Data de Início:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 43);
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
            this.groupBoxAdicionarCarroAluguer.Location = new System.Drawing.Point(705, 114);
            this.groupBoxAdicionarCarroAluguer.Name = "groupBoxAdicionarCarroAluguer";
            this.groupBoxAdicionarCarroAluguer.Size = new System.Drawing.Size(195, 242);
            this.groupBoxAdicionarCarroAluguer.TabIndex = 3;
            this.groupBoxAdicionarCarroAluguer.TabStop = false;
            this.groupBoxAdicionarCarroAluguer.Text = "Adicionar Novo Carro de Aluguer";
            // 
            // checkBoxEstadoAluguer
            // 
            this.checkBoxEstadoAluguer.AutoSize = true;
            this.checkBoxEstadoAluguer.Location = new System.Drawing.Point(57, 23);
            this.checkBoxEstadoAluguer.Name = "checkBoxEstadoAluguer";
            this.checkBoxEstadoAluguer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstadoAluguer.TabIndex = 14;
            this.checkBoxEstadoAluguer.UseVisualStyleBackColor = true;
            // 
            // textBoxModeloAluguer
            // 
            this.textBoxModeloAluguer.Location = new System.Drawing.Point(58, 130);
            this.textBoxModeloAluguer.Name = "textBoxModeloAluguer";
            this.textBoxModeloAluguer.Size = new System.Drawing.Size(131, 20);
            this.textBoxModeloAluguer.TabIndex = 13;
            // 
            // textBoxMarcaAluguer
            // 
            this.textBoxMarcaAluguer.Location = new System.Drawing.Point(53, 103);
            this.textBoxMarcaAluguer.Name = "textBoxMarcaAluguer";
            this.textBoxMarcaAluguer.Size = new System.Drawing.Size(136, 20);
            this.textBoxMarcaAluguer.TabIndex = 12;
            // 
            // textBoxChassiAluguer
            // 
            this.textBoxChassiAluguer.Location = new System.Drawing.Point(73, 73);
            this.textBoxChassiAluguer.Name = "textBoxChassiAluguer";
            this.textBoxChassiAluguer.Size = new System.Drawing.Size(116, 20);
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
            this.comboBoxCombustivelAluguer.Location = new System.Drawing.Point(82, 159);
            this.comboBoxCombustivelAluguer.Name = "comboBoxCombustivelAluguer";
            this.comboBoxCombustivelAluguer.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCombustivelAluguer.TabIndex = 10;
            // 
            // labelCombustivelAluguer
            // 
            this.labelCombustivelAluguer.AutoSize = true;
            this.labelCombustivelAluguer.Location = new System.Drawing.Point(7, 162);
            this.labelCombustivelAluguer.Name = "labelCombustivelAluguer";
            this.labelCombustivelAluguer.Size = new System.Drawing.Size(69, 13);
            this.labelCombustivelAluguer.TabIndex = 9;
            this.labelCombustivelAluguer.Text = "Combustível:";
            // 
            // labelModeloAluguer
            // 
            this.labelModeloAluguer.AutoSize = true;
            this.labelModeloAluguer.Location = new System.Drawing.Point(7, 133);
            this.labelModeloAluguer.Name = "labelModeloAluguer";
            this.labelModeloAluguer.Size = new System.Drawing.Size(45, 13);
            this.labelModeloAluguer.TabIndex = 8;
            this.labelModeloAluguer.Text = "Modelo:";
            // 
            // labelMarcaAluguer
            // 
            this.labelMarcaAluguer.AutoSize = true;
            this.labelMarcaAluguer.Location = new System.Drawing.Point(7, 106);
            this.labelMarcaAluguer.Name = "labelMarcaAluguer";
            this.labelMarcaAluguer.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaAluguer.TabIndex = 7;
            this.labelMarcaAluguer.Text = "Marca:";
            // 
            // labelNChassisAluguer
            // 
            this.labelNChassisAluguer.AutoSize = true;
            this.labelNChassisAluguer.Location = new System.Drawing.Point(7, 76);
            this.labelNChassisAluguer.Name = "labelNChassisAluguer";
            this.labelNChassisAluguer.Size = new System.Drawing.Size(61, 13);
            this.labelNChassisAluguer.TabIndex = 6;
            this.labelNChassisAluguer.Text = "Nº Chassis:";
            // 
            // labelAlugadoAluguer
            // 
            this.labelAlugadoAluguer.AutoSize = true;
            this.labelAlugadoAluguer.Location = new System.Drawing.Point(7, 22);
            this.labelAlugadoAluguer.Name = "labelAlugadoAluguer";
            this.labelAlugadoAluguer.Size = new System.Drawing.Size(49, 13);
            this.labelAlugadoAluguer.TabIndex = 4;
            this.labelAlugadoAluguer.Text = "Alugado:";
            // 
            // maskedTextBoxMatriculaAluguer
            // 
            this.maskedTextBoxMatriculaAluguer.Location = new System.Drawing.Point(70, 44);
            this.maskedTextBoxMatriculaAluguer.Mask = "AA-AA-AA";
            this.maskedTextBoxMatriculaAluguer.Name = "maskedTextBoxMatriculaAluguer";
            this.maskedTextBoxMatriculaAluguer.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxMatriculaAluguer.TabIndex = 3;
            // 
            // labelMatriculaAluguer
            // 
            this.labelMatriculaAluguer.AutoSize = true;
            this.labelMatriculaAluguer.Location = new System.Drawing.Point(7, 47);
            this.labelMatriculaAluguer.Name = "labelMatriculaAluguer";
            this.labelMatriculaAluguer.Size = new System.Drawing.Size(55, 13);
            this.labelMatriculaAluguer.TabIndex = 2;
            this.labelMatriculaAluguer.Text = "Matrícula:";
            // 
            // buttonAdicionarCarroAluguer
            // 
            this.buttonAdicionarCarroAluguer.Location = new System.Drawing.Point(6, 195);
            this.buttonAdicionarCarroAluguer.Name = "buttonAdicionarCarroAluguer";
            this.buttonAdicionarCarroAluguer.Size = new System.Drawing.Size(183, 41);
            this.buttonAdicionarCarroAluguer.TabIndex = 1;
            this.buttonAdicionarCarroAluguer.Text = "Adicionar Carro";
            this.buttonAdicionarCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarrosAluguer
            // 
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonRemoverCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.listBoxCarrosAluguer);
            this.groupBoxCarrosAluguer.Location = new System.Drawing.Point(340, 114);
            this.groupBoxCarrosAluguer.Name = "groupBoxCarrosAluguer";
            this.groupBoxCarrosAluguer.Size = new System.Drawing.Size(359, 456);
            this.groupBoxCarrosAluguer.TabIndex = 8;
            this.groupBoxCarrosAluguer.TabStop = false;
            this.groupBoxCarrosAluguer.Text = "Carros para Aluguer";
            // 
            // buttonRemoverCarroAluguer
            // 
            this.buttonRemoverCarroAluguer.Location = new System.Drawing.Point(6, 19);
            this.buttonRemoverCarroAluguer.Name = "buttonRemoverCarroAluguer";
            this.buttonRemoverCarroAluguer.Size = new System.Drawing.Size(347, 30);
            this.buttonRemoverCarroAluguer.TabIndex = 2;
            this.buttonRemoverCarroAluguer.Text = "Remover Carro da Lista de Aluguer";
            this.buttonRemoverCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosAluguer
            // 
            this.listBoxCarrosAluguer.FormattingEnabled = true;
            this.listBoxCarrosAluguer.Location = new System.Drawing.Point(6, 55);
            this.listBoxCarrosAluguer.Name = "listBoxCarrosAluguer";
            this.listBoxCarrosAluguer.ScrollAlwaysVisible = true;
            this.listBoxCarrosAluguer.Size = new System.Drawing.Size(347, 394);
            this.listBoxCarrosAluguer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCampoAluguer);
            this.groupBox2.Controls.Add(this.labelProcurarPorAluguer);
            this.groupBox2.Controls.Add(this.comboBoxCampoAluguer);
            this.groupBox2.Controls.Add(this.textBoxProcurarPorAluguer);
            this.groupBox2.Controls.Add(this.listBoxClientesAluguer);
            this.groupBox2.Location = new System.Drawing.Point(9, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 522);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // labelCampoAluguer
            // 
            this.labelCampoAluguer.AutoSize = true;
            this.labelCampoAluguer.Location = new System.Drawing.Point(242, 21);
            this.labelCampoAluguer.Name = "labelCampoAluguer";
            this.labelCampoAluguer.Size = new System.Drawing.Size(43, 13);
            this.labelCampoAluguer.TabIndex = 4;
            this.labelCampoAluguer.Text = "Campo:";
            // 
            // labelProcurarPorAluguer
            // 
            this.labelProcurarPorAluguer.AutoSize = true;
            this.labelProcurarPorAluguer.Location = new System.Drawing.Point(4, 21);
            this.labelProcurarPorAluguer.Name = "labelProcurarPorAluguer";
            this.labelProcurarPorAluguer.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPorAluguer.TabIndex = 3;
            this.labelProcurarPorAluguer.Text = "Procurar por:";
            // 
            // comboBoxCampoAluguer
            // 
            this.comboBoxCampoAluguer.FormattingEnabled = true;
            this.comboBoxCampoAluguer.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoAluguer.Location = new System.Drawing.Point(244, 39);
            this.comboBoxCampoAluguer.Name = "comboBoxCampoAluguer";
            this.comboBoxCampoAluguer.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCampoAluguer.TabIndex = 2;
            // 
            // textBoxProcurarPorAluguer
            // 
            this.textBoxProcurarPorAluguer.Location = new System.Drawing.Point(7, 40);
            this.textBoxProcurarPorAluguer.Name = "textBoxProcurarPorAluguer";
            this.textBoxProcurarPorAluguer.Size = new System.Drawing.Size(231, 20);
            this.textBoxProcurarPorAluguer.TabIndex = 1;
            // 
            // listBoxClientesAluguer
            // 
            this.listBoxClientesAluguer.FormattingEnabled = true;
            this.listBoxClientesAluguer.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesAluguer.Name = "listBoxClientesAluguer";
            this.listBoxClientesAluguer.ScrollAlwaysVisible = true;
            this.listBoxClientesAluguer.Size = new System.Drawing.Size(312, 446);
            this.listBoxClientesAluguer.TabIndex = 0;
            // 
            // labelTituloAluguer
            // 
            this.labelTituloAluguer.AutoSize = true;
            this.labelTituloAluguer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloAluguer.ForeColor = System.Drawing.Color.Brown;
            this.labelTituloAluguer.Location = new System.Drawing.Point(10, 8);
            this.labelTituloAluguer.Name = "labelTituloAluguer";
            this.labelTituloAluguer.Size = new System.Drawing.Size(118, 32);
            this.labelTituloAluguer.TabIndex = 6;
            this.labelTituloAluguer.Text = "Aluguer";
            // 
            // groupBoxFichaClienteVenda
            // 
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNifClienteSelecionadoAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelClienteSelecionadoAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNifAluguer);
            this.groupBoxFichaClienteVenda.Controls.Add(this.labelNomeAluguer);
            this.groupBoxFichaClienteVenda.Location = new System.Drawing.Point(340, 8);
            this.groupBoxFichaClienteVenda.Name = "groupBoxFichaClienteVenda";
            this.groupBoxFichaClienteVenda.Size = new System.Drawing.Size(560, 100);
            this.groupBoxFichaClienteVenda.TabIndex = 3;
            this.groupBoxFichaClienteVenda.TabStop = false;
            this.groupBoxFichaClienteVenda.Text = "Ficha do Cliente";
            // 
            // labelNifClienteSelecionadoAluguer
            // 
            this.labelNifClienteSelecionadoAluguer.AutoSize = true;
            this.labelNifClienteSelecionadoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifClienteSelecionadoAluguer.Location = new System.Drawing.Point(51, 60);
            this.labelNifClienteSelecionadoAluguer.Name = "labelNifClienteSelecionadoAluguer";
            this.labelNifClienteSelecionadoAluguer.Size = new System.Drawing.Size(73, 24);
            this.labelNifClienteSelecionadoAluguer.TabIndex = 3;
            this.labelNifClienteSelecionadoAluguer.Text = "*********";
            // 
            // labelClienteSelecionadoAluguer
            // 
            this.labelClienteSelecionadoAluguer.AutoSize = true;
            this.labelClienteSelecionadoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionadoAluguer.Location = new System.Drawing.Point(67, 22);
            this.labelClienteSelecionadoAluguer.Name = "labelClienteSelecionadoAluguer";
            this.labelClienteSelecionadoAluguer.Size = new System.Drawing.Size(252, 24);
            this.labelClienteSelecionadoAluguer.TabIndex = 2;
            this.labelClienteSelecionadoAluguer.Text = "Nenhum cliente selecionado";
            // 
            // labelNifAluguer
            // 
            this.labelNifAluguer.AutoSize = true;
            this.labelNifAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifAluguer.Location = new System.Drawing.Point(6, 60);
            this.labelNifAluguer.Name = "labelNifAluguer";
            this.labelNifAluguer.Size = new System.Drawing.Size(39, 20);
            this.labelNifAluguer.TabIndex = 1;
            this.labelNifAluguer.Text = "NIF:";
            // 
            // labelNomeAluguer
            // 
            this.labelNomeAluguer.AutoSize = true;
            this.labelNomeAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAluguer.Location = new System.Drawing.Point(6, 22);
            this.labelNomeAluguer.Name = "labelNomeAluguer";
            this.labelNomeAluguer.Size = new System.Drawing.Size(55, 20);
            this.labelNomeAluguer.TabIndex = 0;
            this.labelNomeAluguer.Text = "Nome:";
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
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
            this.groupBoxFichaClienteOficina.ResumeLayout(false);
            this.groupBoxFichaClienteOficina.PerformLayout();
            this.groupBoxClientesOficina.ResumeLayout(false);
            this.groupBoxClientesOficina.PerformLayout();
            this.tabPageVendas.ResumeLayout(false);
            this.tabPageVendas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAdicionarNovoCarroVendas.ResumeLayout(false);
            this.groupBoxAdicionarNovoCarroVendas.PerformLayout();
            this.groupBoxCarrosVenda.ResumeLayout(false);
            this.groupBoxListaClientesVendas.ResumeLayout(false);
            this.groupBoxListaClientesVendas.PerformLayout();
            this.groupBoxFichaClienteVendas.ResumeLayout(false);
            this.groupBoxFichaClienteVendas.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBoxDadosClientes;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox nIFMaskedTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.MaskedTextBox contactoMaskedTextBox;
        private System.Windows.Forms.ListBox clientesListBox;
        private System.Windows.Forms.Label labelCampoDeProcura;
        private System.Windows.Forms.Label labelProcurarPor;
        private System.Windows.Forms.ComboBox comboBoxCampoProcura;
        private System.Windows.Forms.TextBox textBoxProcurarPor;
        private System.Windows.Forms.Button buttonGravarCliente;
        private System.Windows.Forms.GroupBox groupBoxParcelasOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarParcelaOficina;
        private System.Windows.Forms.Button buttonAdicionarParcelaOficina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorParcelaOficina;
        private System.Windows.Forms.TextBox textBoxDescricaoParcelaOficina;
        private System.Windows.Forms.ListBox listBoxParcelasOficina;
        private System.Windows.Forms.GroupBox groupBoxServicosOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarServicoOficina;
        private System.Windows.Forms.Button buttonAdicionarServicoOficina;
        private System.Windows.Forms.ComboBox comboBoxTipoServicosOficina;
        private System.Windows.Forms.ListBox listBoxServicosOficina;
        private System.Windows.Forms.GroupBox groupBoxCarrosOficina;
        private System.Windows.Forms.Button buttonAdicionarCarroOficina;
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
        private System.Windows.Forms.Button buttonRemoverServicoOficina;
        private System.Windows.Forms.Button buttonRemoverCarroOficina;
        private System.Windows.Forms.GroupBox groupBoxCriarCarroOficina;
        private System.Windows.Forms.Label labelQuilometragemOficina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatriculaOficina;
        private System.Windows.Forms.Label labelMatriculaOficina;
        private System.Windows.Forms.TextBox textBoxKMsOficina;
        private System.Windows.Forms.Label labelModeloOficina;
        private System.Windows.Forms.Label labelMarcaOficina;
        private System.Windows.Forms.Label labelNChassisOficina;
        private System.Windows.Forms.ComboBox comboBoxCombustivelOficina;
        private System.Windows.Forms.Label labelCombustivelOficina;
        private System.Windows.Forms.TextBox textBoxModeloOficina;
        private System.Windows.Forms.TextBox textBoxMarcaOficina;
        private System.Windows.Forms.TextBox textBoxChassiOficina;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorVenda;
        private System.Windows.Forms.TextBox textBoxEstadoVendas;
        private System.Windows.Forms.Label labelEstadoVendas;
        private System.Windows.Forms.Label labelValorVendas;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVenda;
        private System.Windows.Forms.Label labelDataVendaVendas;
        private System.Windows.Forms.Button buttonVenderCarro;
        private System.Windows.Forms.GroupBox groupBoxAdicionarNovoCarroVendas;
        private System.Windows.Forms.TextBox textBoxModeloVendas;
        private System.Windows.Forms.TextBox textBoxMarcaVendas;
        private System.Windows.Forms.TextBox textBoxChassiVendas;
        private System.Windows.Forms.ComboBox comboBoxCombustivelVendas;
        private System.Windows.Forms.Label labelCombustivelVendas;
        private System.Windows.Forms.Label labelModeloVendas;
        private System.Windows.Forms.Label labelMarcaVendas;
        private System.Windows.Forms.Label labelNChassis;
        private System.Windows.Forms.Button buttonAdicionarCarroVendas;
        private System.Windows.Forms.GroupBox groupBoxCarrosVenda;
        private System.Windows.Forms.Button buttonRemoverCarrosVendas;
        private System.Windows.Forms.ListBox listBoxCarrosVendas;
        private System.Windows.Forms.GroupBox groupBoxListaClientesVendas;
        private System.Windows.Forms.Label labelCampoVendas;
        private System.Windows.Forms.Label labelProcurarPorVendas;
        private System.Windows.Forms.ComboBox comboBoxCampoVendas;
        private System.Windows.Forms.TextBox textBoxProcurarPorVendas;
        private System.Windows.Forms.ListBox listBoxClientesVendas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxFichaClienteVendas;
        private System.Windows.Forms.Label labelNifClienteSelecionadoVendas;
        private System.Windows.Forms.Label labelNomeClienteSelecionadoVendas;
        private System.Windows.Forms.Label labelNifVendas;
        private System.Windows.Forms.Label labelNomeVendas;
        private System.Windows.Forms.TextBox textBoxExtrasVendas;
        private System.Windows.Forms.Label labelExtrasVendas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

