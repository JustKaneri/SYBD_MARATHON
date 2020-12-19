namespace СУБД_Марафон
{
    partial class FormProfileBegun
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label bdayLabel;
            System.Windows.Forms.Label stranaLabel;
            System.Windows.Forms.Label phonoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfileBegun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.u37_1DataSet = new СУБД_Марафон.u37_1DataSet();
            this.begunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.othTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.bdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stranaTextBox = new System.Windows.Forms.TextBox();
            this.phonoPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnAddPhoto = new System.Windows.Forms.Button();
            this.BtnDelPhoto = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbxOldPass = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            othLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            bdayLabel = new System.Windows.Forms.Label();
            stranaLabel = new System.Windows.Forms.Label();
            phonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(29, 103);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(71, 19);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(54, 146);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // othLabel
            // 
            othLabel.AutoSize = true;
            othLabel.Location = new System.Drawing.Point(21, 194);
            othLabel.Name = "othLabel";
            othLabel.Size = new System.Drawing.Size(73, 19);
            othLabel.TabIndex = 5;
            othLabel.Text = "Отчество:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(29, 370);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(107, 19);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Новый пароль:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(81, 328);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(38, 19);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Пол:";
            // 
            // bdayLabel
            // 
            bdayLabel.AutoSize = true;
            bdayLabel.Location = new System.Drawing.Point(11, 234);
            bdayLabel.Name = "bdayLabel";
            bdayLabel.Size = new System.Drawing.Size(108, 19);
            bdayLabel.TabIndex = 13;
            bdayLabel.Text = "Дата рождения";
            // 
            // stranaLabel
            // 
            stranaLabel.AutoSize = true;
            stranaLabel.Location = new System.Drawing.Point(62, 283);
            stranaLabel.Name = "stranaLabel";
            stranaLabel.Size = new System.Drawing.Size(57, 19);
            stranaLabel.TabIndex = 15;
            stranaLabel.Text = "Страна:";
            // 
            // phonoLabel
            // 
            phonoLabel.AutoSize = true;
            phonoLabel.Location = new System.Drawing.Point(386, 90);
            phonoLabel.Name = "phonoLabel";
            phonoLabel.Size = new System.Drawing.Size(45, 19);
            phonoLabel.TabIndex = 17;
            phonoLabel.Text = "Фото:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 422);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 19);
            label1.TabIndex = 21;
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
            this.panel1.Size = new System.Drawing.Size(627, 58);
            this.panel1.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(549, 58);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Профиль спортсмена";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(549, 0);
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
            // begunBindingSource
            // 
            this.begunBindingSource.DataMember = "Begun";
            this.begunBindingSource.DataSource = this.u37_1DataSet;
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
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Fam", true));
            this.famTextBox.Location = new System.Drawing.Point(151, 103);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(199, 25);
            this.famTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 146);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 25);
            this.nameTextBox.TabIndex = 4;
            // 
            // othTextBox
            // 
            this.othTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Oth", true));
            this.othTextBox.Location = new System.Drawing.Point(150, 194);
            this.othTextBox.Name = "othTextBox";
            this.othTextBox.Size = new System.Drawing.Size(200, 25);
            this.othTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(150, 370);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 25);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(150, 325);
            this.genderTextBox.MaxLength = 3;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 25);
            this.genderTextBox.TabIndex = 12;
            // 
            // bdayDateTimePicker
            // 
            this.bdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.begunBindingSource, "Bday", true));
            this.bdayDateTimePicker.Location = new System.Drawing.Point(150, 234);
            this.bdayDateTimePicker.Name = "bdayDateTimePicker";
            this.bdayDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.bdayDateTimePicker.TabIndex = 14;
            // 
            // stranaTextBox
            // 
            this.stranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.begunBindingSource, "Strana", true));
            this.stranaTextBox.Location = new System.Drawing.Point(150, 283);
            this.stranaTextBox.Name = "stranaTextBox";
            this.stranaTextBox.Size = new System.Drawing.Size(200, 25);
            this.stranaTextBox.TabIndex = 16;
            // 
            // phonoPictureBox
            // 
            this.phonoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phonoPictureBox.BackgroundImage")));
            this.phonoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phonoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phonoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.begunBindingSource, "Phono", true));
            this.phonoPictureBox.Location = new System.Drawing.Point(444, 90);
            this.phonoPictureBox.Name = "phonoPictureBox";
            this.phonoPictureBox.Size = new System.Drawing.Size(139, 123);
            this.phonoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phonoPictureBox.TabIndex = 18;
            this.phonoPictureBox.TabStop = false;
            // 
            // BtnAddPhoto
            // 
            this.BtnAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnAddPhoto.Location = new System.Drawing.Point(444, 223);
            this.BtnAddPhoto.Name = "BtnAddPhoto";
            this.BtnAddPhoto.Size = new System.Drawing.Size(167, 39);
            this.BtnAddPhoto.TabIndex = 19;
            this.BtnAddPhoto.Text = "Добавить";
            this.BtnAddPhoto.UseVisualStyleBackColor = false;
            this.BtnAddPhoto.Click += new System.EventHandler(this.BtnAddPhoto_Click);
            // 
            // BtnDelPhoto
            // 
            this.BtnDelPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnDelPhoto.Location = new System.Drawing.Point(444, 283);
            this.BtnDelPhoto.Name = "BtnDelPhoto";
            this.BtnDelPhoto.Size = new System.Drawing.Size(167, 38);
            this.BtnDelPhoto.TabIndex = 20;
            this.BtnDelPhoto.Text = "Удалить";
            this.BtnDelPhoto.UseVisualStyleBackColor = false;
            this.BtnDelPhoto.Click += new System.EventHandler(this.BtnDelPhoto_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnSave.Location = new System.Drawing.Point(265, 519);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 52);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(441, 519);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 52);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TbxOldPass
            // 
            this.TbxOldPass.Location = new System.Drawing.Point(151, 454);
            this.TbxOldPass.Name = "TbxOldPass";
            this.TbxOldPass.Size = new System.Drawing.Size(223, 25);
            this.TbxOldPass.TabIndex = 22;
            this.TbxOldPass.UseSystemPasswordChar = true;
            // 
            // FormProfileBegun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 583);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TbxOldPass);
            this.Controls.Add(label1);
            this.Controls.Add(this.BtnDelPhoto);
            this.Controls.Add(this.BtnAddPhoto);
            this.Controls.Add(phonoLabel);
            this.Controls.Add(this.phonoPictureBox);
            this.Controls.Add(stranaLabel);
            this.Controls.Add(this.stranaTextBox);
            this.Controls.Add(bdayLabel);
            this.Controls.Add(this.bdayDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
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
            this.Name = "FormProfileBegun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormProfileBegun_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox othTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.DateTimePicker bdayDateTimePicker;
        private System.Windows.Forms.TextBox stranaTextBox;
        private System.Windows.Forms.PictureBox phonoPictureBox;
        private System.Windows.Forms.Button BtnAddPhoto;
        private System.Windows.Forms.Button BtnDelPhoto;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbxOldPass;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        public System.Windows.Forms.BindingSource begunBindingSource;
    }
}