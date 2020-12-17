namespace СУБД_Марафон
{
    partial class FormProfilrSponsor
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
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label othLabel;
            System.Windows.Forms.Label kartaNumLabel;
            System.Windows.Forms.Label kartaCVVLabel;
            System.Windows.Forms.Label scrokLabel;
            System.Windows.Forms.Label summaLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfilrSponsor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.u37_1DataSet = new СУБД_Марафон.u37_1DataSet();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SponsorTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.othTextBox = new System.Windows.Forms.TextBox();
            this.kartaNumTextBox = new System.Windows.Forms.TextBox();
            this.kartaCVVTextBox = new System.Windows.Forms.TextBox();
            this.summaTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbxOldPass = new System.Windows.Forms.TextBox();
            this.MtbxSrok = new System.Windows.Forms.MaskedTextBox();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            othLabel = new System.Windows.Forms.Label();
            kartaNumLabel = new System.Windows.Forms.Label();
            kartaCVVLabel = new System.Windows.Forms.Label();
            scrokLabel = new System.Windows.Forms.Label();
            summaLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(44, 97);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(71, 19);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(75, 147);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // othLabel
            // 
            othLabel.AutoSize = true;
            othLabel.Location = new System.Drawing.Point(44, 194);
            othLabel.Name = "othLabel";
            othLabel.Size = new System.Drawing.Size(73, 19);
            othLabel.TabIndex = 5;
            othLabel.Text = "Отчество:";
            // 
            // kartaNumLabel
            // 
            kartaNumLabel.AutoSize = true;
            kartaNumLabel.Location = new System.Drawing.Point(363, 97);
            kartaNumLabel.Name = "kartaNumLabel";
            kartaNumLabel.Size = new System.Drawing.Size(98, 19);
            kartaNumLabel.TabIndex = 7;
            kartaNumLabel.Text = "Номер карты:";
            // 
            // kartaCVVLabel
            // 
            kartaCVVLabel.AutoSize = true;
            kartaCVVLabel.Location = new System.Drawing.Point(379, 150);
            kartaCVVLabel.Name = "kartaCVVLabel";
            kartaCVVLabel.Size = new System.Drawing.Size(82, 19);
            kartaCVVLabel.TabIndex = 9;
            kartaCVVLabel.Text = "CVV карты:";
            // 
            // scrokLabel
            // 
            scrokLabel.AutoSize = true;
            scrokLabel.Location = new System.Drawing.Point(413, 197);
            scrokLabel.Name = "scrokLabel";
            scrokLabel.Size = new System.Drawing.Size(45, 19);
            scrokLabel.TabIndex = 11;
            scrokLabel.Text = "Срок:";
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Location = new System.Drawing.Point(406, 240);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new System.Drawing.Size(55, 19);
            summaLabel.TabIndex = 13;
            summaLabel.Text = "Сумма:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(53, 241);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(60, 19);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 287);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 19);
            label1.TabIndex = 25;
            label1.Text = "Введите текущей пароль для сохранения изменений:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 58);
            this.panel1.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(558, 58);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Профиль спонсора";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(558, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 58);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // u37_1DataSet
            // 
            this.u37_1DataSet.DataSetName = "u37_1DataSet";
            this.u37_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.u37_1DataSet;
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
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Fam", true));
            this.famTextBox.Location = new System.Drawing.Point(121, 97);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(128, 25);
            this.famTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(121, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 25);
            this.nameTextBox.TabIndex = 4;
            // 
            // othTextBox
            // 
            this.othTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Oth", true));
            this.othTextBox.Location = new System.Drawing.Point(121, 194);
            this.othTextBox.Name = "othTextBox";
            this.othTextBox.Size = new System.Drawing.Size(128, 25);
            this.othTextBox.TabIndex = 6;
            // 
            // kartaNumTextBox
            // 
            this.kartaNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "KartaNum", true));
            this.kartaNumTextBox.Location = new System.Drawing.Point(467, 91);
            this.kartaNumTextBox.MaxLength = 20;
            this.kartaNumTextBox.Name = "kartaNumTextBox";
            this.kartaNumTextBox.Size = new System.Drawing.Size(133, 25);
            this.kartaNumTextBox.TabIndex = 8;
            this.kartaNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kartaNumTextBox_KeyPress);
            // 
            // kartaCVVTextBox
            // 
            this.kartaCVVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "KartaCVV", true));
            this.kartaCVVTextBox.Location = new System.Drawing.Point(467, 144);
            this.kartaCVVTextBox.MaxLength = 3;
            this.kartaCVVTextBox.Name = "kartaCVVTextBox";
            this.kartaCVVTextBox.Size = new System.Drawing.Size(58, 25);
            this.kartaCVVTextBox.TabIndex = 10;
            this.kartaCVVTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kartaCVVTextBox_KeyPress);
            // 
            // summaTextBox
            // 
            this.summaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Summa", true));
            this.summaTextBox.Location = new System.Drawing.Point(467, 237);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.Size = new System.Drawing.Size(133, 25);
            this.summaTextBox.TabIndex = 14;
            this.summaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.summaTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(119, 241);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(128, 25);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnSave.Location = new System.Drawing.Point(273, 382);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 52);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(453, 382);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 52);
            this.BtnCancel.TabIndex = 27;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TbxOldPass
            // 
            this.TbxOldPass.Location = new System.Drawing.Point(179, 319);
            this.TbxOldPass.Name = "TbxOldPass";
            this.TbxOldPass.Size = new System.Drawing.Size(223, 25);
            this.TbxOldPass.TabIndex = 26;
            this.TbxOldPass.UseSystemPasswordChar = true;
            // 
            // MtbxSrok
            // 
            this.MtbxSrok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sponsorBindingSource, "Scrok", true));
            this.MtbxSrok.Location = new System.Drawing.Point(471, 194);
            this.MtbxSrok.Mask = "99\\/99";
            this.MtbxSrok.Name = "MtbxSrok";
            this.MtbxSrok.Size = new System.Drawing.Size(65, 25);
            this.MtbxSrok.TabIndex = 29;
            // 
            // FormProfilrSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.MtbxSrok);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TbxOldPass);
            this.Controls.Add(label1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(summaLabel);
            this.Controls.Add(this.summaTextBox);
            this.Controls.Add(scrokLabel);
            this.Controls.Add(kartaCVVLabel);
            this.Controls.Add(this.kartaCVVTextBox);
            this.Controls.Add(kartaNumLabel);
            this.Controls.Add(this.kartaNumTextBox);
            this.Controls.Add(othLabel);
            this.Controls.Add(this.othTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProfilrSponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormProfilrSponsor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet;
        private u37_1DataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox othTextBox;
        private System.Windows.Forms.TextBox kartaNumTextBox;
        private System.Windows.Forms.TextBox kartaCVVTextBox;
        private System.Windows.Forms.TextBox summaTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.BindingSource sponsorBindingSource;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbxOldPass;
        private System.Windows.Forms.MaskedTextBox MtbxSrok;
    }
}