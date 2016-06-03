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
    public partial class FrmMannschaften : Form
    {
        Model_FeuerwehrbewerbContainer context;
        public FrmMannschaften()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new Model_FeuerwehrbewerbContainer();

            this.context.tMannschaftSet.Load();

            this.tMannschaftBindingSource.DataSource = context.tMannschaftSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();

            this.dgvMannschaften.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
        }
    }
}
