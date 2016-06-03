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
    public partial class FrmTeilnehmer : Form
    {
        Model_FeuerwehrbewerbContainer context;
        public FrmTeilnehmer()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new Model_FeuerwehrbewerbContainer();

            this.context.tBewerbSet.Load();

            this.tTeilnehmerBindingSource.DataSource = context.tTeilnehmerSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();

            this.dgvTeilnehmer.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
        }
    }
}