namespace СУБД_Марафон
{
    partial class FormProfileZritel
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfileZritel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BsZritel = new System.Windows.Forms.BindingSource(this.components);
            this.zritelsTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.ZritelsTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.othTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.TbxOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            othLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(39, 110);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(71, 19);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(39, 161);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // othLabel
            // 
            othLabel.AutoSize = true;
            othLabel.Location = new System.Drawing.Point(39, 217);
            othLabel.Name = "othLabel";
            othLabel.Size = new System.Drawing.Size(73, 19);
            othLabel.TabIndex = 5;
            othLabel.Text = "Отчество:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(39, 272);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(352, 19);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Введите текущей пароль для сохранения изменений:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(430, 113);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 19);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(430, 164);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(67, 19);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 62);
            this.panel1.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(675, 62);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Профиль зрителя";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(675, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 62);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsZritel
            // 
            this.BsZritel.DataMember = "Zritels";
            this.BsZritel.DataSource = this.u37_1DataSet1;
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
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Fam", true));
            this.famTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famTextBox.Location = new System.Drawing.Point(135, 113);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(176, 27);
            this.famTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(135, 164);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // othTextBox
            // 
            this.othTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Oth", true));
            this.othTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othTextBox.Location = new System.Drawing.Point(135, 217);
            this.othTextBox.Name = "othTextBox";
            this.othTextBox.Size = new System.Drawing.Size(176, 27);
            this.othTextBox.TabIndex = 6;
            // 
            // PassTextBox
            // 
            this.PassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Password", true));
            this.PassTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(543, 217);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(200, 27);
            this.PassTextBox.TabIndex = 8;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(543, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 27);
            this.emailTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(543, 161);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 27);
            this.phoneTextBox.TabIndex = 12;
            // 
            // TbxOldPass
            // 
            this.TbxOldPass.Location = new System.Drawing.Point(168, 304);
            this.TbxOldPass.Name = "TbxOldPass";
            this.TbxOldPass.Size = new System.Drawing.Size(223, 25);
            this.TbxOldPass.TabIndex = 13;
            this.TbxOldPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Новый пароль:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(573, 346);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 52);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnSave.Location = new System.Drawing.Point(397, 346);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 52);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FormProfileZritel
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(753, 406);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxOldPass);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.PassTextBox);
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
            this.Name = "FormProfileZritel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormProfileZritel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet1;
        private u37_1DataSetTableAdapters.ZritelsTableAdapter zritelsTableAdapter;
        public System.Windows.Forms.BindingSource BsZritel;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox othTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox TbxOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}