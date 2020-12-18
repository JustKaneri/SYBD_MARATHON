namespace СУБД_Марафон
{
    partial class FormZritel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZritel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.LblFio = new System.Windows.Forms.Label();
            this.BsZritel = new System.Windows.Forms.BindingSource(this.components);
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BtnProfZritel = new System.Windows.Forms.Button();
            this.DgvMaraphon = new System.Windows.Forms.DataGridView();
            this.BsMaraphon = new System.Windows.Forms.BindingSource(this.components);
            this.DgvBegun = new System.Windows.Forms.DataGridView();
            this.BsSorevnovan = new System.Windows.Forms.BindingSource(this.components);
            this.zritelsTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.ZritelsTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.maraphonTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.MaraphonTableAdapter();
            this.sorevnovaniaTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SorevnovaniaTableAdapter();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.DgvSponsor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.CmbxFind = new System.Windows.Forms.ComboBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBegunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamBegun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBegun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaraphon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMaraphon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevnovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSponsor)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(626, 62);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(548, 62);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место зрителя";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(548, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 62);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // LblFio
            // 
            this.LblFio.AutoSize = true;
            this.LblFio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "FIO", true));
            this.LblFio.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFio.Location = new System.Drawing.Point(24, 65);
            this.LblFio.Name = "LblFio";
            this.LblFio.Size = new System.Drawing.Size(53, 21);
            this.LblFio.TabIndex = 3;
            this.LblFio.Text = "label1";
            // 
            // BsZritel
            // 
            this.BsZritel.DataMember = "Zritels";
            this.BsZritel.DataSource = this.u37_1DataSet1;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnProfZritel
            // 
            this.BtnProfZritel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnProfZritel.Location = new System.Drawing.Point(16, 96);
            this.BtnProfZritel.Name = "BtnProfZritel";
            this.BtnProfZritel.Size = new System.Drawing.Size(241, 39);
            this.BtnProfZritel.TabIndex = 8;
            this.BtnProfZritel.Text = "Профиль";
            this.BtnProfZritel.UseVisualStyleBackColor = false;
            this.BtnProfZritel.Click += new System.EventHandler(this.BtnProfZritel_Click);
            // 
            // DgvMaraphon
            // 
            this.DgvMaraphon.AllowUserToAddRows = false;
            this.DgvMaraphon.AllowUserToDeleteRows = false;
            this.DgvMaraphon.AllowUserToResizeColumns = false;
            this.DgvMaraphon.AllowUserToResizeRows = false;
            this.DgvMaraphon.AutoGenerateColumns = false;
            this.DgvMaraphon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaraphon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dlinaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.DgvMaraphon.DataSource = this.BsMaraphon;
            this.DgvMaraphon.Location = new System.Drawing.Point(43, 162);
            this.DgvMaraphon.MultiSelect = false;
            this.DgvMaraphon.Name = "DgvMaraphon";
            this.DgvMaraphon.ReadOnly = true;
            this.DgvMaraphon.RowTemplate.Height = 27;
            this.DgvMaraphon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMaraphon.Size = new System.Drawing.Size(528, 168);
            this.DgvMaraphon.TabIndex = 9;
            // 
            // BsMaraphon
            // 
            this.BsMaraphon.DataMember = "Maraphon";
            this.BsMaraphon.DataSource = this.u37_1DataSet1;
            // 
            // DgvBegun
            // 
            this.DgvBegun.AllowUserToAddRows = false;
            this.DgvBegun.AllowUserToDeleteRows = false;
            this.DgvBegun.AllowUserToResizeColumns = false;
            this.DgvBegun.AllowUserToResizeRows = false;
            this.DgvBegun.AutoGenerateColumns = false;
            this.DgvBegun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBegun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBegunDataGridViewTextBoxColumn,
            this.FamBegun,
            this.NameBegun});
            this.DgvBegun.DataSource = this.BsSorevnovan;
            this.DgvBegun.Location = new System.Drawing.Point(77, 350);
            this.DgvBegun.MultiSelect = false;
            this.DgvBegun.Name = "DgvBegun";
            this.DgvBegun.ReadOnly = true;
            this.DgvBegun.RowTemplate.Height = 27;
            this.DgvBegun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBegun.Size = new System.Drawing.Size(459, 150);
            this.DgvBegun.TabIndex = 10;
            this.DgvBegun.SelectionChanged += new System.EventHandler(this.DgvBegun_SelectionChanged);
            // 
            // BsSorevnovan
            // 
            this.BsSorevnovan.DataMember = "FK_Sorevnovania_Maraphon";
            this.BsSorevnovan.DataSource = this.BsMaraphon;
            // 
            // zritelsTableAdapter
            // 
            this.zritelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BegunTableAdapter = null;
            this.tableAdapterManager.InventarBegunTableAdapter = null;
            this.tableAdapterManager.InventarTableAdapter = null;
            this.tableAdapterManager.MaraphonTableAdapter = null;
            this.tableAdapterManager.SorevnovaniaTableAdapter = null;
            this.tableAdapterManager.SponsorBegunTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZritelsTableAdapter = this.zritelsTableAdapter;
            // 
            // maraphonTableAdapter
            // 
            this.maraphonTableAdapter.ClearBeforeFill = true;
            // 
            // sorevnovaniaTableAdapter
            // 
            this.sorevnovaniaTableAdapter.ClearBeforeFill = true;
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
            // DgvSponsor
            // 
            this.DgvSponsor.AllowUserToAddRows = false;
            this.DgvSponsor.AllowUserToDeleteRows = false;
            this.DgvSponsor.AllowUserToResizeColumns = false;
            this.DgvSponsor.AllowUserToResizeRows = false;
            this.DgvSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSponsor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvSponsor.Location = new System.Drawing.Point(110, 546);
            this.DgvSponsor.MultiSelect = false;
            this.DgvSponsor.Name = "DgvSponsor";
            this.DgvSponsor.ReadOnly = true;
            this.DgvSponsor.RowTemplate.Height = 27;
            this.DgvSponsor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSponsor.Size = new System.Drawing.Size(401, 150);
            this.DgvSponsor.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Location = new System.Drawing.Point(73, 503);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(153, 19);
            this.LblSum.TabIndex = 12;
            this.LblSum.Text = "Спонсорская помощь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск";
            // 
            // TbxFind
            // 
            this.TbxFind.Location = new System.Drawing.Point(332, 104);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(116, 25);
            this.TbxFind.TabIndex = 14;
            this.TbxFind.TextChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // CmbxFind
            // 
            this.CmbxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxFind.FormattingEnabled = true;
            this.CmbxFind.Items.AddRange(new object[] {
            "Марафону",
            "Спортсмену",
            "Спонсору"});
            this.CmbxFind.Location = new System.Drawing.Point(471, 101);
            this.CmbxFind.Name = "CmbxFind";
            this.CmbxFind.Size = new System.Drawing.Size(144, 25);
            this.CmbxFind.TabIndex = 15;
            this.CmbxFind.SelectedIndexChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
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
            this.dataDataGridViewTextBoxColumn.Width = 130;
            // 
            // idBegunDataGridViewTextBoxColumn
            // 
            this.idBegunDataGridViewTextBoxColumn.DataPropertyName = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.HeaderText = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.Name = "idBegunDataGridViewTextBoxColumn";
            this.idBegunDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBegunDataGridViewTextBoxColumn.Visible = false;
            // 
            // FamBegun
            // 
            this.FamBegun.DataPropertyName = "FamBegun";
            this.FamBegun.HeaderText = "Фамилия спортсмена";
            this.FamBegun.Name = "FamBegun";
            this.FamBegun.ReadOnly = true;
            this.FamBegun.Width = 150;
            // 
            // NameBegun
            // 
            this.NameBegun.DataPropertyName = "NameBegun";
            this.NameBegun.HeaderText = "Имя спортсмена";
            this.NameBegun.Name = "NameBegun";
            this.NameBegun.ReadOnly = true;
            this.NameBegun.Width = 150;
            // 
            // FormZritel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 727);
            this.Controls.Add(this.CmbxFind);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.DgvSponsor);
            this.Controls.Add(this.DgvBegun);
            this.Controls.Add(this.DgvMaraphon);
            this.Controls.Add(this.BtnProfZritel);
            this.Controls.Add(this.LblFio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormZritel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormZritel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaraphon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMaraphon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBegun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevnovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSponsor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet1;
        private u37_1DataSetTableAdapters.ZritelsTableAdapter zritelsTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource BsZritel;
        private System.Windows.Forms.Label LblFio;
        private System.Windows.Forms.Button BtnProfZritel;
        private System.Windows.Forms.BindingSource BsMaraphon;
        private u37_1DataSetTableAdapters.MaraphonTableAdapter maraphonTableAdapter;
        private System.Windows.Forms.DataGridView DgvMaraphon;
        private System.Windows.Forms.DataGridView DgvBegun;
        private System.Windows.Forms.BindingSource BsSorevnovan;
        private u37_1DataSetTableAdapters.SorevnovaniaTableAdapter sorevnovaniaTableAdapter;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private System.Windows.Forms.DataGridView DgvSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.ComboBox CmbxFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBegunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamBegun;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBegun;
    }
}