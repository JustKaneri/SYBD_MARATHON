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
            BsBegun.AddNew();
            BsSponsor.AddNew();

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

        /// <summary>
        /// Добавление фото.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(OpenImage.ShowDialog() == DialogResult.OK)
            {
                phonoPictureBox.Load(OpenImage.FileName);
            }
        }

        /// <summary>
        /// Удаление фото.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Удалить фотографию?","Удаление",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if(res == DialogResult.OK)
                phonoPictureBox.Image = null;
        }

        /// <summary>
        /// Регистрация спортсмена.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegBegun_Click(object sender, EventArgs e)
        {
            if (!Password.IsPasswordCorrect(passwordTbx.Text))
            {
                MessageBox.Show("Пароль не соответсвует требованиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordTbx.Text != TbxPas.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double z = Convert.ToDouble(summaTextBox.Text);
            }
            catch 
            {
                MessageBox.Show("Не корректная сумма.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BsBegun.EndEdit();
                this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);
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
        /// Показ пароля бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxShowPassSp_CheckedChanged(object sender, EventArgs e)
        {
            passwordTbx.UseSystemPasswordChar = !CbxShowPassSp.Checked;
            TbxPas.UseSystemPasswordChar = !CbxShowPassSp.Checked;
            CbxShowPassSp.Text = CbxShowPassSp.Checked ? "Скрыть пароль" : "Показать пароль";
        }

        /// <summary>
        /// Показ пароля спонсора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxShowPassSpon_CheckedChanged(object sender, EventArgs e)
        {
            passwordSpons.UseSystemPasswordChar = !CbxShowPassSpon.Checked;
            TbxRepPassSpon.UseSystemPasswordChar = !CbxShowPassSpon.Checked;
            CbxShowPassSpon.Text = CbxShowPassSpon.Checked ? "Скрыть пароль" : "Показать пароль";
        }

        /// <summary>
        /// Регистрация спонсора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegSpon_Click(object sender, EventArgs e)
        {
            if(kartaNumTextBox.Text.Length != 16 && kartaNumTextBox.Text.Length != 20)
            {
                MessageBox.Show("Длина номера карты должна быть 16 цифр, либо 20 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(kartaCVVTextBox.Text.Length != 3)
            {
                MessageBox.Show("Длина СVV карты должен состоять из 3 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Password.IsPasswordCorrect(passwordSpons.Text))
            {
                MessageBox.Show("Пароль не соответсвует требованиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordSpons.Text != TbxRepPassSpon.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if(DataKorrect(TbxSrok.Text))
            {
                MessageBox.Show("Не корректная дата", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BsSponsor.EndEdit();
                this.sponsorTableAdapter.Update(this.u37_1DataSet1.Sponsor);
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
        /// Проверка даты на корректность.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Boolean DataKorrect(String data)
        {
            int MM = Convert.ToInt32(TbxSrok.Text.Substring(0, 2));
            return (MM > 12 || MM == 0);
            
        }

        /// <summary>
        /// Ограничение ввода номера карты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kartaNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

        }

        /// <summary>
        /// Ограничение ввода CVV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kartaCVVTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;
        }

        /// <summary>
        /// Ограничение ввода суммы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void summaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (!summaTextBox1.Text.Contains(",") && e.KeyChar == ',' && !summaTextBox1.Text.StartsWith(","))
                e.Handled = false;
        }

        private void summaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (!summaTextBox1.Text.Contains(",") && e.KeyChar == ',' && !summaTextBox1.Text.StartsWith(","))
                e.Handled = false;
        }
    }
}
