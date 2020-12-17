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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsMaraphon = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BsSorevnovan = new System.Windows.Forms.BindingSource(this.components);
            this.zritelsTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.ZritelsTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.maraphonTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.MaraphonTableAdapter();
            this.sorevnovaniaTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SorevnovaniaTableAdapter();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.NameBegun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamBegun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBegunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaraphon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsMaraphon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevnovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1262, 62);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1184, 62);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место зрителя";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(1184, 0);
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
            this.DgvMaraphon.Location = new System.Drawing.Point(16, 169);
            this.DgvMaraphon.MultiSelect = false;
            this.DgvMaraphon.Name = "DgvMaraphon";
            this.DgvMaraphon.ReadOnly = true;
            this.DgvMaraphon.RowTemplate.Height = 27;
            this.DgvMaraphon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMaraphon.Size = new System.Drawing.Size(541, 168);
            this.DgvMaraphon.TabIndex = 9;
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
            this.dataDataGridViewTextBoxColumn.Width = 200;
            // 
            // BsMaraphon
            // 
            this.BsMaraphon.DataMember = "Maraphon";
            this.BsMaraphon.DataSource = this.u37_1DataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameBegun,
            this.FamBegun,
            this.idBegunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BsSorevnovan;
            this.dataGridView1.Location = new System.Drawing.Point(592, 169);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 168);
            this.dataGridView1.TabIndex = 10;
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
            // NameBegun
            // 
            this.NameBegun.DataPropertyName = "NameBegun";
            this.NameBegun.HeaderText = "Имя спортсмена";
            this.NameBegun.Name = "NameBegun";
            this.NameBegun.ReadOnly = true;
            this.NameBegun.Width = 150;
            // 
            // FamBegun
            // 
            this.FamBegun.DataPropertyName = "FamBegun";
            this.FamBegun.HeaderText = "Фамилия спортсмена";
            this.FamBegun.Name = "FamBegun";
            this.FamBegun.ReadOnly = true;
            this.FamBegun.Width = 150;
            // 
            // idBegunDataGridViewTextBoxColumn
            // 
            this.idBegunDataGridViewTextBoxColumn.DataPropertyName = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.HeaderText = "IdBegun";
            this.idBegunDataGridViewTextBoxColumn.Name = "idBegunDataGridViewTextBoxColumn";
            this.idBegunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormZritel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 518);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSorevnovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource BsSorevnovan;
        private u37_1DataSetTableAdapters.SorevnovaniaTableAdapter sorevnovaniaTableAdapter;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBegun;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamBegun;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBegunDataGridViewTextBoxColumn;
    }
}