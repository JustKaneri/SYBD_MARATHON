namespace СУБД_Марафон
{
    partial class FormRegestry
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegestry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.TbRegestry = new System.Windows.Forms.TabControl();
            this.PageZritel = new System.Windows.Forms.TabPage();
            this.CbShowPass = new System.Windows.Forms.CheckBox();
            this.BtnRegZritel = new System.Windows.Forms.Button();
            this.TbxReplPass = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.BsZritel = new System.Windows.Forms.BindingSource(this.components);
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.othTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.PageSponsor = new System.Windows.Forms.TabPage();
            this.PageBegun = new System.Windows.Forms.TabPage();
            this.BtnRegBegun = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.phonoPictureBox = new System.Windows.Forms.PictureBox();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.BsSponsor = new System.Windows.Forms.BindingSource(this.components);
            this.zritelsTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.ZritelsTableAdapter();
            this.sponsorTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SponsorTableAdapter();
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            othLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.TbRegestry.SuspendLayout();
            this.PageZritel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            this.PageBegun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(98, 13);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(71, 19);
            famLabel.TabIndex = 0;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(485, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя:";
            // 
            // othLabel
            // 
            othLabel.AutoSize = true;
            othLabel.Location = new System.Drawing.Point(446, 81);
            othLabel.Name = "othLabel";
            othLabel.Size = new System.Drawing.Size(73, 19);
            othLabel.TabIndex = 4;
            othLabel.Text = "Отчество:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(109, 81);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(52, 19);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(109, 147);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(60, 19);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Пароль:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(485, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 19);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(450, 219);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(67, 19);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(84, 219);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 19);
            label1.TabIndex = 15;
            label1.Text = "Повторите пароль:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 74);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(657, 74);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Регистрация";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(657, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 74);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // TbRegestry
            // 
            this.TbRegestry.Controls.Add(this.PageZritel);
            this.TbRegestry.Controls.Add(this.PageSponsor);
            this.TbRegestry.Controls.Add(this.PageBegun);
            this.TbRegestry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbRegestry.Location = new System.Drawing.Point(0, 74);
            this.TbRegestry.Name = "TbRegestry";
            this.TbRegestry.SelectedIndex = 0;
            this.TbRegestry.Size = new System.Drawing.Size(735, 407);
            this.TbRegestry.TabIndex = 2;
            // 
            // PageZritel
            // 
            this.PageZritel.Controls.Add(this.CbShowPass);
            this.PageZritel.Controls.Add(this.BtnRegZritel);
            this.PageZritel.Controls.Add(label1);
            this.PageZritel.Controls.Add(this.TbxReplPass);
            this.PageZritel.Controls.Add(phoneLabel);
            this.PageZritel.Controls.Add(this.phoneTextBox);
            this.PageZritel.Controls.Add(emailLabel);
            this.PageZritel.Controls.Add(this.emailTextBox);
            this.PageZritel.Controls.Add(passwordLabel);
            this.PageZritel.Controls.Add(this.passwordTextBox);
            this.PageZritel.Controls.Add(loginLabel);
            this.PageZritel.Controls.Add(this.loginTextBox);
            this.PageZritel.Controls.Add(othLabel);
            this.PageZritel.Controls.Add(this.othTextBox);
            this.PageZritel.Controls.Add(nameLabel);
            this.PageZritel.Controls.Add(this.nameTextBox);
            this.PageZritel.Controls.Add(famLabel);
            this.PageZritel.Controls.Add(this.famTextBox);
            this.PageZritel.Location = new System.Drawing.Point(4, 26);
            this.PageZritel.Name = "PageZritel";
            this.PageZritel.Padding = new System.Windows.Forms.Padding(3);
            this.PageZritel.Size = new System.Drawing.Size(727, 377);
            this.PageZritel.TabIndex = 0;
            this.PageZritel.Text = "Регистрация зрителя";
            this.PageZritel.UseVisualStyleBackColor = true;
            // 
            // CbShowPass
            // 
            this.CbShowPass.AutoSize = true;
            this.CbShowPass.Location = new System.Drawing.Point(76, 283);
            this.CbShowPass.Name = "CbShowPass";
            this.CbShowPass.Size = new System.Drawing.Size(139, 23);
            this.CbShowPass.TabIndex = 17;
            this.CbShowPass.Text = "Показать пароль";
            this.CbShowPass.UseVisualStyleBackColor = true;
            this.CbShowPass.CheckedChanged += new System.EventHandler(this.CbShowPass_CheckedChanged);
            // 
            // BtnRegZritel
            // 
            this.BtnRegZritel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnRegZritel.Location = new System.Drawing.Point(253, 327);
            this.BtnRegZritel.Name = "BtnRegZritel";
            this.BtnRegZritel.Size = new System.Drawing.Size(173, 44);
            this.BtnRegZritel.TabIndex = 16;
            this.BtnRegZritel.Text = "Регистрация";
            this.BtnRegZritel.UseVisualStyleBackColor = false;
            this.BtnRegZritel.Click += new System.EventHandler(this.BtnRegZritel_Click);
            // 
            // TbxReplPass
            // 
            this.TbxReplPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxReplPass.Location = new System.Drawing.Point(33, 241);
            this.TbxReplPass.Name = "TbxReplPass";
            this.TbxReplPass.Size = new System.Drawing.Size(230, 27);
            this.TbxReplPass.TabIndex = 14;
            this.TbxReplPass.UseSystemPasswordChar = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(380, 241);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(230, 27);
            this.phoneTextBox.TabIndex = 13;
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
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(380, 175);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(310, 27);
            this.emailTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(32, 169);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(230, 27);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Login", true));
            this.loginTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(33, 103);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(230, 27);
            this.loginTextBox.TabIndex = 7;
            // 
            // othTextBox
            // 
            this.othTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Oth", true));
            this.othTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.othTextBox.Location = new System.Drawing.Point(380, 103);
            this.othTextBox.Name = "othTextBox";
            this.othTextBox.Size = new System.Drawing.Size(230, 27);
            this.othTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(380, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsZritel, "Fam", true));
            this.famTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famTextBox.Location = new System.Drawing.Point(32, 35);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(230, 27);
            this.famTextBox.TabIndex = 1;
            // 
            // PageSponsor
            // 
            this.PageSponsor.Location = new System.Drawing.Point(4, 26);
            this.PageSponsor.Name = "PageSponsor";
            this.PageSponsor.Padding = new System.Windows.Forms.Padding(3);
            this.PageSponsor.Size = new System.Drawing.Size(727, 377);
            this.PageSponsor.TabIndex = 1;
            this.PageSponsor.Text = "Регистрация спонсора";
            this.PageSponsor.UseVisualStyleBackColor = true;
            // 
            // PageBegun
            // 
            this.PageBegun.Controls.Add(this.BtnRegBegun);
            this.PageBegun.Controls.Add(this.BtnDel);
            this.PageBegun.Controls.Add(this.BtnAdd);
            this.PageBegun.Controls.Add(this.phonoPictureBox);
            this.PageBegun.Location = new System.Drawing.Point(4, 26);
            this.PageBegun.Name = "PageBegun";
            this.PageBegun.Padding = new System.Windows.Forms.Padding(3);
            this.PageBegun.Size = new System.Drawing.Size(727, 377);
            this.PageBegun.TabIndex = 2;
            this.PageBegun.Text = "Регистрация спортсмена";
            this.PageBegun.UseVisualStyleBackColor = true;
            // 
            // BtnRegBegun
            // 
            this.BtnRegBegun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnRegBegun.Location = new System.Drawing.Point(265, 325);
            this.BtnRegBegun.Name = "BtnRegBegun";
            this.BtnRegBegun.Size = new System.Drawing.Size(173, 44);
            this.BtnRegBegun.TabIndex = 17;
            this.BtnRegBegun.Text = "Регистрация";
            this.BtnRegBegun.UseVisualStyleBackColor = false;
            this.BtnRegBegun.Click += new System.EventHandler(this.BtnRegBegun_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnDel.Location = new System.Drawing.Point(560, 182);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(149, 45);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnAdd.Location = new System.Drawing.Point(560, 134);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 41);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // phonoPictureBox
            // 
            this.phonoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phonoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.BsBegun, "Phono", true));
            this.phonoPictureBox.Location = new System.Drawing.Point(560, 19);
            this.phonoPictureBox.Name = "phonoPictureBox";
            this.phonoPictureBox.Size = new System.Drawing.Size(149, 108);
            this.phonoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonoPictureBox.TabIndex = 1;
            this.phonoPictureBox.TabStop = false;
            // 
            // BsBegun
            // 
            this.BsBegun.DataMember = "Begun";
            this.BsBegun.DataSource = this.u37_1DataSet1;
            // 
            // BsSponsor
            // 
            this.BsSponsor.DataMember = "Sponsor";
            this.BsSponsor.DataSource = this.u37_1DataSet1;
            // 
            // zritelsTableAdapter
            // 
            this.zritelsTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SponsorTableAdapter = this.sponsorTableAdapter;
            this.tableAdapterManager.UpdateOrder = СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZritelsTableAdapter = this.zritelsTableAdapter;
            // 
            // FormRegestry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 481);
            this.Controls.Add(this.TbRegestry);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegestry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.FormRegestry_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.TbRegestry.ResumeLayout(false);
            this.PageZritel.ResumeLayout(false);
            this.PageZritel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            this.PageBegun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phonoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.TabControl TbRegestry;
        private System.Windows.Forms.TabPage PageZritel;
        private System.Windows.Forms.TabPage PageSponsor;
        private System.Windows.Forms.TabPage PageBegun;
        private u37_1DataSet u37_1DataSet1;
        private System.Windows.Forms.BindingSource BsZritel;
        private System.Windows.Forms.BindingSource BsSponsor;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.ZritelsTableAdapter zritelsTableAdapter;
        private u37_1DataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private System.Windows.Forms.Button BtnRegZritel;
        private System.Windows.Forms.TextBox TbxReplPass;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox othTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox CbShowPass;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.PictureBox phonoPictureBox;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.Button BtnRegBegun;
    }
}