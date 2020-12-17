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
    public partial class FormProfileBegun : Form
    {
        public FormProfileBegun()
        {
            InitializeComponent();
        }

        private string CurrentPass;


        private void FormProfileBegun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet.Begun);
            CurrentPass = passwordTextBox.Text;
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                phonoPictureBox.Load(OpenFile.FileName);
            }
        }

        private void BtnDelPhoto_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Удалить фото?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(res == DialogResult.OK)
            {
                phonoPictureBox.Image = null;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if(CurrentPass != TbxOldPass.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Password.IsPasswordCorrect(passwordTextBox.Text))
            {
                MessageBox.Show("Пароль не соответствует требованиям.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            begunBindingSource.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet.Begun);
            this.Close();
        }

    }
}
