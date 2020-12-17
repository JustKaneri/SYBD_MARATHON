using DLL_Passw;
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
    public partial class FormProfilrSponsor : Form
    {
        public FormProfilrSponsor()
        {
            InitializeComponent();
        }

        private string CurrentPass;

        private void FormProfilrSponsor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet.Sponsor);
            CurrentPass = passwordTextBox.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (kartaNumTextBox.Text.Length != 16 && kartaNumTextBox.Text.Length != 20)
            {
                MessageBox.Show("Длина номера карты должна быть 16 цифр, либо 20 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (kartaCVVTextBox.Text.Length != 3)
            {
                MessageBox.Show("Длина СVV карты должен состоять из 3 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CurrentPass != TbxOldPass.Text)
            {
                MessageBox.Show("Не верный пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (!Password.IsPasswordCorrect(passwordTextBox.Text))
            //{
            //    MessageBox.Show("Пароль не соответствует требованиям.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            if(DataKorrect(MtbxSrok.Text))
            {
                MessageBox.Show("Не корректная дата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            sponsorBindingSource.EndEdit();
            this.sponsorTableAdapter.Update(this.u37_1DataSet.Sponsor);

            this.Close();
        }

        /// <summary>
        /// Проверка даты на корректность.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Boolean DataKorrect(String data)
        {
            int MM = Convert.ToInt32(data.Substring(0, 2));
            return (MM > 12 || MM == 0);

        }

        private void kartaNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;
        }

        private void kartaCVVTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;
        }

        private void summaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (!summaTextBox.Text.Contains(",") && e.KeyChar == ',' && !summaTextBox.Text.StartsWith(","))
                e.Handled = false;
        }

       
    }
}
