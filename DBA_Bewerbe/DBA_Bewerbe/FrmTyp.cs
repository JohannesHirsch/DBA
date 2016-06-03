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
    public partial class FrmTyp : Form
    {
        Model_FeuerwehrbewerbContainer context;
        public FrmTyp()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new Model_FeuerwehrbewerbContainer();

            this.context.tBewerbSet.Load();

            this.tTypBindingSource.DataSource = context.tTypSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();

            this.dgvTyp.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
        }
    }
}
