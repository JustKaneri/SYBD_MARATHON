using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Марафон
{
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);

            // TODO: This line of code loads data into the 'u37_1DataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
        }

        private void BtnProfSponsor_Click(object sender, EventArgs e)
        {
            FormProfilrSponsor profilrSponsor = new FormProfilrSponsor();
            profilrSponsor.sponsorBindingSource.Filter = this.BsSponsor.Filter;
            profilrSponsor.ShowDialog();
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
            
        }

        private void BtnSetSum_Click(object sender, EventArgs e)
        {
            if (TbxSumPopoln.Text == "")
                return;

            double summ = double.Parse(LblSumm.Text);
            double summAdd = double.Parse(TbxSumPopoln.Text);

            if (!IsDataKart(MtbSrok.Text))
            {
                MessageBox.Show("Пополнение счета не возможно, срок годности карты истек");
                return;
            }

            summ += summAdd;
            LblSumm.Text = summ.ToString();

            BsSponsor.EndEdit();

            this.sponsorTableAdapter.Update(this.u37_1DataSet1.Sponsor);

            TbxSumPopoln.Clear();
        }

        /// <summary>
        /// Проверка даты на срок годности.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Boolean IsDataKart(string data)
        {
            data = data.Insert(3, "20");
            DateTime dt = Convert.ToDateTime(data);

            dt = dt.AddDays(30);
            
            return dt > DateTime.Now;
        }

        /// <summary>
        /// Ограничение ввода суммы пополнения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxSumPopoln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (!TbxSumPopoln.Text.Contains(",") && e.KeyChar == ',' && !TbxSumPopoln.Text.StartsWith(","))
                e.Handled = false;
        }

        /// <summary>
        /// Добавление в бд записи о взносе.
        /// </summary>
        /// <param name="summ"></param>
        private void AddBegunSponsor(double summ)
        {
            SqlConnection con = new SqlConnection(FormLogIn.TxtCon);
            con.Open();

            string txtQuery = @"insert Into SponsorBegun
                                Values(@IdSpons,@idBegun,@Summ)";

            SqlCommand query = new SqlCommand(txtQuery, con);
            query.Parameters.AddWithValue("@IdSpons", LblIdSponsor.Text);
            query.Parameters.AddWithValue("@idBegun", LblIdBegun.Text);
            query.Parameters.AddWithValue("@Summ", summ);

            query.ExecuteNonQuery();

            con.Close();
        }

        /// <summary>
        /// Обработчик взноса спортсмену.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTake_Click(object sender, EventArgs e)
        {
            if (TbxTakeSum.Text == "")
                return;

            double summ = Convert.ToDouble(DgvBegun.CurrentRow.Cells[1].Value);
            double summAdd = Convert.ToDouble(TbxTakeSum.Text);
            double summSponsora = Convert.ToDouble(LblSumm.Text);
            
            if(summSponsora < summAdd)
            {
                MessageBox.Show("Не достаточно средств");
                TbxTakeSum.Clear();
                return;
            }

            if(!IsDataKart(MtbSrok.Text))
            {
                MessageBox.Show("Пополнение счета не возможно, срок годности карты истек");
                return;
            }

            summ += summAdd;
            summSponsora -= summAdd;
            LblSumm.Text = summSponsora.ToString();
            DgvBegun.CurrentRow.Cells[1].Value = summ;

            AddBegunSponsor(summAdd);

            BsBegun.EndEdit();
            this.begunTableAdapter.Update(this.u37_1DataSet1.Begun);

            BsSponsor.EndEdit();
            this.sponsorTableAdapter.Update(this.u37_1DataSet1.Sponsor);

            TbxTakeSum.Clear();
        }

        /// <summary>
        /// Ограничения ввода суммы пожертвования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxTakeSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (!TbxTakeSum.Text.Contains(",") && e.KeyChar == ',' && !TbxTakeSum.Text.StartsWith(","))
                e.Handled = false;
        }
    }
}
