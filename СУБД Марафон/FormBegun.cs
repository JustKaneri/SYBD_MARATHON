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
    public partial class FormBegun : Form
    {
        public FormBegun()
        {
            InitializeComponent();
        }

        private void FormBegun_Load(object sender, EventArgs e)
        {
            this.inventarBegunTableAdapter.Fill(this.u37_1DataSet1.InventarBegun);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Inventar' table. You can move, or remove it, as needed.
            this.inventarTableAdapter.Fill(this.u37_1DataSet1.Inventar);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sorevnovania' table. You can move, or remove it, as needed.
            this.sorevnovaniaTableAdapter.Fill(this.u37_1DataSet1.Sorevnovania);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Maraphon' table. You can move, or remove it, as needed.
            this.maraphonTableAdapter.Fill(this.u37_1DataSet1.Maraphon);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);

        }

        private void BtnProfBegun_Click(object sender, EventArgs e)
        {
            FormProfileBegun profileBegun = new FormProfileBegun();
            profileBegun.begunBindingSource.Filter = this.BsBegun.Filter;
            profileBegun.ShowDialog();
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

            string idMar = DgvAllMarap.CurrentRow.Cells[0].Value.ToString();
            BsSorevn.Filter = $"IdMaraphon = '{idMar}'";

            if(BsSorevn.Count >0)
            {
                BsSorevn.Filter = "";
                MessageBox.Show("Вы уже записаны на данный марафон", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BsSorevn.Filter = "";

            double prise = Convert.ToDouble(DgvAllMarap.CurrentRow.Cells[4].Value);
            double chet = Convert.ToDouble(LblSum.Text);

            if (prise > chet)
            {
                MessageBox.Show("Не достаточно средств для записи на марафон", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            chet -= prise;
            LblSum.Text = chet.ToString();

            BsSorevn.AddNew();

            DgvYourMaraph.CurrentRow.Cells[0].Value = idMar;

            BsSorevn.EndEdit();
            this.sorevnovaniaTableAdapter.Update(this.u37_1DataSet1.Sorevnovania);

            BsBegun.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);

            MessageBox.Show("Вы успешно записались на марафон.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelSel_Click(object sender, EventArgs e)
        {
            if(DgvYourMaraph.CurrentRow == null)
            {
                MessageBox.Show("Выберите марафон", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var res = MessageBox.Show("Вы хотите отменить запись на текущий марафон?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            
            double prise = Convert.ToDouble(DgvYourMaraph.CurrentRow.Cells[4].Value);
            double chet = Convert.ToDouble(LblSum.Text);

            DgvYourMaraph.Rows.Remove(DgvYourMaraph.CurrentRow);

            chet += prise;
            LblSum.Text = chet.ToString();

            BsBegun.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);

            BsSorevn.EndEdit();
            this.sorevnovaniaTableAdapter.Update(this.u37_1DataSet1.Sorevnovania);

            MessageBox.Show("Запись была отменена","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TbxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if(TbxCount.Text =="" || TbxCount.Text == "0")
            {
                MessageBox.Show("Укажите кол-во товара.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            string idMar = DgvAllInventar.CurrentRow.Cells[0].Value.ToString();

            double chet = Convert.ToDouble(LblSum.Text);
            int count = Convert.ToInt32(TbxCount.Text);
            double price = Convert.ToDouble(DgvAllInventar.CurrentRow.Cells[2].Value);

            double summ = price * count;

            if(summ > chet)
            {
                MessageBox.Show("Не достаточно средств для покупки.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            chet -= summ;
            LblSum.Text = chet.ToString();

            for (int i = 0; i < count; i++)
            {
                BsYourInvent.AddNew();
                DgvYourInvent.CurrentRow.Cells[0].Value = idMar;

                BsYourInvent.EndEdit();
                this.inventarBegunTableAdapter.Update(this.u37_1DataSet1.InventarBegun);
            }
           
            BsBegun.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);
        }
    }
}
