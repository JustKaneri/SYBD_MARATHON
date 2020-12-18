namespace СУБД_Марафон
{
    partial class FormSponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsor));
            System.Windows.Forms.Label scrokLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BsSponsor = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SponsorTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.fIOLabel1 = new System.Windows.Forms.Label();
            this.BtnProfSponsor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtbSrok = new System.Windows.Forms.MaskedTextBox();
            scrokLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(808, 67);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(730, 67);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место спонсора";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(730, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 67);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsSponsor
            // 
            this.BsSponsor.DataMember = "Sponsor";
            this.BsSponsor.DataSource = this.u37_1DataSet1;
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SponsorTableAdapter = this.sponsorTableAdapter;
            this.tableAdapterManager.UpdateOrder = СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZritelsTableAdapter = null;
            // 
            // fIOLabel1
            // 
            this.fIOLabel1.AutoSize = true;
            this.fIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsSponsor, "FIO", true));
            this.fIOLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIOLabel1.Location = new System.Drawing.Point(12, 67);
            this.fIOLabel1.Name = "fIOLabel1";
            this.fIOLabel1.Size = new System.Drawing.Size(51, 19);
            this.fIOLabel1.TabIndex = 2;
            this.fIOLabel1.Text = "label1";
            // 
            // BtnProfSponsor
            // 
            this.BtnProfSponsor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnProfSponsor.Location = new System.Drawing.Point(16, 89);
            this.BtnProfSponsor.Name = "BtnProfSponsor";
            this.BtnProfSponsor.Size = new System.Drawing.Size(241, 39);
            this.BtnProfSponsor.TabIndex = 10;
            this.BtnProfSponsor.Text = "Профиль";
            this.BtnProfSponsor.UseVisualStyleBackColor = false;
            this.BtnProfSponsor.Click += new System.EventHandler(this.BtnProfSponsor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ваш счет: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button1.Location = new System.Drawing.Point(127, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Пополнить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.famDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.othDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BsBegun;
            this.dataGridView1.Location = new System.Drawing.Point(332, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пополнить";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsSponsor, "Summa", true));
            this.label3.Location = new System.Drawing.Point(103, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
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
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "Fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Fam";
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // othDataGridViewTextBoxColumn
            // 
            this.othDataGridViewTextBoxColumn.DataPropertyName = "Oth";
            this.othDataGridViewTextBoxColumn.HeaderText = "Oth";
            this.othDataGridViewTextBoxColumn.Name = "othDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // scrokLabel
            // 
            scrokLabel.AutoSize = true;
            scrokLabel.Location = new System.Drawing.Point(19, 137);
            scrokLabel.Name = "scrokLabel";
            scrokLabel.Size = new System.Drawing.Size(87, 19);
            scrokLabel.TabIndex = 16;
            scrokLabel.Text = "Срок карты:";
            // 
            // MtbSrok
            // 
            this.MtbSrok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsSponsor, "Scrok", true));
            this.MtbSrok.Location = new System.Drawing.Point(112, 134);
            this.MtbSrok.Mask = "99\\/99";
            this.MtbSrok.Name = "MtbSrok";
            this.MtbSrok.ReadOnly = true;
            this.MtbSrok.Size = new System.Drawing.Size(38, 25);
            this.MtbSrok.TabIndex = 18;
            // 
            // FormSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.MtbSrok);
            this.Controls.Add(scrokLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProfSponsor);
            this.Controls.Add(this.fIOLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormSponsor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet1;
        private u37_1DataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label fIOLabel1;
        public System.Windows.Forms.BindingSource BsSponsor;
        private System.Windows.Forms.Button BtnProfSponsor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox MtbSrok;
    }
}