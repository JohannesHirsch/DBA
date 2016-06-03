using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF_Bewerbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_BewerbDataSet.tBewerbSet' table. You can move, or remove it, as needed.
            this.tBewerbSetTableAdapter.Fill(this.dB_BewerbDataSet.tBewerbSet);

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.dgvBewerbe.EndEdit();
            this.tBewerbSetTableAdapter.Update(this.dB_BewerbDataSet.tBewerbSet);
        }
    }
}
