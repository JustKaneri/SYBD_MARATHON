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
    public partial class FormZritel : Form
    {
        public FormZritel()
        {
            InitializeComponent();
        }

        private void FormZritel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);

        }
    }
}
