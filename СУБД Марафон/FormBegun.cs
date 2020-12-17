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
    }
}
