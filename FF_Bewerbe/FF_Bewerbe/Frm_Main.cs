using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FF_Bewerbe
{
    public partial class Frm_Main : Form
    {
        Model_FeuerwehrbewerbContainer context;



        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.context = new Model_FeuerwehrbewerbContainer();
            this.context.tBewerbSet.Load();
            //this.tBewerbBindingSource.DataSource = this.context.tBewerbSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();
            this.dgvBewerbe.Refresh();
        }
    }
}
