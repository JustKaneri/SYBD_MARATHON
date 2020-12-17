using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_Passw;

namespace СУБД_Марафон
{
    public partial class FormProfileZritel : Form
    {
        public FormProfileZritel()
        {
            InitializeComponent();
        }

        private string CurrentPass;

        private void FormProfileZritel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
            CurrentPass = PassTextBox.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(CurrentPass != TbxOldPass.Text)
            {
                MessageBox.Show("Не верный пароль","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if(!Password.IsPasswordCorrect(PassTextBox.Text))
            {
                MessageBox.Show("Пароль не соответствует требованиям.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(!IsMailCorect())
            {
                MessageBox.Show("Не корректный адрес E-mail.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BsZritel.EndEdit();
            this.zritelsTableAdapter.Update(this.u37_1DataSet1.Zritels);

            this.Close();
        }

        /// <summary>
        /// Функция проверяющая корректность Email адреса.
        /// </summary>
        /// <returns>
        /// Возвращает логическое значение true - верное, 
        /// false - неверное
        /// </returns>
        private Boolean IsMailCorect()
        {
            try
            {
                MailAddress mail = new MailAddress(emailTextBox.Text);
            }
            catch
            {
                return false;
            }

            string email = emailTextBox.Text;

            if (email.LastIndexOf(".") <= email.IndexOf("@"))
                return false;

            return true;
        }
    }
}
