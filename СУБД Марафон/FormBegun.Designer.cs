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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.u37_1DataSet1 = new СУБД_Марафон.u37_1DataSet();
            this.BsBegun = new System.Windows.Forms.BindingSource(this.components);
            this.begunTableAdapter = new СУБД_Марафон.u37_1DataSetTableAdapters.BegunTableAdapter();
            this.tableAdapterManager = new СУБД_Марафон.u37_1DataSetTableAdapters.TableAdapterManager();
            this.fIOLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(722, 58);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Рабочее место спортсмена";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(722, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(78, 58);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // u37_1DataSet1
            // 
            this.u37_1DataSet1.DataSetName = "u37_1DataSet";
            this.u37_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormBegun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.u37_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBegun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbxLogo;
        private u37_1DataSet u37_1DataSet1;
        private System.Windows.Forms.BindingSource BsBegun;
        private u37_1DataSetTableAdapters.BegunTableAdapter begunTableAdapter;
        private u37_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label fIOLabel1;
    }
}