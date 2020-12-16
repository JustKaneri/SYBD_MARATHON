namespace СУБД_Марафон
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.CbxTypeUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.CbxShowPas = new System.Windows.Forms.CheckBox();
            this.LblRegestry = new System.Windows.Forms.Label();
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BsZritel = new System.Windows.Forms.BindingSource(this.components);
            this.zritelsTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.ZritelsTableAdapter();
            this.BsSponsor = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.SponsorTableAdapter();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(496, 74);
            this.panel1.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(418, 74);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Авторизация";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(418, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 74);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // CbxTypeUser
            // 
            this.CbxTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTypeUser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxTypeUser.FormattingEnabled = true;
            this.CbxTypeUser.Items.AddRange(new object[] {
            "Зритель",
            "Спортсмен",
            "Спонсор"});
            this.CbxTypeUser.Location = new System.Drawing.Point(44, 116);
            this.CbxTypeUser.Name = "CbxTypeUser";
            this.CbxTypeUser.Size = new System.Drawing.Size(393, 28);
            this.CbxTypeUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите тип пользователя:";
            // 
            // TbxLogin
            // 
            this.TbxLogin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLogin.Location = new System.Drawing.Point(78, 217);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(324, 28);
            this.TbxLogin.TabIndex = 3;
            this.TbxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbxPass
            // 
            this.TbxPass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPass.Location = new System.Drawing.Point(78, 309);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(324, 28);
            this.TbxPass.TabIndex = 4;
            this.TbxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.BtnLogIn.Location = new System.Drawing.Point(136, 406);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(212, 55);
            this.BtnLogIn.TabIndex = 7;
            this.BtnLogIn.Text = "Вход";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // CbxShowPas
            // 
            this.CbxShowPas.AutoSize = true;
            this.CbxShowPas.Location = new System.Drawing.Point(168, 351);
            this.CbxShowPas.Name = "CbxShowPas";
            this.CbxShowPas.Size = new System.Drawing.Size(139, 23);
            this.CbxShowPas.TabIndex = 8;
            this.CbxShowPas.Text = "Показать пароль";
            this.CbxShowPas.UseVisualStyleBackColor = true;
            this.CbxShowPas.CheckedChanged += new System.EventHandler(this.CbxShowPas_CheckedChanged);
            // 
            // LblRegestry
            // 
            this.LblRegestry.AutoSize = true;
            this.LblRegestry.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRegestry.ForeColor = System.Drawing.Color.Blue;
            this.LblRegestry.Location = new System.Drawing.Point(187, 477);
            this.LblRegestry.Name = "LblRegestry";
            this.LblRegestry.Size = new System.Drawing.Size(108, 19);
            this.LblRegestry.TabIndex = 9;
            this.LblRegestry.Text = "Регистрация";
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
            this.BsZritel.Filter = "";
            // 
            // zritelsTableAdapter
            // 
            this.zritelsTableAdapter.ClearBeforeFill = true;
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
            // BsBegun
            // 
            this.BsBegun.DataMember = "Begun";
            this.BsBegun.DataSource = this.u37_1DataSet1;
            // 
            // begunTableAdapter
            // 
            this.begunTableAdapter.ClearBeforeFill = true;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 518);
            this.Controls.Add(this.LblRegestry);
            this.Controls.Add(this.CbxShowPas);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxPass);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxTypeUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsZritel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsSponsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.ComboBox CbxTypeUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.CheckBox CbxShowPas;
        private System.Windows.Forms.Label LblRegestry;
        private u37_1DataSet u37_1DataSet1;
        private System.Windows.Forms.BindingSource BsZritel;
        private u37_1DataSetTableAdapters.ZritelsTableAdapter zritelsTableAdapter;
        private System.Windows.Forms.BindingSource BsSponsor;
        private u37_1DataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
    }
}

