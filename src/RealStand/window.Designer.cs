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
            this.label1 = new System.Windows.Forms.Label();
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxClientesOficina = new System.Windows.Forms.ListBox();
            this.labelTituloOficina = new System.Windows.Forms.Label();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAluguer = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new RealStand.realstandDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RealStand.realstandDataSetTableAdapters.TableAdapterManager();
            nomeLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
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
            this.tabPageAluguer.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1082, 586);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.Color.Silver;
            this.tabPageInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageInicio.Controls.Add(this.label1);
            this.tabPageInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageInicio.Location = new System.Drawing.Point(166, 4);
            this.tabPageInicio.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Size = new System.Drawing.Size(912, 578);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Início";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Início";
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
            this.tabPageClientes.Size = new System.Drawing.Size(912, 578);
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
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
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
            this.nIFMaskedTextBox.Location = new System.Drawing.Point(65, 39);
            this.nIFMaskedTextBox.Mask = "000000000";
            this.nIFMaskedTextBox.Name = "nIFMaskedTextBox";
            this.nIFMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.nIFMaskedTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(65, 65);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(445, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // contactoMaskedTextBox
            // 
            this.contactoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Contacto", true));
            this.contactoMaskedTextBox.Location = new System.Drawing.Point(65, 91);
            this.contactoMaskedTextBox.Mask = "(99) 0000000";
            this.contactoMaskedTextBox.Name = "contactoMaskedTextBox";
            this.contactoMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.contactoMaskedTextBox.TabIndex = 7;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.clientesListBox.DataSource = this.clientesBindingSource;
            this.clientesListBox.DisplayMember = "Nome";
            this.clientesListBox.FormattingEnabled = true;
            this.clientesListBox.Location = new System.Drawing.Point(3, 76);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(378, 498);
            this.clientesListBox.TabIndex = 0;
            this.clientesListBox.ValueMember = "Id";
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
            this.tabPageOficina.Size = new System.Drawing.Size(912, 578);
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
            this.buttonRemoverParcelaOficina.TabIndex = 6;
            this.buttonRemoverParcelaOficina.Text = "Remover Parcela";
            this.buttonRemoverParcelaOficina.UseVisualStyleBackColor = true;
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
            this.buttonAdicionarParcelaOficina.TabIndex = 2;
            this.buttonAdicionarParcelaOficina.Text = "Adicionar Parcela";
            this.buttonAdicionarParcelaOficina.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxValorParcelaOficina
            // 
            this.maskedTextBoxValorParcelaOficina.Location = new System.Drawing.Point(46, 50);
            this.maskedTextBoxValorParcelaOficina.Mask = "€00000.00";
            this.maskedTextBoxValorParcelaOficina.Name = "maskedTextBoxValorParcelaOficina";
            this.maskedTextBoxValorParcelaOficina.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorParcelaOficina.TabIndex = 1;
            // 
            // textBoxDescricaoParcelaOficina
            // 
            this.textBoxDescricaoParcelaOficina.Location = new System.Drawing.Point(70, 23);
            this.textBoxDescricaoParcelaOficina.Multiline = true;
            this.textBoxDescricaoParcelaOficina.Name = "textBoxDescricaoParcelaOficina";
            this.textBoxDescricaoParcelaOficina.Size = new System.Drawing.Size(175, 20);
            this.textBoxDescricaoParcelaOficina.TabIndex = 0;
            // 
            // listBoxParcelasOficina
            // 
            this.listBoxParcelasOficina.FormattingEnabled = true;
            this.listBoxParcelasOficina.Location = new System.Drawing.Point(7, 46);
            this.listBoxParcelasOficina.Name = "listBoxParcelasOficina";
            this.listBoxParcelasOficina.Size = new System.Drawing.Size(237, 303);
            this.listBoxParcelasOficina.TabIndex = 0;
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
            this.buttonRemoverServicoOficina.TabIndex = 3;
            this.buttonRemoverServicoOficina.Text = "Remover Serviço";
            this.buttonRemoverServicoOficina.UseVisualStyleBackColor = true;
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
            this.dateTimePickerDataSaidaOficina.TabIndex = 18;
            // 
            // dateTimePickerDataEntregaOficina
            // 
            this.dateTimePickerDataEntregaOficina.Location = new System.Drawing.Point(97, 22);
            this.dateTimePickerDataEntregaOficina.Name = "dateTimePickerDataEntregaOficina";
            this.dateTimePickerDataEntregaOficina.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataEntregaOficina.TabIndex = 17;
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
            this.buttonAdicionarServicoOficina.TabIndex = 1;
            this.buttonAdicionarServicoOficina.Text = "Adicionar Serviço";
            this.buttonAdicionarServicoOficina.UseVisualStyleBackColor = true;
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
            this.comboBoxTipoServicosOficina.TabIndex = 0;
            // 
            // listBoxServicosOficina
            // 
            this.listBoxServicosOficina.FormattingEnabled = true;
            this.listBoxServicosOficina.Location = new System.Drawing.Point(7, 46);
            this.listBoxServicosOficina.Name = "listBoxServicosOficina";
            this.listBoxServicosOficina.Size = new System.Drawing.Size(211, 277);
            this.listBoxServicosOficina.TabIndex = 0;
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
            this.textBoxModeloOficina.TabIndex = 13;
            // 
            // textBoxMarcaOficina
            // 
            this.textBoxMarcaOficina.Location = new System.Drawing.Point(52, 96);
            this.textBoxMarcaOficina.Name = "textBoxMarcaOficina";
            this.textBoxMarcaOficina.Size = new System.Drawing.Size(137, 20);
            this.textBoxMarcaOficina.TabIndex = 12;
            // 
            // textBoxChassiOficina
            // 
            this.textBoxChassiOficina.Location = new System.Drawing.Point(72, 70);
            this.textBoxChassiOficina.Name = "textBoxChassiOficina";
            this.textBoxChassiOficina.Size = new System.Drawing.Size(117, 20);
            this.textBoxChassiOficina.TabIndex = 11;
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
            this.textBoxKMsOficina.TabIndex = 5;
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
            this.maskedTextBoxMatriculaOficina.TabIndex = 3;
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
            this.buttonAdicionarCarroOficina.TabIndex = 1;
            this.buttonAdicionarCarroOficina.Text = "Adicionar Carro";
            this.buttonAdicionarCarroOficina.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCarroOficina
            // 
            this.buttonRemoverCarroOficina.Location = new System.Drawing.Point(6, 17);
            this.buttonRemoverCarroOficina.Name = "buttonRemoverCarroOficina";
            this.buttonRemoverCarroOficina.Size = new System.Drawing.Size(183, 23);
            this.buttonRemoverCarroOficina.TabIndex = 2;
            this.buttonRemoverCarroOficina.Text = "Remover Carro";
            this.buttonRemoverCarroOficina.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(6, 46);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(183, 199);
            this.listBoxCarrosOficina.TabIndex = 0;
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
            this.groupBoxClientesOficina.Controls.Add(this.comboBox1);
            this.groupBoxClientesOficina.Controls.Add(this.textBox1);
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
            this.labelProcurarPorOficina.Location = new System.Drawing.Point(121, 21);
            this.labelProcurarPorOficina.Name = "labelProcurarPorOficina";
            this.labelProcurarPorOficina.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPorOficina.TabIndex = 4;
            this.labelProcurarPorOficina.Text = "Procurar por:";
            // 
            // labelTextoOficina
            // 
            this.labelTextoOficina.AutoSize = true;
            this.labelTextoOficina.Location = new System.Drawing.Point(4, 21);
            this.labelTextoOficina.Name = "labelTextoOficina";
            this.labelTextoOficina.Size = new System.Drawing.Size(37, 13);
            this.labelTextoOficina.TabIndex = 3;
            this.labelTextoOficina.Text = "Texto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBox1.Location = new System.Drawing.Point(123, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBoxClientesOficina
            // 
            this.listBoxClientesOficina.FormattingEnabled = true;
            this.listBoxClientesOficina.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesOficina.Name = "listBoxClientesOficina";
            this.listBoxClientesOficina.Size = new System.Drawing.Size(191, 446);
            this.listBoxClientesOficina.TabIndex = 0;
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
            this.tabPageVendas.Controls.Add(this.label4);
            this.tabPageVendas.Location = new System.Drawing.Point(166, 4);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Size = new System.Drawing.Size(912, 578);
            this.tabPageVendas.TabIndex = 3;
            this.tabPageVendas.Text = "Vendas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vendas";
            // 
            // tabPageAluguer
            // 
            this.tabPageAluguer.BackColor = System.Drawing.Color.Silver;
            this.tabPageAluguer.Controls.Add(this.label5);
            this.tabPageAluguer.Location = new System.Drawing.Point(166, 4);
            this.tabPageAluguer.Name = "tabPageAluguer";
            this.tabPageAluguer.Size = new System.Drawing.Size(912, 578);
            this.tabPageAluguer.TabIndex = 4;
            this.tabPageAluguer.Text = "Aluguer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aluguer";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPageInicio.PerformLayout();
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
            this.tabPageAluguer.ResumeLayout(false);
            this.tabPageAluguer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageOficina;
        private System.Windows.Forms.Label labelTituloOficina;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageAluguer;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

