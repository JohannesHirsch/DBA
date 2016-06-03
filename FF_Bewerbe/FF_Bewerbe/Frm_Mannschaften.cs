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
    public partial class Frm_Mannschaften : Form
    {
        public Frm_Mannschaften()
        {
            InitializeComponent();
        }

        private void Frm_Mannschaften_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_BewerbDataSet1.tMannschaftSet' table. You can move, or remove it, as needed.
            //this.tMannschaftSetTableAdapter.Fill(this.dB_BewerbDataSet.tMannschaftSet);

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            //this.dgvMannschaften.EndEdit();
            //this.tMannschaftSetTableAdapter.Update(this.dB_BewerbDataSet.tMannschaftSet);
        }
    }
}
