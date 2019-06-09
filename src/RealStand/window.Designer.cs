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
            System.Windows.Forms.Label estadoLabel;
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
            this.buttonEmitirFaturaOficina = new System.Windows.Forms.Button();
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
            this.buttonFiltrarOficina = new System.Windows.Forms.Button();
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
            this.buttonEmitirFaturaVendas = new System.Windows.Forms.Button();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEmitirFaturaAluguer = new System.Windows.Forms.Button();
            this.buttonEditarAluguer = new System.Windows.Forms.Button();
            this.groupBoxAluguer = new System.Windows.Forms.GroupBox();
            this.buttonGuardarAluguer = new System.Windows.Forms.Button();
            this.maskedTextBoxValorAluguer = new System.Windows.Forms.MaskedTextBox();
            this.textBoxQuilometragemAluguer = new System.Windows.Forms.TextBox();
            this.labelQuilometragemAluguer = new System.Windows.Forms.Label();
            this.labelValorAluguer = new System.Windows.Forms.Label();
            this.dateTimePickerDataFimAluguer = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicioAluguer = new System.Windows.Forms.DateTimePicker();
            this.labelDataFimAluguer = new System.Windows.Forms.Label();
            this.labelDataInicioAluguer = new System.Windows.Forms.Label();
            this.buttonEliminarAluguer = new System.Windows.Forms.Button();
            this.buttonCriarAlguer = new System.Windows.Forms.Button();
            this.listBoxAluguer = new System.Windows.Forms.ListBox();
            this.groupBoxCarrosAluguer = new System.Windows.Forms.GroupBox();
            this.buttonEditarCarroAluguer = new System.Windows.Forms.Button();
            this.buttonEliminarCarroAluguer = new System.Windows.Forms.Button();
            this.groupBoxCarroAluguer = new System.Windows.Forms.GroupBox();
            this.numeroChassisMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.carros_CarroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardarCarroAluguer = new System.Windows.Forms.Button();
            this.textBoxModeloAluguer = new System.Windows.Forms.TextBox();
            this.textBoxMarcaAluguer = new System.Windows.Forms.TextBox();
            this.comboBoxCombustivelAluguer = new System.Windows.Forms.ComboBox();
            this.labelCombustivelAluguer = new System.Windows.Forms.Label();
            this.labelModeloAluguer = new System.Windows.Forms.Label();
            this.labelMarcaAluguer = new System.Windows.Forms.Label();
            this.labelNChassisAluguer = new System.Windows.Forms.Label();
            this.maskedTextBoxMatriculaAluguer = new System.Windows.Forms.MaskedTextBox();
            this.labelMatriculaAluguer = new System.Windows.Forms.Label();
            this.buttonCriarCarroAluguer = new System.Windows.Forms.Button();
            this.listBoxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAluguerFiltrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAluguerFiltrarPorCampo = new System.Windows.Forms.ComboBox();
            this.textBoxAluguerFiltrarPor = new System.Windows.Forms.TextBox();
            this.listBoxClientesAluguer = new System.Windows.Forms.ListBox();
            this.labelTituloAluguer = new System.Windows.Forms.Label();
            this.groupBoxFichaClienteVenda = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalGastoAluguer = new System.Windows.Forms.Label();
            this.labelNifClienteSelecionadoAluguer = new System.Windows.Forms.Label();
            this.labelClienteSelecionadoAluguer = new System.Windows.Forms.Label();
            this.labelNifAluguer = new System.Windows.Forms.Label();
            this.labelNomeAluguer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.clientesTableAdapter = new RealStand.realstandDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RealStand.realstandDataSetTableAdapters.TableAdapterManager();
            this.carros_CarroAluguerTableAdapter = new RealStand.realstandDataSetTableAdapters.Carros_CarroAluguerTableAdapter();
            this.carrosTableAdapter = new RealStand.realstandDataSetTableAdapters.CarrosTableAdapter();
            nomeLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
            this.groupBoxAluguer.SuspendLayout();
            this.groupBoxCarrosAluguer.SuspendLayout();
            this.groupBoxCarroAluguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carros_CarroAluguerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxFichaClienteVenda.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(34, 124);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 17;
            estadoLabel.Text = "Estado:";
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
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
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageClientes.Size = new System.Drawing.Size(912, 573);
            this.tabPageClientes.TabIndex = 1;
            this.tabPageClientes.Text = "Clientes";
            // 
            // buttonProcurarCliente
            // 
            this.buttonProcurarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonProcurarCliente.Image")));
            this.buttonProcurarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcurarCliente.Location = new System.Drawing.Point(357, 51);
            this.buttonProcurarCliente.Name = "buttonProcurarCliente";
            this.buttonProcurarCliente.Size = new System.Drawing.Size(75, 23);
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
            this.buttonCriarCliente.Location = new System.Drawing.Point(6, 9);
            this.buttonCriarCliente.Name = "buttonCriarCliente";
            this.buttonCriarCliente.Size = new System.Drawing.Size(75, 23);
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
            this.buttonEditarCliente.Location = new System.Drawing.Point(87, 9);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(75, 23);
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
            this.buttonApagarCliente.Location = new System.Drawing.Point(168, 9);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonApagarCliente.TabIndex = 9;
            this.buttonApagarCliente.Text = "Apagar";
            this.buttonApagarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            this.buttonApagarCliente.Click += new System.EventHandler(this.buttonApagarCliente_Click);
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
            this.comboBoxCampoProcura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampoProcura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCampoProcura.FormattingEnabled = true;
            this.comboBoxCampoProcura.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxCampoProcura.Location = new System.Drawing.Point(232, 53);
            this.comboBoxCampoProcura.Name = "comboBoxCampoProcura";
            this.comboBoxCampoProcura.Size = new System.Drawing.Size(119, 21);
            this.comboBoxCampoProcura.TabIndex = 5;
            // 
            // textBoxClienteProcurarPor
            // 
            this.textBoxClienteProcurarPor.Location = new System.Drawing.Point(3, 53);
            this.textBoxClienteProcurarPor.Name = "textBoxClienteProcurarPor";
            this.textBoxClienteProcurarPor.Size = new System.Drawing.Size(223, 20);
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
            this.groupBoxDadosClientes.Location = new System.Drawing.Point(438, 76);
            this.groupBoxDadosClientes.Name = "groupBoxDadosClientes";
            this.groupBoxDadosClientes.Size = new System.Drawing.Size(465, 150);
            this.groupBoxDadosClientes.TabIndex = 3;
            this.groupBoxDadosClientes.TabStop = false;
            this.groupBoxDadosClientes.Text = "Dados";
            // 
            // buttonGravarCliente
            // 
            this.buttonGravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravarCliente.Image")));
            this.buttonGravarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGravarCliente.Location = new System.Drawing.Point(384, 121);
            this.buttonGravarCliente.Name = "buttonGravarCliente";
            this.buttonGravarCliente.Size = new System.Drawing.Size(75, 23);
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
            this.nomeTextBox.Location = new System.Drawing.Point(65, 13);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(394, 20);
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
            this.moradaTextBox.Size = new System.Drawing.Size(394, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // contactoMaskedTextBox
            // 
            this.contactoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Contacto", true));
            this.contactoMaskedTextBox.Enabled = false;
            this.contactoMaskedTextBox.Location = new System.Drawing.Point(65, 91);
            this.contactoMaskedTextBox.Mask = "000000000";
            this.contactoMaskedTextBox.Name = "contactoMaskedTextBox";
            this.contactoMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.contactoMaskedTextBox.TabIndex = 7;
            // 
            // clientesListBox
            // 
            this.clientesListBox.FormattingEnabled = true;
            this.clientesListBox.Location = new System.Drawing.Point(3, 76);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(429, 485);
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
            this.buttonRemoverParcelaOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverParcelaOficina.Image")));
            this.buttonRemoverParcelaOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonAdicionarParcelaOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarParcelaOficina.Image")));
            this.buttonAdicionarParcelaOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.maskedTextBoxValorParcelaOficina.Mask = "€000000.00";
            this.maskedTextBoxValorParcelaOficina.Name = "maskedTextBoxValorParcelaOficina";
            this.maskedTextBoxValorParcelaOficina.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorParcelaOficina.TabIndex = 21;
            this.maskedTextBoxValorParcelaOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.listBoxParcelasOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxParcelasOficina.FormattingEnabled = true;
            this.listBoxParcelasOficina.Location = new System.Drawing.Point(7, 46);
            this.listBoxParcelasOficina.Name = "listBoxParcelasOficina";
            this.listBoxParcelasOficina.Size = new System.Drawing.Size(237, 290);
            this.listBoxParcelasOficina.TabIndex = 19;
            this.listBoxParcelasOficina.Click += new System.EventHandler(this.listBoxParcelasOficina_Click);
            // 
            // groupBoxServicosOficina
            // 
            this.groupBoxServicosOficina.Controls.Add(this.buttonEmitirFaturaOficina);
            this.groupBoxServicosOficina.Controls.Add(this.buttonRemoverServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.buttonCriarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.buttonEditarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.groupBoxCriarServicoOficina);
            this.groupBoxServicosOficina.Controls.Add(this.listBoxServicosOficina);
            this.groupBoxServicosOficina.Location = new System.Drawing.Point(420, 114);
            this.groupBoxServicosOficina.Name = "groupBoxServicosOficina";
            this.groupBoxServicosOficina.Size = new System.Drawing.Size(224, 456);
            this.groupBoxServicosOficina.TabIndex = 3;
            this.groupBoxServicosOficina.TabStop = false;
            this.groupBoxServicosOficina.Text = "Serviços";
            // 
            // buttonEmitirFaturaOficina
            // 
            this.buttonEmitirFaturaOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmitirFaturaOficina.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEmitirFaturaOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmitirFaturaOficina.Image")));
            this.buttonEmitirFaturaOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmitirFaturaOficina.Location = new System.Drawing.Point(9, 283);
            this.buttonEmitirFaturaOficina.Name = "buttonEmitirFaturaOficina";
            this.buttonEmitirFaturaOficina.Size = new System.Drawing.Size(208, 30);
            this.buttonEmitirFaturaOficina.TabIndex = 15;
            this.buttonEmitirFaturaOficina.Text = "Emitir fatura";
            this.buttonEmitirFaturaOficina.UseVisualStyleBackColor = true;
            this.buttonEmitirFaturaOficina.Click += new System.EventHandler(this.buttonEmitirFaturaOficina_Click);
            // 
            // buttonRemoverServicoOficina
            // 
            this.buttonRemoverServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverServicoOficina.Image")));
            this.buttonRemoverServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverServicoOficina.Location = new System.Drawing.Point(9, 75);
            this.buttonRemoverServicoOficina.Name = "buttonRemoverServicoOficina";
            this.buttonRemoverServicoOficina.Size = new System.Drawing.Size(208, 23);
            this.buttonRemoverServicoOficina.TabIndex = 14;
            this.buttonRemoverServicoOficina.Text = "Apagar";
            this.buttonRemoverServicoOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverServicoOficina.Click += new System.EventHandler(this.buttonRemoverServicoOficina_Click);
            // 
            // buttonCriarServicoOficina
            // 
            this.buttonCriarServicoOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCriarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarServicoOficina.Image")));
            this.buttonCriarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCriarServicoOficina.Location = new System.Drawing.Point(9, 17);
            this.buttonCriarServicoOficina.Name = "buttonCriarServicoOficina";
            this.buttonCriarServicoOficina.Size = new System.Drawing.Size(208, 23);
            this.buttonCriarServicoOficina.TabIndex = 14;
            this.buttonCriarServicoOficina.Text = "Criar";
            this.buttonCriarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonCriarServicoOficina.Click += new System.EventHandler(this.buttonCriarServicoOficina_Click);
            // 
            // buttonEditarServicoOficina
            // 
            this.buttonEditarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarServicoOficina.Image")));
            this.buttonEditarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarServicoOficina.Location = new System.Drawing.Point(9, 46);
            this.buttonEditarServicoOficina.Name = "buttonEditarServicoOficina";
            this.buttonEditarServicoOficina.Size = new System.Drawing.Size(208, 23);
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
            this.groupBoxCriarServicoOficina.Location = new System.Drawing.Point(0, 321);
            this.groupBoxCriarServicoOficina.Name = "groupBoxCriarServicoOficina";
            this.groupBoxCriarServicoOficina.Size = new System.Drawing.Size(224, 135);
            this.groupBoxCriarServicoOficina.TabIndex = 1;
            this.groupBoxCriarServicoOficina.TabStop = false;
            this.groupBoxCriarServicoOficina.Text = "Criar / Editar Serviço";
            // 
            // buttonGuardarServicoOficina
            // 
            this.buttonGuardarServicoOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarServicoOficina.Image")));
            this.buttonGuardarServicoOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarServicoOficina.Location = new System.Drawing.Point(7, 105);
            this.buttonGuardarServicoOficina.Name = "buttonGuardarServicoOficina";
            this.buttonGuardarServicoOficina.Size = new System.Drawing.Size(210, 23);
            this.buttonGuardarServicoOficina.TabIndex = 15;
            this.buttonGuardarServicoOficina.Text = "Guardar";
            this.buttonGuardarServicoOficina.UseVisualStyleBackColor = true;
            this.buttonGuardarServicoOficina.Click += new System.EventHandler(this.buttonGuardarServicoOficina_Click);
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
            // comboBoxTipoServicosOficina
            // 
            this.comboBoxTipoServicosOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.listBoxServicosOficina.Location = new System.Drawing.Point(9, 104);
            this.listBoxServicosOficina.Name = "listBoxServicosOficina";
            this.listBoxServicosOficina.Size = new System.Drawing.Size(208, 173);
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
            this.groupBoxCarrosOficina.Location = new System.Drawing.Point(219, 114);
            this.groupBoxCarrosOficina.Name = "groupBoxCarrosOficina";
            this.groupBoxCarrosOficina.Size = new System.Drawing.Size(195, 456);
            this.groupBoxCarrosOficina.TabIndex = 2;
            this.groupBoxCarrosOficina.TabStop = false;
            this.groupBoxCarrosOficina.Text = "Carros";
            // 
            // buttonEditarCarroOficina
            // 
            this.buttonEditarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCarroOficina.Image")));
            this.buttonEditarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCarroOficina.Location = new System.Drawing.Point(5, 46);
            this.buttonEditarCarroOficina.Name = "buttonEditarCarroOficina";
            this.buttonEditarCarroOficina.Size = new System.Drawing.Size(183, 23);
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
            this.groupBoxCriarCarroOficina.Location = new System.Drawing.Point(0, 253);
            this.groupBoxCriarCarroOficina.Name = "groupBoxCriarCarroOficina";
            this.groupBoxCriarCarroOficina.Size = new System.Drawing.Size(195, 203);
            this.groupBoxCriarCarroOficina.TabIndex = 3;
            this.groupBoxCriarCarroOficina.TabStop = false;
            this.groupBoxCriarCarroOficina.Text = "Criar / Editar Carro";
            // 
            // maskedTextBoxChassiOficina
            // 
            this.maskedTextBoxChassiOficina.Location = new System.Drawing.Point(66, 71);
            this.maskedTextBoxChassiOficina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxChassiOficina.Mask = "00000000000000000";
            this.maskedTextBoxChassiOficina.Name = "maskedTextBoxChassiOficina";
            this.maskedTextBoxChassiOficina.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxChassiOficina.TabIndex = 15;
            this.maskedTextBoxChassiOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuardarCarroOficina
            // 
            this.buttonGuardarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarCarroOficina.Image")));
            this.buttonGuardarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarCarroOficina.Location = new System.Drawing.Point(6, 173);
            this.buttonGuardarCarroOficina.Name = "buttonGuardarCarroOficina";
            this.buttonGuardarCarroOficina.Size = new System.Drawing.Size(183, 23);
            this.buttonGuardarCarroOficina.TabIndex = 14;
            this.buttonGuardarCarroOficina.Text = "Guardar";
            this.buttonGuardarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonGuardarCarroOficina.Click += new System.EventHandler(this.buttonGuardarCarroOficina_Click);
            // 
            // numericUpDownKMsOficina
            // 
            this.numericUpDownKMsOficina.Location = new System.Drawing.Point(95, 44);
            this.numericUpDownKMsOficina.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numericUpDownKMsOficina.Name = "numericUpDownKMsOficina";
            this.numericUpDownKMsOficina.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownKMsOficina.TabIndex = 12;
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
            this.labelNChassisOficina.Size = new System.Drawing.Size(56, 13);
            this.labelNChassisOficina.TabIndex = 6;
            this.labelNChassisOficina.Text = "Nº Chassi:";
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
            // buttonRemoverCarroOficina
            // 
            this.buttonRemoverCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverCarroOficina.Image")));
            this.buttonRemoverCarroOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverCarroOficina.Location = new System.Drawing.Point(5, 75);
            this.buttonRemoverCarroOficina.Name = "buttonRemoverCarroOficina";
            this.buttonRemoverCarroOficina.Size = new System.Drawing.Size(183, 23);
            this.buttonRemoverCarroOficina.TabIndex = 12;
            this.buttonRemoverCarroOficina.Text = "Apagar";
            this.buttonRemoverCarroOficina.UseVisualStyleBackColor = true;
            this.buttonRemoverCarroOficina.Click += new System.EventHandler(this.buttonRemoverCarroOficina_Click);
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(6, 104);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.ScrollAlwaysVisible = true;
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(183, 147);
            this.listBoxCarrosOficina.TabIndex = 4;
            this.listBoxCarrosOficina.Click += new System.EventHandler(this.listBoxCarrosOficina_Click);
            // 
            // buttonCriarCarroOficina
            // 
            this.buttonCriarCarroOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCriarCarroOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarCarroOficina.Image")));
            this.buttonCriarCarroOficina.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCriarCarroOficina.Location = new System.Drawing.Point(5, 17);
            this.buttonCriarCarroOficina.Name = "buttonCriarCarroOficina";
            this.buttonCriarCarroOficina.Size = new System.Drawing.Size(183, 23);
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
            this.groupBoxFichaClienteOficina.Location = new System.Drawing.Point(219, 8);
            this.groupBoxFichaClienteOficina.Name = "groupBoxFichaClienteOficina";
            this.groupBoxFichaClienteOficina.Size = new System.Drawing.Size(681, 100);
            this.groupBoxFichaClienteOficina.TabIndex = 2;
            this.groupBoxFichaClienteOficina.TabStop = false;
            this.groupBoxFichaClienteOficina.Text = "Ficha do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalGastoOficina);
            this.groupBox1.Controls.Add(this.labelTotalClienteOficina);
            this.groupBox1.Location = new System.Drawing.Point(553, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(128, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalGastoOficina
            // 
            this.labelTotalGastoOficina.AutoSize = true;
            this.labelTotalGastoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGastoOficina.Location = new System.Drawing.Point(36, 27);
            this.labelTotalGastoOficina.Name = "labelTotalGastoOficina";
            this.labelTotalGastoOficina.Size = new System.Drawing.Size(86, 18);
            this.labelTotalGastoOficina.TabIndex = 4;
            this.labelTotalGastoOficina.Text = "Total gasto:";
            // 
            // labelTotalClienteOficina
            // 
            this.labelTotalClienteOficina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalClienteOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelTotalClienteOficina.ForeColor = System.Drawing.Color.Brown;
            this.labelTotalClienteOficina.Location = new System.Drawing.Point(15, 60);
            this.labelTotalClienteOficina.Name = "labelTotalClienteOficina";
            this.labelTotalClienteOficina.Size = new System.Drawing.Size(100, 20);
            this.labelTotalClienteOficina.TabIndex = 5;
            this.labelTotalClienteOficina.Text = "000,00€";
            this.labelTotalClienteOficina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.groupBoxClientesOficina.Controls.Add(this.buttonFiltrarOficina);
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
            // buttonFiltrarOficina
            // 
            this.buttonFiltrarOficina.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltrarOficina.Image")));
            this.buttonFiltrarOficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltrarOficina.Location = new System.Drawing.Point(143, 37);
            this.buttonFiltrarOficina.Name = "buttonFiltrarOficina";
            this.buttonFiltrarOficina.Size = new System.Drawing.Size(53, 23);
            this.buttonFiltrarOficina.TabIndex = 6;
            this.buttonFiltrarOficina.Text = "Filtrar";
            this.buttonFiltrarOficina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFiltrarOficina.UseVisualStyleBackColor = true;
            this.buttonFiltrarOficina.Click += new System.EventHandler(this.buttonFiltrarOficina_Click);
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
            this.labelTextoOficina.Location = new System.Drawing.Point(83, 24);
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
            this.comboBoxCampoOficina.Location = new System.Drawing.Point(86, 38);
            this.comboBoxCampoOficina.Name = "comboBoxCampoOficina";
            this.comboBoxCampoOficina.Size = new System.Drawing.Size(53, 21);
            this.comboBoxCampoOficina.TabIndex = 2;
            // 
            // textBoxProcurarPorOficina
            // 
            this.textBoxProcurarPorOficina.Location = new System.Drawing.Point(7, 40);
            this.textBoxProcurarPorOficina.Name = "textBoxProcurarPorOficina";
            this.textBoxProcurarPorOficina.Size = new System.Drawing.Size(74, 20);
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
            this.tabPageVendas.Controls.Add(this.groupBoxDetalhesVendaECarroVendas);
            this.tabPageVendas.Controls.Add(this.groupBoxVendasCliente);
            this.tabPageVendas.Controls.Add(this.groupBoxListaClientesVendas);
            this.tabPageVendas.Controls.Add(this.labelTituloVendas);
            this.tabPageVendas.Controls.Add(this.groupBoxFichaClienteVendas);
            this.tabPageVendas.Location = new System.Drawing.Point(166, 4);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Size = new System.Drawing.Size(912, 573);
            this.tabPageVendas.TabIndex = 3;
            this.tabPageVendas.Text = "Vendas";
            // 
            // groupBoxDetalhesVendaECarroVendas
            // 
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.groupBoxDetalhesCarroVenda);
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.groupBoxDetalhesDaVenda);
            this.groupBoxDetalhesVendaECarroVendas.Controls.Add(this.buttonGuardarVendas);
            this.groupBoxDetalhesVendaECarroVendas.Location = new System.Drawing.Point(672, 114);
            this.groupBoxDetalhesVendaECarroVendas.Name = "groupBoxDetalhesVendaECarroVendas";
            this.groupBoxDetalhesVendaECarroVendas.Size = new System.Drawing.Size(228, 456);
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
            this.groupBoxDetalhesCarroVenda.Location = new System.Drawing.Point(6, 19);
            this.groupBoxDetalhesCarroVenda.Name = "groupBoxDetalhesCarroVenda";
            this.groupBoxDetalhesCarroVenda.Size = new System.Drawing.Size(216, 216);
            this.groupBoxDetalhesCarroVenda.TabIndex = 30;
            this.groupBoxDetalhesCarroVenda.TabStop = false;
            this.groupBoxDetalhesCarroVenda.Text = "Detalhes do carro";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 32);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Mask = "00000000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(136, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNChassis
            // 
            this.labelNChassis.AutoSize = true;
            this.labelNChassis.Location = new System.Drawing.Point(6, 35);
            this.labelNChassis.Name = "labelNChassis";
            this.labelNChassis.Size = new System.Drawing.Size(56, 13);
            this.labelNChassis.TabIndex = 6;
            this.labelNChassis.Text = "Nº Chassi:";
            // 
            // labelCombustivelVendas
            // 
            this.labelCombustivelVendas.AutoSize = true;
            this.labelCombustivelVendas.Location = new System.Drawing.Point(6, 145);
            this.labelCombustivelVendas.Name = "labelCombustivelVendas";
            this.labelCombustivelVendas.Size = new System.Drawing.Size(69, 13);
            this.labelCombustivelVendas.TabIndex = 9;
            this.labelCombustivelVendas.Text = "Combustível:";
            // 
            // textBoxExtrasVendas
            // 
            this.textBoxExtrasVendas.Location = new System.Drawing.Point(48, 182);
            this.textBoxExtrasVendas.Multiline = true;
            this.textBoxExtrasVendas.Name = "textBoxExtrasVendas";
            this.textBoxExtrasVendas.Size = new System.Drawing.Size(161, 20);
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
            this.comboBoxCombustivelVendas.Location = new System.Drawing.Point(81, 145);
            this.comboBoxCombustivelVendas.Name = "comboBoxCombustivelVendas";
            this.comboBoxCombustivelVendas.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCombustivelVendas.TabIndex = 10;
            // 
            // labelModeloVendas
            // 
            this.labelModeloVendas.AutoSize = true;
            this.labelModeloVendas.Location = new System.Drawing.Point(6, 111);
            this.labelModeloVendas.Name = "labelModeloVendas";
            this.labelModeloVendas.Size = new System.Drawing.Size(45, 13);
            this.labelModeloVendas.TabIndex = 8;
            this.labelModeloVendas.Text = "Modelo:";
            // 
            // labelExtrasVendas
            // 
            this.labelExtrasVendas.AutoSize = true;
            this.labelExtrasVendas.Location = new System.Drawing.Point(6, 185);
            this.labelExtrasVendas.Name = "labelExtrasVendas";
            this.labelExtrasVendas.Size = new System.Drawing.Size(36, 13);
            this.labelExtrasVendas.TabIndex = 14;
            this.labelExtrasVendas.Text = "Extas:";
            // 
            // textBoxModeloVendas
            // 
            this.textBoxModeloVendas.Location = new System.Drawing.Point(58, 108);
            this.textBoxModeloVendas.Name = "textBoxModeloVendas";
            this.textBoxModeloVendas.Size = new System.Drawing.Size(152, 20);
            this.textBoxModeloVendas.TabIndex = 13;
            // 
            // labelMarcaVendas
            // 
            this.labelMarcaVendas.AutoSize = true;
            this.labelMarcaVendas.Location = new System.Drawing.Point(6, 71);
            this.labelMarcaVendas.Name = "labelMarcaVendas";
            this.labelMarcaVendas.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaVendas.TabIndex = 7;
            this.labelMarcaVendas.Text = "Marca:";
            // 
            // textBoxMarcaVendas
            // 
            this.textBoxMarcaVendas.Location = new System.Drawing.Point(53, 68);
            this.textBoxMarcaVendas.Name = "textBoxMarcaVendas";
            this.textBoxMarcaVendas.Size = new System.Drawing.Size(155, 20);
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
            this.groupBoxDetalhesDaVenda.Location = new System.Drawing.Point(6, 250);
            this.groupBoxDetalhesDaVenda.Name = "groupBoxDetalhesDaVenda";
            this.groupBoxDetalhesDaVenda.Size = new System.Drawing.Size(216, 138);
            this.groupBoxDetalhesDaVenda.TabIndex = 29;
            this.groupBoxDetalhesDaVenda.TabStop = false;
            this.groupBoxDetalhesDaVenda.Text = "Detalhes de venda";
            // 
            // labelDataVendaVendas
            // 
            this.labelDataVendaVendas.AutoSize = true;
            this.labelDataVendaVendas.Location = new System.Drawing.Point(6, 30);
            this.labelDataVendaVendas.Name = "labelDataVendaVendas";
            this.labelDataVendaVendas.Size = new System.Drawing.Size(82, 13);
            this.labelDataVendaVendas.TabIndex = 20;
            this.labelDataVendaVendas.Text = "Data de Venda:";
            // 
            // maskedTextBoxValorVenda
            // 
            this.maskedTextBoxValorVenda.Location = new System.Drawing.Point(114, 99);
            this.maskedTextBoxValorVenda.Mask = "€0000000.00";
            this.maskedTextBoxValorVenda.Name = "maskedTextBoxValorVenda";
            this.maskedTextBoxValorVenda.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBoxValorVenda.TabIndex = 28;
            this.maskedTextBoxValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelValorVendas
            // 
            this.labelValorVendas.AutoSize = true;
            this.labelValorVendas.Location = new System.Drawing.Point(6, 102);
            this.labelValorVendas.Name = "labelValorVendas";
            this.labelValorVendas.Size = new System.Drawing.Size(83, 13);
            this.labelValorVendas.TabIndex = 25;
            this.labelValorVendas.Text = "Valor da Venda:";
            // 
            // labelEstadoVendas
            // 
            this.labelEstadoVendas.AutoSize = true;
            this.labelEstadoVendas.Location = new System.Drawing.Point(6, 68);
            this.labelEstadoVendas.Name = "labelEstadoVendas";
            this.labelEstadoVendas.Size = new System.Drawing.Size(46, 13);
            this.labelEstadoVendas.TabIndex = 26;
            this.labelEstadoVendas.Text = "Estado: ";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(94, 23);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerDataVenda.TabIndex = 23;
            // 
            // textBoxEstadoVendas
            // 
            this.textBoxEstadoVendas.Location = new System.Drawing.Point(72, 64);
            this.textBoxEstadoVendas.Name = "textBoxEstadoVendas";
            this.textBoxEstadoVendas.Size = new System.Drawing.Size(138, 20);
            this.textBoxEstadoVendas.TabIndex = 27;
            // 
            // buttonGuardarVendas
            // 
            this.buttonGuardarVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarVendas.Image")));
            this.buttonGuardarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarVendas.Location = new System.Drawing.Point(6, 402);
            this.buttonGuardarVendas.Name = "buttonGuardarVendas";
            this.buttonGuardarVendas.Size = new System.Drawing.Size(216, 46);
            this.buttonGuardarVendas.TabIndex = 16;
            this.buttonGuardarVendas.Text = "Guardar";
            this.buttonGuardarVendas.UseVisualStyleBackColor = true;
            this.buttonGuardarVendas.Click += new System.EventHandler(this.buttonGuardarVendas_Click);
            // 
            // groupBoxVendasCliente
            // 
            this.groupBoxVendasCliente.Controls.Add(this.buttonEmitirFaturaVendas);
            this.groupBoxVendasCliente.Controls.Add(this.buttonEditarVenda);
            this.groupBoxVendasCliente.Controls.Add(this.buttonAnularVenda);
            this.groupBoxVendasCliente.Controls.Add(this.buttonCriarVenda);
            this.groupBoxVendasCliente.Controls.Add(this.listBoxVendasDoCliente);
            this.groupBoxVendasCliente.Location = new System.Drawing.Point(367, 114);
            this.groupBoxVendasCliente.Name = "groupBoxVendasCliente";
            this.groupBoxVendasCliente.Size = new System.Drawing.Size(264, 456);
            this.groupBoxVendasCliente.TabIndex = 35;
            this.groupBoxVendasCliente.TabStop = false;
            this.groupBoxVendasCliente.Text = "Vendas do cliente";
            // 
            // buttonEmitirFaturaVendas
            // 
            this.buttonEmitirFaturaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmitirFaturaVendas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEmitirFaturaVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmitirFaturaVendas.Image")));
            this.buttonEmitirFaturaVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmitirFaturaVendas.Location = new System.Drawing.Point(6, 418);
            this.buttonEmitirFaturaVendas.Name = "buttonEmitirFaturaVendas";
            this.buttonEmitirFaturaVendas.Size = new System.Drawing.Size(251, 30);
            this.buttonEmitirFaturaVendas.TabIndex = 31;
            this.buttonEmitirFaturaVendas.Text = "Emitir fatura";
            this.buttonEmitirFaturaVendas.UseVisualStyleBackColor = true;
            this.buttonEmitirFaturaVendas.Click += new System.EventHandler(this.buttonEmitirFaturaVendas_Click);
            // 
            // buttonEditarVenda
            // 
            this.buttonEditarVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarVenda.Image")));
            this.buttonEditarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarVenda.Location = new System.Drawing.Point(6, 51);
            this.buttonEditarVenda.Name = "buttonEditarVenda";
            this.buttonEditarVenda.Size = new System.Drawing.Size(252, 26);
            this.buttonEditarVenda.TabIndex = 30;
            this.buttonEditarVenda.Text = "Editar venda";
            this.buttonEditarVenda.UseVisualStyleBackColor = true;
            this.buttonEditarVenda.Click += new System.EventHandler(this.buttonEditarVenda_Click);
            // 
            // buttonAnularVenda
            // 
            this.buttonAnularVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnularVenda.Image")));
            this.buttonAnularVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnularVenda.Location = new System.Drawing.Point(6, 83);
            this.buttonAnularVenda.Name = "buttonAnularVenda";
            this.buttonAnularVenda.Size = new System.Drawing.Size(252, 26);
            this.buttonAnularVenda.TabIndex = 1;
            this.buttonAnularVenda.Text = "Anular venda";
            this.buttonAnularVenda.UseVisualStyleBackColor = true;
            this.buttonAnularVenda.Click += new System.EventHandler(this.buttonAnularVenda_Click);
            // 
            // buttonCriarVenda
            // 
            this.buttonCriarVenda.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarVenda.Image")));
            this.buttonCriarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCriarVenda.Location = new System.Drawing.Point(6, 19);
            this.buttonCriarVenda.Name = "buttonCriarVenda";
            this.buttonCriarVenda.Size = new System.Drawing.Size(252, 26);
            this.buttonCriarVenda.TabIndex = 17;
            this.buttonCriarVenda.Text = "Criar venda";
            this.buttonCriarVenda.UseVisualStyleBackColor = true;
            this.buttonCriarVenda.Click += new System.EventHandler(this.buttonCriarVenda_Click);
            // 
            // listBoxVendasDoCliente
            // 
            this.listBoxVendasDoCliente.FormattingEnabled = true;
            this.listBoxVendasDoCliente.Location = new System.Drawing.Point(6, 120);
            this.listBoxVendasDoCliente.Name = "listBoxVendasDoCliente";
            this.listBoxVendasDoCliente.ScrollAlwaysVisible = true;
            this.listBoxVendasDoCliente.Size = new System.Drawing.Size(252, 290);
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
            this.groupBoxListaClientesVendas.Location = new System.Drawing.Point(9, 48);
            this.groupBoxListaClientesVendas.Name = "groupBoxListaClientesVendas";
            this.groupBoxListaClientesVendas.Size = new System.Drawing.Size(317, 522);
            this.groupBoxListaClientesVendas.TabIndex = 34;
            this.groupBoxListaClientesVendas.TabStop = false;
            this.groupBoxListaClientesVendas.Text = "Lista de Clientes";
            // 
            // buttonFiltarVendas
            // 
            this.buttonFiltarVendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltarVendas.Image")));
            this.buttonFiltarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiltarVendas.Location = new System.Drawing.Point(246, 38);
            this.buttonFiltarVendas.Name = "buttonFiltarVendas";
            this.buttonFiltarVendas.Size = new System.Drawing.Size(65, 23);
            this.buttonFiltarVendas.TabIndex = 5;
            this.buttonFiltarVendas.Text = "Filtrar";
            this.buttonFiltarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFiltarVendas.UseVisualStyleBackColor = true;
            this.buttonFiltarVendas.Click += new System.EventHandler(this.buttonFiltarVendas_Click);
            // 
            // labelProcurarPorVendas
            // 
            this.labelProcurarPorVendas.AutoSize = true;
            this.labelProcurarPorVendas.Location = new System.Drawing.Point(6, 24);
            this.labelProcurarPorVendas.Name = "labelProcurarPorVendas";
            this.labelProcurarPorVendas.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPorVendas.TabIndex = 4;
            this.labelProcurarPorVendas.Text = "Procurar por:";
            // 
            // labelCampoVendas
            // 
            this.labelCampoVendas.AutoSize = true;
            this.labelCampoVendas.Location = new System.Drawing.Point(162, 23);
            this.labelCampoVendas.Name = "labelCampoVendas";
            this.labelCampoVendas.Size = new System.Drawing.Size(43, 13);
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
            this.comboBoxCampoVendas.Location = new System.Drawing.Point(165, 39);
            this.comboBoxCampoVendas.Name = "comboBoxCampoVendas";
            this.comboBoxCampoVendas.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCampoVendas.TabIndex = 2;
            // 
            // textBoxProcurarPorVendas
            // 
            this.textBoxProcurarPorVendas.Location = new System.Drawing.Point(7, 40);
            this.textBoxProcurarPorVendas.Name = "textBoxProcurarPorVendas";
            this.textBoxProcurarPorVendas.Size = new System.Drawing.Size(152, 20);
            this.textBoxProcurarPorVendas.TabIndex = 1;
            // 
            // listBoxClientesVendas
            // 
            this.listBoxClientesVendas.FormattingEnabled = true;
            this.listBoxClientesVendas.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesVendas.Name = "listBoxClientesVendas";
            this.listBoxClientesVendas.ScrollAlwaysVisible = true;
            this.listBoxClientesVendas.Size = new System.Drawing.Size(304, 446);
            this.listBoxClientesVendas.TabIndex = 3;
            this.listBoxClientesVendas.Click += new System.EventHandler(this.listBoxClientesVendas_Click);
            // 
            // labelTituloVendas
            // 
            this.labelTituloVendas.AutoSize = true;
            this.labelTituloVendas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloVendas.ForeColor = System.Drawing.Color.Chocolate;
            this.labelTituloVendas.Location = new System.Drawing.Point(10, 8);
            this.labelTituloVendas.Name = "labelTituloVendas";
            this.labelTituloVendas.Size = new System.Drawing.Size(114, 32);
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
            this.groupBoxFichaClienteVendas.Location = new System.Drawing.Point(332, 8);
            this.groupBoxFichaClienteVendas.Name = "groupBoxFichaClienteVendas";
            this.groupBoxFichaClienteVendas.Size = new System.Drawing.Size(568, 100);
            this.groupBoxFichaClienteVendas.TabIndex = 32;
            this.groupBoxFichaClienteVendas.TabStop = false;
            this.groupBoxFichaClienteVendas.Text = "Ficha do Cliente";
            // 
            // groupBoxTotalVendas
            // 
            this.groupBoxTotalVendas.Controls.Add(this.label5);
            this.groupBoxTotalVendas.Controls.Add(this.labelTotalVendas);
            this.groupBoxTotalVendas.Location = new System.Drawing.Point(440, 0);
            this.groupBoxTotalVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTotalVendas.Name = "groupBoxTotalVendas";
            this.groupBoxTotalVendas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTotalVendas.Size = new System.Drawing.Size(128, 100);
            this.groupBoxTotalVendas.TabIndex = 7;
            this.groupBoxTotalVendas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total gasto:";
            // 
            // labelTotalVendas
            // 
            this.labelTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVendas.ForeColor = System.Drawing.Color.Chocolate;
            this.labelTotalVendas.Location = new System.Drawing.Point(4, 60);
            this.labelTotalVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalVendas.Name = "labelTotalVendas";
            this.labelTotalVendas.Size = new System.Drawing.Size(111, 20);
            this.labelTotalVendas.TabIndex = 4;
            this.labelTotalVendas.Text = "00 000 000,00€";
            this.labelTotalVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tabPageAluguer.AutoScroll = true;
            this.tabPageAluguer.BackColor = System.Drawing.Color.Silver;
            this.tabPageAluguer.Controls.Add(this.groupBox3);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEmitirFaturaAluguer);
            this.groupBox3.Controls.Add(this.buttonEditarAluguer);
            this.groupBox3.Controls.Add(this.groupBoxAluguer);
            this.groupBox3.Controls.Add(this.buttonEliminarAluguer);
            this.groupBox3.Controls.Add(this.buttonCriarAlguer);
            this.groupBox3.Controls.Add(this.listBoxAluguer);
            this.groupBox3.Location = new System.Drawing.Point(658, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 460);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aluguer";
            // 
            // buttonEmitirFaturaAluguer
            // 
            this.buttonEmitirFaturaAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmitirFaturaAluguer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEmitirFaturaAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmitirFaturaAluguer.Image")));
            this.buttonEmitirFaturaAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmitirFaturaAluguer.Location = new System.Drawing.Point(6, 266);
            this.buttonEmitirFaturaAluguer.Name = "buttonEmitirFaturaAluguer";
            this.buttonEmitirFaturaAluguer.Size = new System.Drawing.Size(228, 30);
            this.buttonEmitirFaturaAluguer.TabIndex = 34;
            this.buttonEmitirFaturaAluguer.Text = "Emitir fatura";
            this.buttonEmitirFaturaAluguer.UseVisualStyleBackColor = true;
            this.buttonEmitirFaturaAluguer.Click += new System.EventHandler(this.buttonEmitirFaturaAluguer_Click);
            // 
            // buttonEditarAluguer
            // 
            this.buttonEditarAluguer.Enabled = false;
            this.buttonEditarAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarAluguer.Image")));
            this.buttonEditarAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarAluguer.Location = new System.Drawing.Point(6, 48);
            this.buttonEditarAluguer.Name = "buttonEditarAluguer";
            this.buttonEditarAluguer.Size = new System.Drawing.Size(228, 26);
            this.buttonEditarAluguer.TabIndex = 33;
            this.buttonEditarAluguer.Text = "Editar Aluguer";
            this.buttonEditarAluguer.UseVisualStyleBackColor = true;
            this.buttonEditarAluguer.Click += new System.EventHandler(this.buttonEditarAluguer_Click);
            // 
            // groupBoxAluguer
            // 
            this.groupBoxAluguer.Controls.Add(this.buttonGuardarAluguer);
            this.groupBoxAluguer.Controls.Add(this.maskedTextBoxValorAluguer);
            this.groupBoxAluguer.Controls.Add(this.textBoxQuilometragemAluguer);
            this.groupBoxAluguer.Controls.Add(this.labelQuilometragemAluguer);
            this.groupBoxAluguer.Controls.Add(this.labelValorAluguer);
            this.groupBoxAluguer.Controls.Add(this.dateTimePickerDataFimAluguer);
            this.groupBoxAluguer.Controls.Add(this.dateTimePickerDataInicioAluguer);
            this.groupBoxAluguer.Controls.Add(this.labelDataFimAluguer);
            this.groupBoxAluguer.Controls.Add(this.labelDataInicioAluguer);
            this.groupBoxAluguer.Enabled = false;
            this.groupBoxAluguer.Location = new System.Drawing.Point(6, 299);
            this.groupBoxAluguer.Name = "groupBoxAluguer";
            this.groupBoxAluguer.Size = new System.Drawing.Size(228, 154);
            this.groupBoxAluguer.TabIndex = 15;
            this.groupBoxAluguer.TabStop = false;
            this.groupBoxAluguer.Text = "Detalhes Aluguer";
            // 
            // buttonGuardarAluguer
            // 
            this.buttonGuardarAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarAluguer.Image")));
            this.buttonGuardarAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarAluguer.Location = new System.Drawing.Point(6, 124);
            this.buttonGuardarAluguer.Name = "buttonGuardarAluguer";
            this.buttonGuardarAluguer.Size = new System.Drawing.Size(216, 26);
            this.buttonGuardarAluguer.TabIndex = 29;
            this.buttonGuardarAluguer.Text = "Guardar";
            this.buttonGuardarAluguer.UseVisualStyleBackColor = true;
            this.buttonGuardarAluguer.Visible = false;
            this.buttonGuardarAluguer.Click += new System.EventHandler(this.buttonGuardarAluguer_Click);
            // 
            // maskedTextBoxValorAluguer
            // 
            this.maskedTextBoxValorAluguer.Location = new System.Drawing.Point(100, 99);
            this.maskedTextBoxValorAluguer.Mask = "€00000.00";
            this.maskedTextBoxValorAluguer.Name = "maskedTextBoxValorAluguer";
            this.maskedTextBoxValorAluguer.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxValorAluguer.TabIndex = 28;
            // 
            // textBoxQuilometragemAluguer
            // 
            this.textBoxQuilometragemAluguer.Location = new System.Drawing.Point(100, 73);
            this.textBoxQuilometragemAluguer.Name = "textBoxQuilometragemAluguer";
            this.textBoxQuilometragemAluguer.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuilometragemAluguer.TabIndex = 27;
            // 
            // labelQuilometragemAluguer
            // 
            this.labelQuilometragemAluguer.AutoSize = true;
            this.labelQuilometragemAluguer.Location = new System.Drawing.Point(11, 76);
            this.labelQuilometragemAluguer.Name = "labelQuilometragemAluguer";
            this.labelQuilometragemAluguer.Size = new System.Drawing.Size(83, 13);
            this.labelQuilometragemAluguer.TabIndex = 26;
            this.labelQuilometragemAluguer.Text = "Quilometragem: ";
            // 
            // labelValorAluguer
            // 
            this.labelValorAluguer.AutoSize = true;
            this.labelValorAluguer.Location = new System.Drawing.Point(6, 102);
            this.labelValorAluguer.Name = "labelValorAluguer";
            this.labelValorAluguer.Size = new System.Drawing.Size(88, 13);
            this.labelValorAluguer.TabIndex = 25;
            this.labelValorAluguer.Text = "Valor do Aluguer:";
            // 
            // dateTimePickerDataFimAluguer
            // 
            this.dateTimePickerDataFimAluguer.Location = new System.Drawing.Point(100, 45);
            this.dateTimePickerDataFimAluguer.Name = "dateTimePickerDataFimAluguer";
            this.dateTimePickerDataFimAluguer.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerDataFimAluguer.TabIndex = 24;
            // 
            // dateTimePickerDataInicioAluguer
            // 
            this.dateTimePickerDataInicioAluguer.Location = new System.Drawing.Point(100, 20);
            this.dateTimePickerDataInicioAluguer.Name = "dateTimePickerDataInicioAluguer";
            this.dateTimePickerDataInicioAluguer.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerDataInicioAluguer.TabIndex = 23;
            // 
            // labelDataFimAluguer
            // 
            this.labelDataFimAluguer.AutoSize = true;
            this.labelDataFimAluguer.Location = new System.Drawing.Point(27, 51);
            this.labelDataFimAluguer.Name = "labelDataFimAluguer";
            this.labelDataFimAluguer.Size = new System.Drawing.Size(67, 13);
            this.labelDataFimAluguer.TabIndex = 22;
            this.labelDataFimAluguer.Text = "Data de Fim:";
            // 
            // labelDataInicioAluguer
            // 
            this.labelDataInicioAluguer.AutoSize = true;
            this.labelDataInicioAluguer.Location = new System.Drawing.Point(16, 25);
            this.labelDataInicioAluguer.Name = "labelDataInicioAluguer";
            this.labelDataInicioAluguer.Size = new System.Drawing.Size(78, 13);
            this.labelDataInicioAluguer.TabIndex = 20;
            this.labelDataInicioAluguer.Text = "Data de Início:";
            // 
            // buttonEliminarAluguer
            // 
            this.buttonEliminarAluguer.Enabled = false;
            this.buttonEliminarAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarAluguer.Image")));
            this.buttonEliminarAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarAluguer.Location = new System.Drawing.Point(6, 80);
            this.buttonEliminarAluguer.Name = "buttonEliminarAluguer";
            this.buttonEliminarAluguer.Size = new System.Drawing.Size(228, 26);
            this.buttonEliminarAluguer.TabIndex = 31;
            this.buttonEliminarAluguer.Text = "Eliminar Aluguer";
            this.buttonEliminarAluguer.UseVisualStyleBackColor = true;
            this.buttonEliminarAluguer.Click += new System.EventHandler(this.buttonEliminarAluguer_Click);
            // 
            // buttonCriarAlguer
            // 
            this.buttonCriarAlguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarAlguer.Image")));
            this.buttonCriarAlguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCriarAlguer.Location = new System.Drawing.Point(6, 16);
            this.buttonCriarAlguer.Name = "buttonCriarAlguer";
            this.buttonCriarAlguer.Size = new System.Drawing.Size(228, 26);
            this.buttonCriarAlguer.TabIndex = 32;
            this.buttonCriarAlguer.Text = "Criar Aluguer";
            this.buttonCriarAlguer.UseVisualStyleBackColor = true;
            this.buttonCriarAlguer.Click += new System.EventHandler(this.buttonCriarAluguer_Click);
            // 
            // listBoxAluguer
            // 
            this.listBoxAluguer.FormattingEnabled = true;
            this.listBoxAluguer.Location = new System.Drawing.Point(6, 112);
            this.listBoxAluguer.Name = "listBoxAluguer";
            this.listBoxAluguer.ScrollAlwaysVisible = true;
            this.listBoxAluguer.Size = new System.Drawing.Size(228, 147);
            this.listBoxAluguer.TabIndex = 0;
            this.listBoxAluguer.Click += new System.EventHandler(this.listBoxAluguer_Click);
            // 
            // groupBoxCarrosAluguer
            // 
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonEditarCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonEliminarCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.groupBoxCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonCriarCarroAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.listBoxCarrosAluguer);
            this.groupBoxCarrosAluguer.Location = new System.Drawing.Point(372, 111);
            this.groupBoxCarrosAluguer.Name = "groupBoxCarrosAluguer";
            this.groupBoxCarrosAluguer.Size = new System.Drawing.Size(240, 460);
            this.groupBoxCarrosAluguer.TabIndex = 8;
            this.groupBoxCarrosAluguer.TabStop = false;
            this.groupBoxCarrosAluguer.Text = "Carros para Aluguer";
            // 
            // buttonEditarCarroAluguer
            // 
            this.buttonEditarCarroAluguer.Enabled = false;
            this.buttonEditarCarroAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCarroAluguer.Image")));
            this.buttonEditarCarroAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCarroAluguer.Location = new System.Drawing.Point(6, 48);
            this.buttonEditarCarroAluguer.Name = "buttonEditarCarroAluguer";
            this.buttonEditarCarroAluguer.Size = new System.Drawing.Size(228, 26);
            this.buttonEditarCarroAluguer.TabIndex = 33;
            this.buttonEditarCarroAluguer.Text = "Editar Carro Aluguer";
            this.buttonEditarCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonEditarCarroAluguer.Click += new System.EventHandler(this.buttonEditarCarroAluguer_Click);
            // 
            // buttonEliminarCarroAluguer
            // 
            this.buttonEliminarCarroAluguer.Enabled = false;
            this.buttonEliminarCarroAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCarroAluguer.Image")));
            this.buttonEliminarCarroAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarCarroAluguer.Location = new System.Drawing.Point(6, 80);
            this.buttonEliminarCarroAluguer.Name = "buttonEliminarCarroAluguer";
            this.buttonEliminarCarroAluguer.Size = new System.Drawing.Size(228, 26);
            this.buttonEliminarCarroAluguer.TabIndex = 31;
            this.buttonEliminarCarroAluguer.Text = "Eliminar Carro Aluguer";
            this.buttonEliminarCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonEliminarCarroAluguer.Click += new System.EventHandler(this.buttonEliminarCarroAluguer_Click);
            // 
            // groupBoxCarroAluguer
            // 
            this.groupBoxCarroAluguer.Controls.Add(this.numeroChassisMaskedTextBox);
            this.groupBoxCarroAluguer.Controls.Add(estadoLabel);
            this.groupBoxCarroAluguer.Controls.Add(this.estadoTextBox);
            this.groupBoxCarroAluguer.Controls.Add(this.buttonGuardarCarroAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.textBoxModeloAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.textBoxMarcaAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.comboBoxCombustivelAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.labelCombustivelAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.labelModeloAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.labelMarcaAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.labelNChassisAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.maskedTextBoxMatriculaAluguer);
            this.groupBoxCarroAluguer.Controls.Add(this.labelMatriculaAluguer);
            this.groupBoxCarroAluguer.Enabled = false;
            this.groupBoxCarroAluguer.Location = new System.Drawing.Point(6, 253);
            this.groupBoxCarroAluguer.Name = "groupBoxCarroAluguer";
            this.groupBoxCarroAluguer.Size = new System.Drawing.Size(228, 201);
            this.groupBoxCarroAluguer.TabIndex = 3;
            this.groupBoxCarroAluguer.TabStop = false;
            this.groupBoxCarroAluguer.Text = "Detalhes Carro de Aluguer";
            // 
            // numeroChassisMaskedTextBox
            // 
            this.numeroChassisMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "NumeroChassis", true));
            this.numeroChassisMaskedTextBox.Location = new System.Drawing.Point(83, 19);
            this.numeroChassisMaskedTextBox.Mask = "00000000000000000";
            this.numeroChassisMaskedTextBox.Name = "numeroChassisMaskedTextBox";
            this.numeroChassisMaskedTextBox.Size = new System.Drawing.Size(136, 20);
            this.numeroChassisMaskedTextBox.TabIndex = 19;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.realStandDataSet;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carros_CarroAluguerBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(83, 121);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(136, 20);
            this.estadoTextBox.TabIndex = 18;
            // 
            // carros_CarroAluguerBindingSource
            // 
            this.carros_CarroAluguerBindingSource.DataMember = "Carros_CarroAluguer";
            this.carros_CarroAluguerBindingSource.DataSource = this.realStandDataSet;
            // 
            // buttonGuardarCarroAluguer
            // 
            this.buttonGuardarCarroAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarCarroAluguer.Image")));
            this.buttonGuardarCarroAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarCarroAluguer.Location = new System.Drawing.Point(6, 171);
            this.buttonGuardarCarroAluguer.Name = "buttonGuardarCarroAluguer";
            this.buttonGuardarCarroAluguer.Size = new System.Drawing.Size(216, 26);
            this.buttonGuardarCarroAluguer.TabIndex = 17;
            this.buttonGuardarCarroAluguer.Text = "Guardar";
            this.buttonGuardarCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonGuardarCarroAluguer.Visible = false;
            this.buttonGuardarCarroAluguer.Click += new System.EventHandler(this.buttonGuardarCarroAluguer_Click);
            // 
            // textBoxModeloAluguer
            // 
            this.textBoxModeloAluguer.Location = new System.Drawing.Point(83, 70);
            this.textBoxModeloAluguer.Name = "textBoxModeloAluguer";
            this.textBoxModeloAluguer.Size = new System.Drawing.Size(136, 20);
            this.textBoxModeloAluguer.TabIndex = 13;
            // 
            // textBoxMarcaAluguer
            // 
            this.textBoxMarcaAluguer.Location = new System.Drawing.Point(83, 44);
            this.textBoxMarcaAluguer.Name = "textBoxMarcaAluguer";
            this.textBoxMarcaAluguer.Size = new System.Drawing.Size(136, 20);
            this.textBoxMarcaAluguer.TabIndex = 12;
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
            this.comboBoxCombustivelAluguer.Location = new System.Drawing.Point(83, 97);
            this.comboBoxCombustivelAluguer.Name = "comboBoxCombustivelAluguer";
            this.comboBoxCombustivelAluguer.Size = new System.Drawing.Size(136, 21);
            this.comboBoxCombustivelAluguer.TabIndex = 10;
            // 
            // labelCombustivelAluguer
            // 
            this.labelCombustivelAluguer.AutoSize = true;
            this.labelCombustivelAluguer.Location = new System.Drawing.Point(8, 100);
            this.labelCombustivelAluguer.Name = "labelCombustivelAluguer";
            this.labelCombustivelAluguer.Size = new System.Drawing.Size(69, 13);
            this.labelCombustivelAluguer.TabIndex = 9;
            this.labelCombustivelAluguer.Text = "Combustível:";
            // 
            // labelModeloAluguer
            // 
            this.labelModeloAluguer.AutoSize = true;
            this.labelModeloAluguer.Location = new System.Drawing.Point(32, 73);
            this.labelModeloAluguer.Name = "labelModeloAluguer";
            this.labelModeloAluguer.Size = new System.Drawing.Size(45, 13);
            this.labelModeloAluguer.TabIndex = 8;
            this.labelModeloAluguer.Text = "Modelo:";
            // 
            // labelMarcaAluguer
            // 
            this.labelMarcaAluguer.AutoSize = true;
            this.labelMarcaAluguer.Location = new System.Drawing.Point(37, 47);
            this.labelMarcaAluguer.Name = "labelMarcaAluguer";
            this.labelMarcaAluguer.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaAluguer.TabIndex = 7;
            this.labelMarcaAluguer.Text = "Marca:";
            // 
            // labelNChassisAluguer
            // 
            this.labelNChassisAluguer.AutoSize = true;
            this.labelNChassisAluguer.Location = new System.Drawing.Point(16, 22);
            this.labelNChassisAluguer.Name = "labelNChassisAluguer";
            this.labelNChassisAluguer.Size = new System.Drawing.Size(61, 13);
            this.labelNChassisAluguer.TabIndex = 6;
            this.labelNChassisAluguer.Text = "Nº Chassis:";
            // 
            // maskedTextBoxMatriculaAluguer
            // 
            this.maskedTextBoxMatriculaAluguer.Location = new System.Drawing.Point(83, 145);
            this.maskedTextBoxMatriculaAluguer.Mask = "AA-AA-AA";
            this.maskedTextBoxMatriculaAluguer.Name = "maskedTextBoxMatriculaAluguer";
            this.maskedTextBoxMatriculaAluguer.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxMatriculaAluguer.TabIndex = 3;
            // 
            // labelMatriculaAluguer
            // 
            this.labelMatriculaAluguer.AutoSize = true;
            this.labelMatriculaAluguer.Location = new System.Drawing.Point(22, 148);
            this.labelMatriculaAluguer.Name = "labelMatriculaAluguer";
            this.labelMatriculaAluguer.Size = new System.Drawing.Size(55, 13);
            this.labelMatriculaAluguer.TabIndex = 2;
            this.labelMatriculaAluguer.Text = "Matrícula:";
            // 
            // buttonCriarCarroAluguer
            // 
            this.buttonCriarCarroAluguer.Image = ((System.Drawing.Image)(resources.GetObject("buttonCriarCarroAluguer.Image")));
            this.buttonCriarCarroAluguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCriarCarroAluguer.Location = new System.Drawing.Point(6, 16);
            this.buttonCriarCarroAluguer.Name = "buttonCriarCarroAluguer";
            this.buttonCriarCarroAluguer.Size = new System.Drawing.Size(228, 26);
            this.buttonCriarCarroAluguer.TabIndex = 32;
            this.buttonCriarCarroAluguer.Text = "Criar Carro Aluguer";
            this.buttonCriarCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonCriarCarroAluguer.Click += new System.EventHandler(this.buttonCriarCarroAluguer_Click);
            // 
            // listBoxCarrosAluguer
            // 
            this.listBoxCarrosAluguer.FormattingEnabled = true;
            this.listBoxCarrosAluguer.Location = new System.Drawing.Point(6, 112);
            this.listBoxCarrosAluguer.Name = "listBoxCarrosAluguer";
            this.listBoxCarrosAluguer.ScrollAlwaysVisible = true;
            this.listBoxCarrosAluguer.Size = new System.Drawing.Size(228, 134);
            this.listBoxCarrosAluguer.TabIndex = 0;
            this.listBoxCarrosAluguer.Click += new System.EventHandler(this.listBoxCarrosAluguer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAluguerFiltrar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxAluguerFiltrarPorCampo);
            this.groupBox2.Controls.Add(this.textBoxAluguerFiltrarPor);
            this.groupBox2.Controls.Add(this.listBoxClientesAluguer);
            this.groupBox2.Location = new System.Drawing.Point(9, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 522);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // buttonAluguerFiltrar
            // 
            this.buttonAluguerFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAluguerFiltrar.Image")));
            this.buttonAluguerFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAluguerFiltrar.Location = new System.Drawing.Point(256, 37);
            this.buttonAluguerFiltrar.Name = "buttonAluguerFiltrar";
            this.buttonAluguerFiltrar.Size = new System.Drawing.Size(62, 23);
            this.buttonAluguerFiltrar.TabIndex = 10;
            this.buttonAluguerFiltrar.Text = "Filtrar";
            this.buttonAluguerFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAluguerFiltrar.UseVisualStyleBackColor = true;
            this.buttonAluguerFiltrar.Click += new System.EventHandler(this.buttonAluguerFiltrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Procurar por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Campo:";
            // 
            // comboBoxAluguerFiltrarPorCampo
            // 
            this.comboBoxAluguerFiltrarPorCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAluguerFiltrarPorCampo.FormattingEnabled = true;
            this.comboBoxAluguerFiltrarPorCampo.Items.AddRange(new object[] {
            "Nome",
            "NIF"});
            this.comboBoxAluguerFiltrarPorCampo.Location = new System.Drawing.Point(176, 40);
            this.comboBoxAluguerFiltrarPorCampo.Name = "comboBoxAluguerFiltrarPorCampo";
            this.comboBoxAluguerFiltrarPorCampo.Size = new System.Drawing.Size(75, 21);
            this.comboBoxAluguerFiltrarPorCampo.TabIndex = 7;
            // 
            // textBoxAluguerFiltrarPor
            // 
            this.textBoxAluguerFiltrarPor.Location = new System.Drawing.Point(7, 40);
            this.textBoxAluguerFiltrarPor.Name = "textBoxAluguerFiltrarPor";
            this.textBoxAluguerFiltrarPor.Size = new System.Drawing.Size(164, 20);
            this.textBoxAluguerFiltrarPor.TabIndex = 6;
            // 
            // listBoxClientesAluguer
            // 
            this.listBoxClientesAluguer.FormattingEnabled = true;
            this.listBoxClientesAluguer.Location = new System.Drawing.Point(7, 69);
            this.listBoxClientesAluguer.Name = "listBoxClientesAluguer";
            this.listBoxClientesAluguer.ScrollAlwaysVisible = true;
            this.listBoxClientesAluguer.Size = new System.Drawing.Size(312, 446);
            this.listBoxClientesAluguer.TabIndex = 0;
            this.listBoxClientesAluguer.Click += new System.EventHandler(this.listBoxClientesAluguer_Click);
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
            this.groupBoxFichaClienteVenda.Controls.Add(this.groupBox4);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.labelTotalGastoAluguer);
            this.groupBox4.Location = new System.Drawing.Point(432, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(128, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total gasto:";
            // 
            // labelTotalGastoAluguer
            // 
            this.labelTotalGastoAluguer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalGastoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelTotalGastoAluguer.ForeColor = System.Drawing.Color.Brown;
            this.labelTotalGastoAluguer.Location = new System.Drawing.Point(7, 60);
            this.labelTotalGastoAluguer.Name = "labelTotalGastoAluguer";
            this.labelTotalGastoAluguer.Size = new System.Drawing.Size(116, 20);
            this.labelTotalGastoAluguer.TabIndex = 5;
            this.labelTotalGastoAluguer.Text = "000,00€";
            this.labelTotalGastoAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
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
            // carros_CarroAluguerTableAdapter
            // 
            this.carros_CarroAluguerTableAdapter.ClearBeforeFill = true;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBoxAluguer.ResumeLayout(false);
            this.groupBoxAluguer.PerformLayout();
            this.groupBoxCarrosAluguer.ResumeLayout(false);
            this.groupBoxCarroAluguer.ResumeLayout(false);
            this.groupBoxCarroAluguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carros_CarroAluguerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxFichaClienteVenda.ResumeLayout(false);
            this.groupBoxFichaClienteVenda.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.ListBox listBoxClientesAluguer;
        private System.Windows.Forms.Label labelTituloAluguer;
        private System.Windows.Forms.GroupBox groupBoxCarrosAluguer;
        private System.Windows.Forms.GroupBox groupBoxCarroAluguer;
        private System.Windows.Forms.TextBox textBoxModeloAluguer;
        private System.Windows.Forms.TextBox textBoxMarcaAluguer;
        private System.Windows.Forms.ComboBox comboBoxCombustivelAluguer;
        private System.Windows.Forms.Label labelCombustivelAluguer;
        private System.Windows.Forms.Label labelModeloAluguer;
        private System.Windows.Forms.Label labelMarcaAluguer;
        private System.Windows.Forms.Label labelNChassisAluguer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatriculaAluguer;
        private System.Windows.Forms.Label labelMatriculaAluguer;
        private System.Windows.Forms.ListBox listBoxCarrosAluguer;
        private System.Windows.Forms.GroupBox groupBoxAluguer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFimAluguer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicioAluguer;
        private System.Windows.Forms.Label labelDataFimAluguer;
        private System.Windows.Forms.Label labelDataInicioAluguer;
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
        private System.Windows.Forms.Button buttonAluguerFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAluguerFiltrarPorCampo;
        private System.Windows.Forms.TextBox textBoxAluguerFiltrarPor;
        private System.Windows.Forms.Button buttonEditarCarroAluguer;
        private System.Windows.Forms.Button buttonEliminarCarroAluguer;
        private System.Windows.Forms.Button buttonCriarCarroAluguer;
        private System.Windows.Forms.Button buttonGuardarCarroAluguer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEditarAluguer;
        private System.Windows.Forms.Button buttonGuardarAluguer;
        private System.Windows.Forms.Button buttonEliminarAluguer;
        private System.Windows.Forms.Button buttonCriarAlguer;
        private System.Windows.Forms.ListBox listBoxAluguer;
        private System.Windows.Forms.BindingSource carros_CarroAluguerBindingSource;
        private realstandDataSetTableAdapters.Carros_CarroAluguerTableAdapter carros_CarroAluguerTableAdapter;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private realstandDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.MaskedTextBox numeroChassisMaskedTextBox;
        private System.Windows.Forms.Button buttonFiltrarOficina;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalGastoAluguer;
        private System.Windows.Forms.Button buttonEmitirFaturaOficina;
        private System.Windows.Forms.Button buttonEmitirFaturaVendas;
        private System.Windows.Forms.Button buttonEmitirFaturaAluguer;
    }
}

