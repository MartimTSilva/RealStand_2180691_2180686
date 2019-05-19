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
            this.realStandDataSet = new RealStand.RealStandDataSet();
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAluguer = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new RealStand.RealStandDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new RealStand.RealStandDataSetTableAdapters.TableAdapterManager();
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
            contactoLabel.Location = new System.Drawing.Point(167, 42);
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
            this.tabControl1.Size = new System.Drawing.Size(801, 450);
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
            this.tabPageInicio.Size = new System.Drawing.Size(631, 442);
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
            this.tabPageClientes.Size = new System.Drawing.Size(631, 442);
            this.tabPageClientes.TabIndex = 1;
            this.tabPageClientes.Text = "Clientes";
            // 
            // labelCampoDeProcura
            // 
            this.labelCampoDeProcura.AutoSize = true;
            this.labelCampoDeProcura.Location = new System.Drawing.Point(162, 32);
            this.labelCampoDeProcura.Name = "labelCampoDeProcura";
            this.labelCampoDeProcura.Size = new System.Drawing.Size(43, 13);
            this.labelCampoDeProcura.TabIndex = 7;
            this.labelCampoDeProcura.Text = "Campo:";
            // 
            // labelProcurarPor
            // 
            this.labelProcurarPor.AutoSize = true;
            this.labelProcurarPor.Location = new System.Drawing.Point(3, 32);
            this.labelProcurarPor.Name = "labelProcurarPor";
            this.labelProcurarPor.Size = new System.Drawing.Size(68, 13);
            this.labelProcurarPor.TabIndex = 6;
            this.labelProcurarPor.Text = "Procurar por:";
            // 
            // comboBoxCampoProcura
            // 
            this.comboBoxCampoProcura.FormattingEnabled = true;
            this.comboBoxCampoProcura.Location = new System.Drawing.Point(162, 48);
            this.comboBoxCampoProcura.Name = "comboBoxCampoProcura";
            this.comboBoxCampoProcura.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampoProcura.TabIndex = 5;
            // 
            // textBoxProcurarPor
            // 
            this.textBoxProcurarPor.Location = new System.Drawing.Point(3, 48);
            this.textBoxProcurarPor.Name = "textBoxProcurarPor";
            this.textBoxProcurarPor.Size = new System.Drawing.Size(153, 20);
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
            this.groupBoxDadosClientes.Location = new System.Drawing.Point(290, 32);
            this.groupBoxDadosClientes.Name = "groupBoxDadosClientes";
            this.groupBoxDadosClientes.Size = new System.Drawing.Size(332, 402);
            this.groupBoxDadosClientes.TabIndex = 3;
            this.groupBoxDadosClientes.TabStop = false;
            this.groupBoxDadosClientes.Text = "Dados";
            // 
            // buttonGravarCliente
            // 
            this.buttonGravarCliente.Location = new System.Drawing.Point(250, 373);
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
            this.nomeTextBox.Size = new System.Drawing.Size(261, 20);
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
            this.nIFMaskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.nIFMaskedTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(65, 65);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(261, 20);
            this.moradaTextBox.TabIndex = 5;
            // 
            // contactoMaskedTextBox
            // 
            this.contactoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Contacto", true));
            this.contactoMaskedTextBox.Location = new System.Drawing.Point(226, 39);
            this.contactoMaskedTextBox.Mask = "(99) 0000000";
            this.contactoMaskedTextBox.Name = "contactoMaskedTextBox";
            this.contactoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.clientesBindingNavigator.Size = new System.Drawing.Size(625, 25);
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
            this.clientesListBox.Location = new System.Drawing.Point(3, 71);
            this.clientesListBox.Name = "clientesListBox";
            this.clientesListBox.Size = new System.Drawing.Size(280, 368);
            this.clientesListBox.TabIndex = 0;
            this.clientesListBox.ValueMember = "Id";
            // 
            // tabPageOficina
            // 
            this.tabPageOficina.BackColor = System.Drawing.Color.Silver;
            this.tabPageOficina.Controls.Add(this.label3);
            this.tabPageOficina.Location = new System.Drawing.Point(166, 4);
            this.tabPageOficina.Name = "tabPageOficina";
            this.tabPageOficina.Size = new System.Drawing.Size(631, 442);
            this.tabPageOficina.TabIndex = 2;
            this.tabPageOficina.Text = "Oficina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oficina";
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.Color.Silver;
            this.tabPageVendas.Controls.Add(this.label4);
            this.tabPageVendas.Location = new System.Drawing.Point(166, 4);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Size = new System.Drawing.Size(631, 442);
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
            this.tabPageAluguer.Size = new System.Drawing.Size(631, 442);
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
            this.tableAdapterManager.UpdateOrder = RealStand.RealStandDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageAluguer;
        private System.Windows.Forms.Label label5;
        private RealStandDataSet realStandDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private RealStandDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private RealStandDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
    }
}

