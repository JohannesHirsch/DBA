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

namespace DBA_Bewerbe
{
    public partial class FrmTeilnehmendeMannschaft : Form
    {
        Model_FeuerwehrbewerbContainer context;
        public FrmTeilnehmendeMannschaft()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new Model_FeuerwehrbewerbContainer();

            this.context.tBewerbSet.Load();

            this.tTeilnehmendeMannschaftBindingSource.DataSource = context.tTeilnehmendeMannschaftSet.Local.ToBindingList();

            this.context.tBewerbSet.Load();
            this.tBewerbBindingSource.DataSource = this.context.tBewerbSet.Local.ToBindingList();

            this.context.tBewerbSet.Load();
            this.tMannschaftBindingSource.DataSource = this.context.tBewerbSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();

            this.dgvTeilnehmendeMannschaft.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
        }

        private void FrmTeilnehmendeMannschaft_Load(object sender, EventArgs e)
        {

        }
    }
}



