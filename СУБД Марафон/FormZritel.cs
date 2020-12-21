using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace СУБД_Марафон
{
    public partial class FormZritel : Form
    {
        public FormZritel()
        {
            InitializeComponent();
        }

        private void FormZritel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sorevnovania' table. You can move, or remove it, as needed.
            this.sorevnovaniaTableAdapter.Fill(this.u37_1DataSet1.Sorevnovania);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Maraphon' table. You can move, or remove it, as needed.
            this.maraphonTableAdapter.Fill(this.u37_1DataSet1.Maraphon);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);

            CmbxFind.SelectedIndex = 0;

        }

        private void BtnProfZritel_Click(object sender, EventArgs e)
        {
            FormProfileZritel profileZritel = new FormProfileZritel();
            profileZritel.BsZritel.Filter = BsZritel.Filter;
            profileZritel.ShowDialog();
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
        }

        private void DgvBegun_SelectionChanged(object sender, EventArgs e)
        {
            DgvSponsor.Rows.Clear();
            double summm = 0;

            if (DgvBegun.CurrentRow == null)
            {
                LblSum.Text = "Спонсорская помощь: " + summm;
                return;
            }


            SqlConnection con = new SqlConnection(FormLogIn.TxtCon);
            con.Open();
            
            string txtQuery = @"Select s.Fam, s.Name, s.Summa
                        From Sponsor s,SponsorBegun sb
                        where s.IdSponsor = sb.idSponsor and sb.IdBegun = " + DgvBegun.CurrentRow.Cells[0].Value;

            SqlCommand query = new SqlCommand(txtQuery, con);

            SqlDataReader sqlData = query.ExecuteReader();

            if(sqlData.HasRows)
            {
                while (sqlData.Read())
                {
                    DgvSponsor.Rows.Add(sqlData["Fam"], sqlData["Name"], sqlData["Summa"]);
                    summm += Convert.ToDouble(sqlData["Summa"]);
                }
            }

            con.Close();

            LblSum.Text =  String.Format("Спонсорская помощь: {0:f2}",summm);
        }

        private void TbxFind_TextChanged(object sender, EventArgs e)
        {
            if(CmbxFind.SelectedIndex == 0)
            {
                for (int i = 0; i < DgvMaraphon.RowCount; i++)
                {
                    string Mar = DgvMaraphon.Rows[i].Cells[0].Value.ToString();

                    if(Mar.ToLower().StartsWith(TbxFind.Text.ToLower()))
                    {
                        DgvMaraphon.CurrentCell = DgvMaraphon.Rows[i].Cells[0];
                        DgvMaraphon.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            if(CmbxFind.SelectedIndex == 1)
            {
                for (int i = 0; i < DgvBegun.RowCount; i++)
                {
                    string Mar = DgvBegun.Rows[i].Cells[1].Value.ToString();

                    if (Mar.ToLower().StartsWith(TbxFind.Text.ToLower()))
                    {
                        DgvBegun.CurrentCell = DgvBegun.Rows[i].Cells[1];
                        DgvBegun.Rows[i].Selected = true;
                        DgvBegun_SelectionChanged(sender, e);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DgvSponsor.RowCount; i++)
                {
                    string Mar = DgvSponsor.Rows[i].Cells[0].Value.ToString();

                    if (Mar.ToLower().StartsWith(TbxFind.Text.ToLower()))
                    {
                        DgvSponsor.CurrentCell = DgvSponsor.Rows[i].Cells[0];
                        DgvSponsor.Rows[i].Selected = true;
                         
                        break;
                    }
                }
            }

        }
    }
}
