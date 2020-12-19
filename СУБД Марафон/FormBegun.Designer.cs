namespace СУБД_Марафон
{
    partial class FormBegun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBegun));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.fIOLabel1 = new System.Windows.Forms.Label();
            this.BtnProfBegun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
            this.DgvAllMarap = new System.Windows.Forms.DataGridView();
            this.BsSorevn = new System.Windows.Forms.BindingSource(this.components);
            this.DgvYourMaraph = new System.Windows.Forms.DataGridView();
            this.GrpMaraph = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelSel = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvAllInventar = new System.Windows.Forms.DataGridView();
            this.DgvYourInvent = new System.Windows.Forms.DataGridView();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dlina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInventarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsInventar = new System.Windows.Forms.BindingSource(this.components);
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.idMaraphonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsMaraphn = new System.Windows.Forms.BindingSource(this.components);
            this.idMaraphonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMarphonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBegunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.maraphonTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.MaraphonTableAdapter();
            this.sorevnovaniaTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SorevnovaniaTableAdapter();
            this.inventarTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.InventarTableAdapter();
            this.BsYourInvent = new System.Windows.Forms.BindingSource(this.components);
            this.inventarBegunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.InventarBegunTableAdapter();
            this.idInventartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllMarap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYourMaraph)).BeginInit();
            this.GrpMaraph.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllInventar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYourInvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsInventar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMaraphn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsYourInvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 58);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1256, 58);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место спортсмена";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(1256, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 58);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // fIOLabel1
            // 
            this.fIOLabel1.AutoSize = true;
            this.fIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsBegun, "FIO", true));
            this.fIOLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIOLabel1.Location = new System.Drawing.Point(12, 58);
            this.fIOLabel1.Name = "fIOLabel1";
            this.fIOLabel1.Size = new System.Drawing.Size(51, 19);
            this.fIOLabel1.TabIndex = 2;
            this.fIOLabel1.Text = "label1";
            // 
            // BtnProfBegun
            // 
            this.BtnProfBegun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnProfBegun.Location = new System.Drawing.Point(6, 91);
            this.BtnProfBegun.Name = "BtnProfBegun";
            this.BtnProfBegun.Size = new System.Drawing.Size(241, 39);
            this.BtnProfBegun.TabIndex = 9;
            this.BtnProfBegun.Text = "Профиль";
            this.BtnProfBegun.UseVisualStyleBackColor = false;
            this.BtnProfBegun.Click += new System.EventHandler(this.BtnProfBegun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сумма на счету:";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsBegun, "Summa", true));
            this.LblSum.Location = new System.Drawing.Point(133, 137);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(47, 19);
            this.LblSum.TabIndex = 11;
            this.LblSum.Text = "label2";
            // 
            // DgvAllMarap
            // 
            this.DgvAllMarap.AllowUserToAddRows = false;
            this.DgvAllMarap.AllowUserToDeleteRows = false;
            this.DgvAllMarap.AllowUserToResizeColumns = false;
            this.DgvAllMarap.AllowUserToResizeRows = false;
            this.DgvAllMarap.AutoGenerateColumns = false;
            this.DgvAllMarap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllMarap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaraphonDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dlinaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.vznosDataGridViewTextBoxColumn});
            this.DgvAllMarap.DataSource = this.BsMaraphn;
            this.DgvAllMarap.Location = new System.Drawing.Point(19, 60);
            this.DgvAllMarap.MultiSelect = false;
            this.DgvAllMarap.Name = "DgvAllMarap";
            this.DgvAllMarap.ReadOnly = true;
            this.DgvAllMarap.RowTemplate.Height = 27;
            this.DgvAllMarap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAllMarap.Size = new System.Drawing.Size(439, 205);
            this.DgvAllMarap.TabIndex = 12;
            // 
            // BsSorevn
            // 
            this.BsSorevn.DataMember = "FK_Sorevnovania_Begun";
            this.BsSorevn.DataSource = this.BsBegun;
            // 
            // DgvYourMaraph
            // 
            this.DgvYourMaraph.AllowUserToAddRows = false;
            this.DgvYourMaraph.AllowUserToDeleteRows = false;
            this.DgvYourMaraph.AllowUserToResizeColumns = false;
            this.DgvYourMaraph.AllowUserToResizeRows = false;
            this.DgvYourMaraph.AutoGenerateColumns = false;
            this.DgvYourMaraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvYourMaraph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaraphonDataGridViewTextBoxColumn1,
            this.nameMarphonDataGridViewTextBoxColumn,
            this.Dlina,
            this.Data,
            this.Vznos,
            this.idBegunDataGridViewTextBoxColumn});
            this.DgvYourMaraph.DataSource = this.BsSorevn;
            this.DgvYourMaraph.Location = new System.Drawing.Point(19, 302);
            this.DgvYourMaraph.MultiSelect = false;
            this.DgvYourMaraph.Name = "DgvYourMaraph";
            this.DgvYourMaraph.ReadOnly = true;
            this.DgvYourMaraph.RowTemplate.Height = 27;
            this.DgvYourMaraph.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvYourMaraph.Size = new System.Drawing.Size(439, 162);
            this.DgvYourMaraph.TabIndex = 13;
            // 
            // GrpMaraph
            // 
            this.GrpMaraph.Controls.Add(this.BtnSelect);
            this.GrpMaraph.Controls.Add(this.BtnCancelSel);
            this.GrpMaraph.Controls.Add(this.label3);
            this.GrpMaraph.Controls.Add(this.label2);
            this.GrpMaraph.Controls.Add(this.DgvAllMarap);
            this.GrpMaraph.Controls.Add(this.DgvYourMaraph);
            this.GrpMaraph.Location = new System.Drawing.Point(17, 174);
            this.GrpMaraph.Name = "GrpMaraph";
            this.GrpMaraph.Size = new System.Drawing.Size(655, 470);
            this.GrpMaraph.TabIndex = 14;
            this.GrpMaraph.TabStop = false;
            this.GrpMaraph.Text = "Марафоны:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Все марафоны:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Марафоны на которые вы записаны:";
            // 
            // BtnCancelSel
            // 
            this.BtnCancelSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnCancelSel.Location = new System.Drawing.Point(464, 302);
            this.BtnCancelSel.Name = "BtnCancelSel";
            this.BtnCancelSel.Size = new System.Drawing.Size(172, 68);
            this.BtnCancelSel.TabIndex = 16;
            this.BtnCancelSel.Text = "Отменить запись";
            this.BtnCancelSel.UseVisualStyleBackColor = false;
            this.BtnCancelSel.Click += new System.EventHandler(this.BtnCancelSel_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnSelect.Location = new System.Drawing.Point(464, 60);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(172, 68);
            this.BtnSelect.TabIndex = 17;
            this.BtnSelect.Text = "Записаться на марафон";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbxCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnBuy);
            this.groupBox1.Controls.Add(this.DgvYourInvent);
            this.groupBox1.Controls.Add(this.DgvAllInventar);
            this.groupBox1.Location = new System.Drawing.Point(678, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 470);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инвентарь:";
            // 
            // DgvAllInventar
            // 
            this.DgvAllInventar.AllowUserToAddRows = false;
            this.DgvAllInventar.AllowUserToDeleteRows = false;
            this.DgvAllInventar.AllowUserToResizeColumns = false;
            this.DgvAllInventar.AllowUserToResizeRows = false;
            this.DgvAllInventar.AutoGenerateColumns = false;
            this.DgvAllInventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllInventar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInventarDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.DgvAllInventar.DataSource = this.BsInventar;
            this.DgvAllInventar.Location = new System.Drawing.Point(6, 49);
            this.DgvAllInventar.MultiSelect = false;
            this.DgvAllInventar.Name = "DgvAllInventar";
            this.DgvAllInventar.ReadOnly = true;
            this.DgvAllInventar.RowTemplate.Height = 27;
            this.DgvAllInventar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAllInventar.Size = new System.Drawing.Size(439, 216);
            this.DgvAllInventar.TabIndex = 0;
            // 
            // DgvYourInvent
            // 
            this.DgvYourInvent.AutoGenerateColumns = false;
            this.DgvYourInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvYourInvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInventartDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn1});
            this.DgvYourInvent.DataSource = this.BsYourInvent;
            this.DgvYourInvent.Location = new System.Drawing.Point(6, 302);
            this.DgvYourInvent.Name = "DgvYourInvent";
            this.DgvYourInvent.RowTemplate.Height = 27;
            this.DgvYourInvent.Size = new System.Drawing.Size(579, 162);
            this.DgvYourInvent.TabIndex = 1;
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnBuy.Location = new System.Drawing.Point(451, 99);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(172, 68);
            this.BtnBuy.TabIndex = 19;
            this.BtnBuy.Text = "Купить инвентарь";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Инвентарь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ваш инвентарь:";
            // 
            // Dlina
            // 
            this.Dlina.DataPropertyName = "Dlina";
            this.Dlina.HeaderText = "Длина";
            this.Dlina.Name = "Dlina";
            this.Dlina.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Дата проведения";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Vznos
            // 
            this.Vznos.DataPropertyName = "Vznos";
            this.Vznos.HeaderText = "Взнос";
            this.Vznos.Name = "Vznos";
            this.Vznos.ReadOnly = true;
            // 
            // idInventarDataGridViewTextBoxColumn
            // 
            this.idInventarDataGridViewTextBoxColumn.DataPropertyName = "IdInventar";
            this.idInventarDataGridViewTextBoxColumn.HeaderText = "IdInventar";
            this.idInventarDataGridViewTextBoxColumn.Name = "idInventarDataGridViewTextBoxColumn";
            this.idInventarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInventarDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // BsInventar
            // 
            this.BsInventar.DataMember = "Inventar";
            this.BsInventar.DataSource = this.u37_1DataSet1;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idMaraphonDataGridViewTextBoxColumn
            // 
            this.idMaraphonDataGridViewTextBoxColumn.DataPropertyName = "IdMaraphon";
            this.idMaraphonDataGridViewTextBoxColumn.HeaderText = "IdMaraphon";
            this.idMaraphonDataGridViewTextBoxColumn.Name = "idMaraphonDataGridViewTextBoxColumn";
            this.idMaraphonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMaraphonDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dlinaDataGridViewTextBoxColumn
            // 
            this.dlinaDataGridViewTextBoxColumn.DataPropertyName = "Dlina";
            this.dlinaDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.dlinaDataGridViewTextBoxColumn.Name = "dlinaDataGridViewTextBoxColumn";
            this.dlinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата организации";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vznosDataGridViewTextBoxColumn
            // 
            this.vznosDataGridViewTextBoxColumn.DataPropertyName = "Vznos";
            this.vznosDataGridViewTextBoxColumn.HeaderText = "Взнос";
            this.vznosDataGridViewTextBoxColumn.Name = "vznosDataGridViewTextBoxColumn";
            this.vznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BsMaraphn
            // 
            this.BsMaraphn.DataMember = "Maraphon";
            this.BsMaraphn.DataSource = this.u37_1DataSet1;
            // 
            // idMaraphonDataGridViewTextBoxColumn1
            // 
            this.idMaraphonDataGridViewTextBoxColumn1.DataPropertyName = "IdMaraphon";
            this.idMaraphonDataGridViewTextBoxColumn1.HeaderText = "IdMaraphon";
            this.idMaraphonDataGridViewTextBoxColumn1.Name = "idMaraphonDataGridViewTextBoxColumn1";
            this.idMaraphonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idMaraphonDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameMarphonDataGridViewTextBoxColumn
            // 
            this.nameMarphonDataGridViewTextBoxColumn.DataPropertyName = "NameMarphon";
            this.nameMarphonDataGridViewTextBoxColumn.HeaderText = "Название марафона";
            this.nameMarphonDataGridViewTextBoxColumn.Name = "nameMarphonDataGridViewTextBoxColumn";
            this.nameMarphonDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameMarphonDataGridViewTextBoxColumn.Width = 200;
            // 
            // idBegunDataGridViewTextBoxColumn
            // 
            this.idBegunDataGridViewTextBoxColumn.DataPropertyName = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.HeaderText = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.Name = "idBegunDataGridViewTextBoxColumn";
            this.idBegunDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBegunDataGridViewTextBoxColumn.Visible = false;
            // 
            // BsBegun
            // 
            this.BsBegun.DataMember = "Begun";
            this.BsBegun.DataSource = this.u37_1DataSet1;
            // 
            // begunTableAdapter
            // 
            this.begunTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BegunTableAdapter = this.begunTableAdapter;
            this.tableAdapterManager.InventarBegunTableAdapter = null;
            this.tableAdapterManager.InventarTableAdapter = null;
            this.tableAdapterManager.MaraphonTableAdapter = null;
            this.tableAdapterManager.SorevnovaniaTableAdapter = null;
            this.tableAdapterManager.SponsorBegunTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZritelsTableAdapter = null;
            // 
            // maraphonTableAdapter
            // 
            this.maraphonTableAdapter.ClearBeforeFill = true;
            // 
            // sorevnovaniaTableAdapter
            // 
            this.sorevnovaniaTableAdapter.ClearBeforeFill = true;
            // 
            // inventarTableAdapter
            // 
            this.inventarTableAdapter.ClearBeforeFill = true;
            // 
            // BsYourInvent
            // 
            this.BsYourInvent.DataMember = "FK_InventarBegun_Begun";
            this.BsYourInvent.DataSource = this.BsBegun;
            // 
            // inventarBegunTableAdapter
            // 
            this.inventarBegunTableAdapter.ClearBeforeFill = true;
            // 
            // idInventartDataGridViewTextBoxColumn
            // 
            this.idInventartDataGridViewTextBoxColumn.DataPropertyName = "IdInventart";
            this.idInventartDataGridViewTextBoxColumn.HeaderText = "IdInventart";
            this.idInventartDataGridViewTextBoxColumn.Name = "idInventartDataGridViewTextBoxColumn";
            this.idInventartDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 200;
            // 
            // TbxCount
            // 
            this.TbxCount.Location = new System.Drawing.Point(451, 68);
            this.TbxCount.Name = "TbxCount";
            this.TbxCount.Size = new System.Drawing.Size(167, 25);
            this.TbxCount.TabIndex = 21;
            this.TbxCount.Text = "1";
            this.TbxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Колличество";
            // 
            // FormBegun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpMaraph);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProfBegun);
            this.Controls.Add(this.fIOLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBegun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormBegun_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllMarap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYourMaraph)).EndInit();
            this.GrpMaraph.ResumeLayout(false);
            this.GrpMaraph.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllInventar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYourInvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsInventar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMaraphn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsYourInvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet1;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label fIOLabel1;
        public System.Windows.Forms.BindingSource BsBegun;
        private System.Windows.Forms.Button BtnProfBegun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.BindingSource BsMaraphn;
        private u37_1DataSetTableAdapters.MaraphonTableAdapter maraphonTableAdapter;
        private System.Windows.Forms.DataGridView DgvAllMarap;
        private System.Windows.Forms.BindingSource BsSorevn;
        private u37_1DataSetTableAdapters.SorevnovaniaTableAdapter sorevnovaniaTableAdapter;
        private System.Windows.Forms.DataGridView DgvYourMaraph;
        private System.Windows.Forms.GroupBox GrpMaraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaraphonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnCancelSel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.DataGridView DgvYourInvent;
        private System.Windows.Forms.DataGridView DgvAllInventar;
        private System.Windows.Forms.BindingSource BsInventar;
        private u37_1DataSetTableAdapters.InventarTableAdapter inventarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaraphonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMarphonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dlina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBegunDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BsYourInvent;
        private u37_1DataSetTableAdapters.InventarBegunTableAdapter inventarBegunTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
    }
}