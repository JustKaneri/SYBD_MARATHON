using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Марафон
{
    public partial class FormLogIn : Form
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        public const string TxtCon = @"Data Source=213.155.192.79,3002;Initial Catalog=u37_1;Persist Security Info=True;User ID=u37_1;Password=fda2";

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbxTypeUser.SelectedIndex = 0;
        }

        private void CbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            TbxPass.UseSystemPasswordChar = !CbxShowPas.Checked;
            CbxShowPas.Text = CbxShowPas.Checked ? "Скрыть пароль" : "Показать пароль";
        }
    }
}
