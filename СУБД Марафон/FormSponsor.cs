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
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);


        }
    }
}
