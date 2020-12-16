using System;
using System.Windows.Forms;
using System.Net.Mail;
using DLL_Passw;
using System.Drawing;

namespace СУБД_Марафон
{
    public partial class FormRegestry : Form
    {
        public FormRegestry()
        {
            InitializeComponent();
        }


        private void FormRegestry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);

            BsZritel.AddNew();
            

        }

        /// <summary>
        /// Скрыть или показать символы пароля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !CbShowPass.Checked;
            TbxReplPass.UseSystemPasswordChar = !CbShowPass.Checked;
            CbShowPass.Text = CbShowPass.Checked ? "Скрыть пароль" : "Показать пароль";
        }
  
        /// <summary>
        /// Регистраця зрителя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegZritel_Click(object sender, EventArgs e)
        {
            if(!Password.IsPasswordCorrect(passwordTextBox.Text))
            {
                MessageBox.Show("Пароль не соответсвует требованиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(passwordTextBox.Text != TbxReplPass.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsMailCorect())
            {
                MessageBox.Show("Адрес E-mail некорректный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BsZritel.EndEdit();
                zritelsTableAdapter.Update(this.u37_1DataSet1.Zritels);
            }
            catch 
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            MessageBox.Show("Пользователь зарегистрирован", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(OpenImage.ShowDialog() == DialogResult.OK)
            {
                phonoPictureBox.Load(OpenImage.FileName);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Удалить фотографию?","Удаление",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if(res == DialogResult.OK)
                phonoPictureBox.Image = null;
        }

        private void BtnRegBegun_Click(object sender, EventArgs e)
        {
            BsBegun.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);
        }
    }
}
