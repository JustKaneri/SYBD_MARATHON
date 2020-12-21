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
            System.Windows.Forms.Label scrokLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.fIOLabel1 = new System.Windows.Forms.Label();
            this.BsSponsor = new System.Windows.Forms.BindingSource(this.components);
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BtnProfSponsor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxSumPopoln = new System.Windows.Forms.TextBox();
            this.BtnSetSum = new System.Windows.Forms.Button();
            this.DgvBegun = new System.Windows.Forms.DataGridView();
            this.FioInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LblSumm = new System.Windows.Forms.Label();
            this.MtbSrok = new System.Windows.Forms.MaskedTextBox();
            this.sponsorTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SponsorTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.TbxTakeSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTake = new System.Windows.Forms.Button();
            this.LblIdBegun = new System.Windows.Forms.Label();
            this.LblIdSponsor = new System.Windows.Forms.Label();
            scrokLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 67);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(732, 67);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место спонсора";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(732, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 67);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
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
            // BsSponsor
            // 
            this.BsSponsor.DataMember = "Sponsor";
            this.BsSponsor.DataSource = this.u37_1DataSet1;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(19, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ваш счет: ";
            // 
            // TbxSumPopoln
            // 
            this.TbxSumPopoln.Location = new System.Drawing.Point(21, 224);
            this.TbxSumPopoln.Name = "TbxSumPopoln";
            this.TbxSumPopoln.Size = new System.Drawing.Size(100, 25);
            this.TbxSumPopoln.TabIndex = 12;
            this.TbxSumPopoln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxSumPopoln_KeyPress);
            // 
            // BtnSetSum
            // 
            this.BtnSetSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnSetSum.Location = new System.Drawing.Point(138, 217);
            this.BtnSetSum.Name = "BtnSetSum";
            this.BtnSetSum.Size = new System.Drawing.Size(130, 36);
            this.BtnSetSum.TabIndex = 13;
            this.BtnSetSum.Text = "Пополнить";
            this.BtnSetSum.UseVisualStyleBackColor = false;
            this.BtnSetSum.Click += new System.EventHandler(this.BtnSetSum_Click);
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
            this.FioInc,
            this.summaDataGridViewTextBoxColumn});
            this.DgvBegun.DataSource = this.BsBegun;
            this.DgvBegun.Location = new System.Drawing.Point(332, 89);
            this.DgvBegun.Name = "DgvBegun";
            this.DgvBegun.ReadOnly = true;
            this.DgvBegun.RowTemplate.Height = 27;
            this.DgvBegun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBegun.Size = new System.Drawing.Size(464, 276);
            this.DgvBegun.TabIndex = 14;
            // 
            // FioInc
            // 
            this.FioInc.DataPropertyName = "FioInc";
            this.FioInc.HeaderText = "ФИО";
            this.FioInc.Name = "FioInc";
            this.FioInc.ReadOnly = true;
            this.FioInc.Width = 150;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма на счету";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaDataGridViewTextBoxColumn.Width = 150;
            // 
            // BsBegun
            // 
            this.BsBegun.DataMember = "Begun";
            this.BsBegun.DataSource = this.u37_1DataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пополнить";
            // 
            // LblSumm
            // 
            this.LblSumm.AutoSize = true;
            this.LblSumm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsSponsor, "Summa", true));
            this.LblSumm.Location = new System.Drawing.Point(100, 166);
            this.LblSumm.Name = "LblSumm";
            this.LblSumm.Size = new System.Drawing.Size(47, 19);
            this.LblSumm.TabIndex = 16;
            this.LblSumm.Text = "label3";
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
            // begunTableAdapter
            // 
            this.begunTableAdapter.ClearBeforeFill = true;
            // 
            // TbxTakeSum
            // 
            this.TbxTakeSum.Location = new System.Drawing.Point(21, 308);
            this.TbxTakeSum.Name = "TbxTakeSum";
            this.TbxTakeSum.Size = new System.Drawing.Size(100, 25);
            this.TbxTakeSum.TabIndex = 19;
            this.TbxTakeSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxTakeSum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Пожертвовать спортсмену";
            // 
            // BtnTake
            // 
            this.BtnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnTake.Location = new System.Drawing.Point(138, 301);
            this.BtnTake.Name = "BtnTake";
            this.BtnTake.Size = new System.Drawing.Size(130, 36);
            this.BtnTake.TabIndex = 21;
            this.BtnTake.Text = "Пожертвовать";
            this.BtnTake.UseVisualStyleBackColor = false;
            this.BtnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // LblIdBegun
            // 
            this.LblIdBegun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsBegun, "IdBegun", true));
            this.LblIdBegun.Location = new System.Drawing.Point(1136, 114);
            this.LblIdBegun.Name = "LblIdBegun";
            this.LblIdBegun.Size = new System.Drawing.Size(100, 23);
            this.LblIdBegun.TabIndex = 22;
            this.LblIdBegun.Text = "label3";
            // 
            // LblIdSponsor
            // 
            this.LblIdSponsor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsSponsor, "IdSponsor", true));
            this.LblIdSponsor.Location = new System.Drawing.Point(1136, 162);
            this.LblIdSponsor.Name = "LblIdSponsor";
            this.LblIdSponsor.Size = new System.Drawing.Size(100, 23);
            this.LblIdSponsor.TabIndex = 23;
            this.LblIdSponsor.Text = "label3";
            // 
            // FormSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 387);
            this.Controls.Add(this.LblIdSponsor);
            this.Controls.Add(this.LblIdBegun);
            this.Controls.Add(this.BtnTake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxTakeSum);
            this.Controls.Add(this.MtbSrok);
            this.Controls.Add(scrokLabel);
            this.Controls.Add(this.LblSumm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvBegun);
            this.Controls.Add(this.BtnSetSum);
            this.Controls.Add(this.TbxSumPopoln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProfSponsor);
            this.Controls.Add(this.fIOLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormSponsor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBegun)).EndInit();
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
        private System.Windows.Forms.TextBox TbxSumPopoln;
        private System.Windows.Forms.Button BtnSetSum;
        private System.Windows.Forms.DataGridView DgvBegun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSumm;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private System.Windows.Forms.MaskedTextBox MtbSrok;
        private System.Windows.Forms.DataGridViewTextBoxColumn FioInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TbxTakeSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnTake;
        private System.Windows.Forms.Label LblIdBegun;
        private System.Windows.Forms.Label LblIdSponsor;
    }
}